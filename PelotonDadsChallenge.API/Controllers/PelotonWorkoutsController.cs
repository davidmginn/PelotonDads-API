using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PelotonDadsChallenge.API.Models;
using PelotonDadsChallenge.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PelotonDadsChallenge.API.Controllers
{

    [Route("api/[controller]")]
    public class PelotonWorkoutsController : Controller
    {
        private IPelotonWorkoutsService _pelotonWorkoutsService;

        public PelotonWorkoutsController(IPelotonWorkoutsService pelotonWorkoutsService)
        {
            _pelotonWorkoutsService = pelotonWorkoutsService;
        }

        // POST api/values
        [HttpPost]
        public async Task<PelotonWorkoutResponse> Post([FromBody] PelotonUserCredentials credentials)
        {
            var workouts = await _pelotonWorkoutsService.GetPelotonWorkoutsAsync(credentials);

            return workouts;
        }
    }
}
