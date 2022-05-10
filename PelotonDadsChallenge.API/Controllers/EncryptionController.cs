using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCore.Encrypt;
using PelotonDadsChallenge.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PelotonDadsChallenge.API.Controllers
{
    [Route("api/[controller]")]
    public class EncryptionController : Controller
    {
        // GET: api/values
        [HttpGet]
        public EncryptionCredentials Get()
        {
            var aesKey = EncryptProvider.CreateAesKey();

            return new EncryptionCredentials()
            {
                Key = aesKey.Key,
                IV = aesKey.IV
            };
        }
    }
}
