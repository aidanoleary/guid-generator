using GuidGenerator.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuidGenerator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuidGeneratorController : ControllerBase
    {
        private IGuidGeneratorService guidGeneratorService;

        public GuidGeneratorController(IGuidGeneratorService guidGeneratorService)
        {
            this.guidGeneratorService = guidGeneratorService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(string[]), 200)]
        [ProducesResponseType(400)]
        public List<Guid> Get([FromQuery][Range(1,1000)] int numberOfGuids = 1)
        {
            return guidGeneratorService.GenerateGuids(numberOfGuids);
        }
    }
}
