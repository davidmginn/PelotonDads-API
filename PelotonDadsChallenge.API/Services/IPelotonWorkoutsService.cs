using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PelotonDadsChallenge.API.Models;

namespace PelotonDadsChallenge.API.Services
{
    public interface IPelotonWorkoutsService
    {
       Task<PelotonWorkoutResponse> GetPelotonWorkoutsAsync(PelotonUserCredentials pelotonUserCredentials);
    }
}
