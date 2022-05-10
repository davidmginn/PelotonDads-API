using System;
using System.Threading.Tasks;
using PelotonDadsChallenge.API.Models;

namespace PelotonDadsChallenge.API.Services
{
    public interface IAppUserChallengeResultsService
    {
        Task CreateAppUserChallengeResult(AppUserChallengeResult result);
    }
}
