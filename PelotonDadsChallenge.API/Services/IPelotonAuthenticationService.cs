using System;
using System.Threading.Tasks;
using Flurl.Http;
using PelotonDadsChallenge.API.Models;

namespace PelotonDadsChallenge.API.Services
{
    public interface IPelotonAuthenticationService
    {
        Task<PelotonAuthResponse> Authenticate(CookieSession session, PelotonUserCredentials credentials);
    }
}
