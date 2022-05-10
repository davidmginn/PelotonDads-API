using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PelotonDadsChallenge.API.Models;
using Microsoft.AspNetCore.Authorization;
using PelotonDadsChallenge.API.Services;
using System.Security.Cryptography;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PelotonDadsChallenge.API.Controllers
{
    [Route("api/[controller]")]
    public class PelotonUserProfileController : Controller
    {
        private IPelotonUserService _pelotonUserService;

        public PelotonUserProfileController(IPelotonUserService pelotonUserService)
        {
            _pelotonUserService = pelotonUserService;
        }

        // POST api/values
        [HttpPost]
        public async Task<PelotonUser> Post([FromBody] PelotonUserCredentials credentials)
        {
            var user = await _pelotonUserService.GetPelotonUser(credentials);

            return user;
        }
    }
}
