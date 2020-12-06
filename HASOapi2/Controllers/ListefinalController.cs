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
    public class ListefinalController : ControllerBase
    {
        private readonly IDataRepository<Listefinal> _dataRepository;

        public ListefinalController(IDataRepository<Listefinal> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Listefinal
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("this is the ///////////////////////////////////////////////////////////////////////");

            IEnumerable<Listefinal> listefinals = _dataRepository.GetAll();
            return Ok(listefinals);
        }

        // GET: api/Listefinal/5
        [HttpGet("{id}", Name = "GetListfinal")]
        public IActionResult Get(long id)
        {
            IEnumerable<Listefinal> listefinals = _dataRepository.GetAll().Where(n => n.Id == id);

            if (listefinals == null)
            {
                return NotFound("The Classe record couldn't be found.");
            }

            return Ok(listefinals);
        }

        // POST: api/Listefinal
        [HttpPost]
        public IActionResult Post([FromBody] Listefinal listefinal)
        {
            Console.WriteLine("this is the ///////////////////////////////////////////////////////////////////////");
            if (listefinal == null)
            {
                return BadRequest("Classe is null.");
            }

            _dataRepository.Add(listefinal);
            return CreatedAtRoute(
                  "Get",
                  new { Id = listefinal.Id },
                  listefinal);
        }

        // PUT: api/Listefinal/5
        [HttpPut]
        public IActionResult Put([FromBody] Listefinal listefinal)
        {
            if (listefinal == null)
            {
                return BadRequest("Classe is null.");
            }

            Listefinal ClasseToUpdate = _dataRepository.Get(listefinal.Id);
            if (ClasseToUpdate == null)
            {
                return NotFound("The Classe record couldn't be found.");
            }

            _dataRepository.Update(ClasseToUpdate, listefinal);
            return NoContent();
        }

        // DELETE: api/Listefinal/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Listefinal listefinal = _dataRepository.Get(id);
            if (listefinal == null)
            {
                return NotFound("The Classe record couldn't be found.");
            }

            _dataRepository.Delete(listefinal);
            return NoContent();
        }

    }
}