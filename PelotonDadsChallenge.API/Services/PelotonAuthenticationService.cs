using System;
using System.Threading.Tasks;
using Flurl.Http;
using Microsoft.Extensions.Options;
using PelotonDadsChallenge.API.Configuration;
using PelotonDadsChallenge.API.Models;

namespace PelotonDadsChallenge.API.Services
{
    public class PelotonAuthenticationService : IPelotonAuthenticationService
    {
        private PelotonConfiguration _pelotonConfiguration;

        public PelotonAuthenticationService(IOptions<PelotonConfiguration> pelotonConfiguration)
        {
            _pelotonConfiguration = pelotonConfiguration.Value;
        }

        public async Task<PelotonAuthResponse> Authenticate(CookieSession session, PelotonUserCredentials credentials)
        {
            var uri = $"{_pelotonConfiguration.BaseUri}/auth/login";

            var result = await session.Request(uri)
                .WithHeader("User-Agent", "PostmanRuntime/7.26.10")
                .PostJsonAsync(new
            {
                username_or_email = credentials.Username,
                password = credentials.Password
            }).ReceiveJson<PelotonAuthResponse>();

            return result;
        }
    }
}
