using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PelotonDadsChallenge.API.Configuration;
using PelotonDadsChallenge.API.Models;
using PelotonDadsChallenge.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PelotonDadsChallenge.API.Controllers
{
    [Route("api/[controller]")]
    public class AppUserChallengeResultsController : Controller
    {
        private IAppUserChallengeResultsService _appUserChallengeResultsService;
        private PelotonConfiguration _pelotonConfiguration;

        public AppUserChallengeResultsController(IAppUserChallengeResultsService appUserChallengeResultsService,
            IOptions<PelotonConfiguration> pelotonConfiguration)
        {
            _appUserChallengeResultsService = appUserChallengeResultsService;
            _pelotonConfiguration = pelotonConfiguration.Value;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task PostAsync([FromBody] AppUserChallengeResult value)
        {
            try
            {
                value.RowKey = Guid.NewGuid().ToString();
                value.PartitionKey = _pelotonConfiguration.ChallengeClassId;
                value.ChallengeRideId = _pelotonConfiguration.ChallengeClassId;

                await _appUserChallengeResultsService.CreateAppUserChallengeResult(value);
            }
            catch(Exception ex)
            {

            }

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
