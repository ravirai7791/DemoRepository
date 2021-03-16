using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumberGeneratorProcessor;

namespace GenerateSeries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateNumberController : ControllerBase
    {
        // GET: api/GenerateNumber/5
        [HttpGet("{terminateAt?}", Name = "GetGenerated")]
        //[Route("GetGenerated/{terminateAt}")]
        public List<int> Get(int terminateAt = 15)
        {
            return new Processor().GenerateNumber(terminateAt);
        }

        // GET: api/GenerateNumber/5/3
        [HttpGet("{devisior}/{number}", Name = "GetDevidedValue")]
        public string GetValues(int devisior, int number)
        {
            return new Processor().GetValues(devisior,number);
        }
    }
}
