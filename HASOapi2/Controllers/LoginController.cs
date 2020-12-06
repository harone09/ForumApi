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
    public class LoginController : ControllerBase
    {

        private readonly IDataRepository<User> _dataRepository;

        public LoginController(IDataRepository<User> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // PUT: api/Login/5
        [HttpPut]
        public IActionResult Put([FromBody] User User)
        {
            if (User == null)
            {
                return BadRequest("User is null.");
            }


            User usr = _dataRepository.GetAll().Where(n => n.Password == User.Password && (n.Login == User.Email || n.Email == User.Email)).FirstOrDefault();


            return Ok(usr);
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User User)
        {
            if (User == null)
            {
                return BadRequest("User is null.");
            }

            _dataRepository.Add(User);
            return CreatedAtRoute(
                  "Get",
                  new { Id = User.Id },
                  User);

        }

    }
}