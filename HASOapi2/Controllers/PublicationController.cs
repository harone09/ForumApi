using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HASOapi2.Models;
using HASOapi2.Models.Repository;
using System.IO;

namespace HASOapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IDataRepository<Publication> _dataRepository;


        public PublicationController(IDataRepository<Publication> dataRepository)
        {
            _dataRepository = dataRepository;

        }
        // GET: api/Publication
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Publication> Publications = _dataRepository.GetAll();
            Console.WriteLine("the methode works");

            return Ok(Publications);
        }

        // GET: api/Publication/5
        [HttpGet("{id}", Name = "GetPublication")]
        public IActionResult Get(long id)
        {
            IEnumerable<Publication> Publications = _dataRepository.GetAll().Where(n=>n.IdClasse==id);

            if (Publications == null)
            {
                return NotFound("The Publication record couldn't be found.");
            }

            return Ok(Publications);
        }

        // POST: api/Publication
        [HttpPost]
        public IActionResult Post([FromBody] Publication p)
        {
            if (p == null)
            {
                return BadRequest("Publication is null.");
            }
            Console.WriteLine(" post the methode works");

            Publication pp = new Publication { Contenus = p.Contenus, Date = p.Date, IdClasse = p.IdClasse, IdUser = p.IdUser };
           
            var folderName = Path.Combine("Ressources", "temp");
            var pathToFolder = Path.Combine(Directory.GetCurrentDirectory(), folderName);


            _dataRepository.Add(pp);
            foreach (string file in Directory.EnumerateFiles(
            pathToFolder,
            "*",
            SearchOption.AllDirectories)
            )
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("asfasfsaf");
            return Ok(pp);
        }

        // PUT: api/Publication/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Publication Publication)
        {
            if (Publication == null)
            {
                return BadRequest("Publication is null.");
            }

            Publication PublicationToUpdate = _dataRepository.Get(id);
            if (PublicationToUpdate == null)
            {
                return NotFound("The Publication record couldn't be found.");
            }

            _dataRepository.Update(PublicationToUpdate, Publication);
            return NoContent();
        }

        // DELETE: api/Publication/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Publication Publication = _dataRepository.Get(id);
            if (Publication == null)
            {
                return NotFound("The Publication record couldn't be found.");
            }

            _dataRepository.Delete(Publication);
            return NoContent();
        }
    }
}