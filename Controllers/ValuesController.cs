using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       // [Route("[action]")]
        [HttpGet]
        public string GetName()
        {
            return "Test";
        }

        //[Route("GetFullName")]
        [HttpGet]
        public string GetFullName()
        {
            return "Md Rasel";
        }
    }
}
