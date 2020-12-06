using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HASOapi2.Models;
using HASOapi2.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HASOapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadedfileController : ControllerBase
    {
         private readonly IDataRepository<Uploadedfile> _dataRepository;


        public UploadedfileController( IDataRepository<Uploadedfile> dataRepository)
        {
            _dataRepository = dataRepository;

        }

        // GET: api/Uploadedfile
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Uploadedfile> Uploadedfiles = _dataRepository.GetAll();
            return Ok(Uploadedfiles);
        }

        // GET: api/Uploadedfile/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Uploadedfile Uploadedfile = _dataRepository.Get(id);

            if (Uploadedfile == null)
            {
                return NotFound("The Uploadedfile record couldn't be found.");
            }

            return Ok(Uploadedfile);
        }

        // POST: api/Uploadedfile
        [HttpPost]
        public IActionResult Post([FromBody] Uploadedfile u)
        {
            if (u == null)
            {
                return BadRequest("Uploadedfile is null.");
            }

            Uploadedfile f = new Uploadedfile{Date= u.Date,IdPublication=u.IdPublication,IdUser=u.IdUser,path=u.path };
            Console.WriteLine("//////////////////////////////////file1///////////////////////////////");
            _dataRepository.Add(f);
            return CreatedAtRoute(
                  "Get",
                  new { Id = f.Id },
                  f);
        }

        // PUT: api/Uploadedfile/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Uploadedfile Uploadedfile)
        {
            if (Uploadedfile == null)
            {
                return BadRequest("Uploadedfile is null.");
            }

            Uploadedfile UploadedfileToUpdate = _dataRepository.Get(id);
            if (UploadedfileToUpdate == null)
            {
                return NotFound("The Uploadedfile record couldn't be found.");
            }

            _dataRepository.Update(UploadedfileToUpdate, Uploadedfile);
            return NoContent();
        }

        // DELETE: api/Uploadedfile/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Uploadedfile Uploadedfile = _dataRepository.Get(id);
            if (Uploadedfile == null)
            {
                return NotFound("The Uploadedfile record couldn't be found.");
            }

            _dataRepository.Delete(Uploadedfile);
            return NoContent();
        }
    }
}