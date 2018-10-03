using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sonarproj.Controllers.Api
{
    [Route("api/Home")]
    public class HomeController
    {
        [HttpGet()]
        public int Search()
        {
            int c = 1 + 1;
            return c;
        }
    }
}
