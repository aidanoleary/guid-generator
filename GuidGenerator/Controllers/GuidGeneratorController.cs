using GuidGenerator.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public List<Guid> Get([FromQuery] int numberOfGuids = 1)
        {
            return guidGeneratorService.GenerateGuids(numberOfGuids);
        }
    }
}
