using GuidGenerator.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuidGenerator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GeneratorController : ControllerBase
    {
        private readonly IGeneratorService generatorService;

        public GeneratorController(IGeneratorService generatorService)
        {
            this.generatorService = generatorService;
        }

        [HttpGet("email")]
        [ProducesResponseType(typeof(string[]), 200)]
        [ProducesResponseType(400)]
        public List<string> GetEmails([FromQuery][Range(1, 1000)] int amount = 1)
        {
            return generatorService.GenerateEmails(amount);
        }

        [HttpGet("guid")]
        [ProducesResponseType(typeof(string[]), 200)]
        [ProducesResponseType(400)]
        public List<Guid> GetGuids([FromQuery][Range(1, 1000)] int amount = 1)
        {
            return generatorService.GenerateGuids(amount);
        }

        [HttpGet("latlong")]
        [ProducesResponseType(typeof(string[]), 200)]
        [ProducesResponseType(400)]
        public List<string> GetLatitudeLongitude([FromQuery][Range(1, 1000)] int amount = 1)
        {
            return generatorService.GenerateLatitudeLongitude(amount);
        }

        [HttpGet("name")]
        [ProducesResponseType(typeof(string[]), 200)]
        [ProducesResponseType(400)]
        public List<string> GetNames([FromQuery][Range(1, 1000)] int amount = 1)
        {
            return generatorService.GenerateNames(amount);
        }
    }
}
