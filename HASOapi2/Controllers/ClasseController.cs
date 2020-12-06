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
    public class ClasseController : ControllerBase
    {

        private readonly IDataRepository<Classe> _dataRepository;

        public ClasseController(IDataRepository<Classe> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Classe
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Classe> Classes = _dataRepository.GetAll();
            return Ok(Classes);
        }

        // GET: api/Classe/5
        [HttpGet("{id}", Name = "GetClasse")]
        public IActionResult Get(long id)
        {
            IEnumerable<Classe> Classe = _dataRepository.GetAll().Where(n => n.IdProf == id);

            if (Classe == null)
            {
                return NotFound("The Classe record couldn't be found.");
            }

            return Ok(Classe);
        }

        // POST: api/Classe
        [HttpPost]
        public IActionResult Post([FromBody] Classe Classe)
        {
            if (Classe == null)
            {
                return BadRequest("Classe is null.");
            }

            _dataRepository.Add(Classe);
            return CreatedAtRoute(
                  "Get",
                  new { Id = Classe.Id },
                  Classe);
        }

        // PUT: api/Classe/5
        [HttpPut]
        public IActionResult Put([FromBody] Classe Classe)
        {
            if (Classe == null)
            {
                return BadRequest("Classe is null.");
            }

            Classe ClasseToUpdate = _dataRepository.Get(Classe.Id);
            if (ClasseToUpdate == null)
            {
                return NotFound("The Classe record couldn't be found.");
            }

            _dataRepository.Update(ClasseToUpdate, Classe);
            return NoContent();
        }

        // DELETE: api/Classe/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Classe Classe = _dataRepository.Get(id);
            if (Classe == null)
            {
                return NotFound("The Classe record couldn't be found.");
            }

            _dataRepository.Delete(Classe);
            return NoContent();
        }





    }
}