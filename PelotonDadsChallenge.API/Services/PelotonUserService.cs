using System;
using System.Threading.Tasks;
using Flurl.Http;
using Microsoft.Extensions.Options;
using PelotonDadsChallenge.API.Configuration;
using PelotonDadsChallenge.API.Models;

namespace PelotonDadsChallenge.API.Services
{
    public class PelotonUserService : IPelotonUserService
    {
        private IPelotonAuthenticationService _pelotonAuthenticationService;
        private PelotonConfiguration _pelotonConfiguration;

        public PelotonUserService(IPelotonAuthenticationService pelotonAuthenticationService, IOptions<PelotonConfiguration> pelotonConfiguration)
        {
            _pelotonAuthenticationService = pelotonAuthenticationService;
            _pelotonConfiguration = pelotonConfiguration.Value;
        }

        public async Task<PelotonUser> GetPelotonUser(PelotonUserCredentials credentials)
        {
            using (var session = new CookieSession(_pelotonConfiguration.BaseUri))
            {
                var authResponse = await _pelotonAuthenticationService.Authenticate(session, credentials);

                var user = await $"{_pelotonConfiguration.BaseUri}/api/user/{authResponse.UserId}"
                    .WithHeader("User-Agent", "PostmanRuntime/7.26.10")
                    .GetJsonAsync<PelotonUser>();

                return user;
            }
        }
    }
}
