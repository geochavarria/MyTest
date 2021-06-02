using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTest.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await userRepository.GetAllAsync());
        }

        [HttpGet]
        [Route("Add")]
        public async Task<IActionResult> Add()
        {
            return Ok(await userRepository.AddAsync(new Domain.Models.User
            {
                UserId = 4,
                FirstName = "Geo",
                LastName = "Chase"
            }));
        }
    }
}
