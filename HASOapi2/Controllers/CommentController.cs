using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using HASOapi2.Models;
using HASOapi2.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HASOapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IDataRepository<Comment> _dataRepository;

        public CommentController(IDataRepository<Comment> dataRepository)
        {
            _dataRepository = dataRepository;
        }


        // GET: api/Comment
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Comment> Comments = _dataRepository.GetAll();
            return Ok(Comments);
        }

        // GET: api/Comment/5
        [HttpGet("{id}", Name = "GetComment")]
        public IActionResult Get(long id)
        {
            Comment Comment = _dataRepository.Get(id);

            if (Comment == null)
            {
                return NotFound("The Comment record couldn't be found.");
            }

            return Ok(Comment);
        }

        // POST: api/Comment
        [HttpPost]
        public IActionResult Post([FromBody] Comment Comment)
        {
            if (Comment == null)
            {
                return BadRequest("Comment is null.");
            }

            _dataRepository.Add(Comment);
            return CreatedAtRoute(
                  "Get",
                  new { Id = Comment.Id },
                  Comment);
        }

        // PUT: api/Comment/5
        [HttpPut]
        public IActionResult Put( [FromBody] Comment Comment)
        {
            if (Comment == null)
            {
                return BadRequest("Comment is null.");
            }

            Comment CommentToUpdate = _dataRepository.Get(Comment.Id);
            if (CommentToUpdate == null)
            {
                return NotFound("The Comment record couldn't be found.");
            }

            _dataRepository.Update(CommentToUpdate, Comment);
            return NoContent();
        }

        // DELETE: api/Comment/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Comment Comment = _dataRepository.Get(id);
            if (Comment == null)
            {
                return NotFound("The Comment record couldn't be found.");
            }

            _dataRepository.Delete(Comment);
            return NoContent();
        }
    }
}