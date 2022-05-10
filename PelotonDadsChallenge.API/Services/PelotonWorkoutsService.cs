using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Microsoft.Extensions.Options;
using PelotonDadsChallenge.API.Configuration;
using PelotonDadsChallenge.API.Models;

namespace PelotonDadsChallenge.API.Services
{
    public class PelotonWorkoutsService : IPelotonWorkoutsService
    {
        private IPelotonAuthenticationService _pelotonAuthenticationService;
        private PelotonConfiguration _pelotonConfiguration;

        public PelotonWorkoutsService(IPelotonAuthenticationService pelotonAuthenticationService, IOptions<PelotonConfiguration> pelotonConfiguration)
        {
            _pelotonAuthenticationService = pelotonAuthenticationService;
            _pelotonConfiguration = pelotonConfiguration.Value;
        }

        public async Task<PelotonWorkoutResponse> GetPelotonWorkoutsAsync(PelotonUserCredentials pelotonUserCredentials)
        {
            using (var session = new CookieSession(_pelotonConfiguration.BaseUri))
            {
                var authResponse = await _pelotonAuthenticationService.Authenticate(session, pelotonUserCredentials);
                
                var url = $"{_pelotonConfiguration.BaseUri}/api/user/{authResponse.UserId}/workouts?joins=ride,ride.instructor&limit=10&page=0";

                var workoutResponse = await url
                    .WithHeader("User-Agent", "PostmanRuntime/7.26.10")
                    .WithCookies(session.Cookies)
                    .GetJsonAsync<PelotonWorkoutResponse>();

                return workoutResponse;
            }
        }
    }
}
