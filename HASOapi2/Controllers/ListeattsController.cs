using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HASOapi2.Models;
using HASOapi2.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HASOapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListeattsController : ControllerBase
    {
        private readonly IDataRepository<Listeatt> _dataRepository;

        public ListeattsController(IDataRepository<Listeatt> dataRepository)
        {
            _dataRepository = dataRepository;
        }



        // GET: api/Listeatts
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("this is the ///////////////////////////////////////////////////////////////////////");

            IEnumerable<Listeatt> list = _dataRepository.GetAll();
            return Ok(list);
        }


        // GET: api/Listeatts/5
        [HttpGet("{id}", Name = "getListeatt")]
        public IActionResult Get(long id)
        {
            IEnumerable<Listeatt> listeatts = _dataRepository.GetAll().Where(n => n.idc == id);

            if (listeatts == null)
            {
                return NotFound("The Classe record couldn't be found.");
            }

            return Ok(listeatts);
        }

        // PUT: api/Listeatts/5
        [HttpPut]
        public IActionResult Put(long id, [FromBody] Listeatt listeatt)
        {
            if (listeatt == null)
            {
                return BadRequest("Liste is null.");
            }

            Listeatt listeat = _dataRepository.Get(id);
            if (listeat == null)
            {
                return NotFound("The Liste record couldn't be found.");
            }

            _dataRepository.Update(listeat, listeatt);
            return NoContent();
        }

        // POST: api/Listeatts
        [HttpPost]
        public IActionResult Post([FromBody] Listeatt Listeatt)
        {
            Console.WriteLine("this is the ///////////////////////////////////////////////////////////////////////");

            if (Listeatt == null)
            {
                return BadRequest("Comment is null.");
            }

            _dataRepository.Add(Listeatt);
            return CreatedAtRoute(
                  "Get",
                  new { Id = Listeatt.Id },
                  Listeatt);
        }




        // DELETE: api/Listeatts/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Listeatt listeatt = _dataRepository.Get(id);
            if (listeatt == null)
            {
                return NotFound("The List record couldn't be found.");
            }

            _dataRepository.Delete(listeatt);
            return NoContent();
        }

    }
}