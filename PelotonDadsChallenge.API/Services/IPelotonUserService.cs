using System;
using System.Threading.Tasks;
using PelotonDadsChallenge.API.Models;

namespace PelotonDadsChallenge.API.Services
{
    public interface IPelotonUserService
    {
        Task<PelotonUser> GetPelotonUser(PelotonUserCredentials credentials);
    }
}
