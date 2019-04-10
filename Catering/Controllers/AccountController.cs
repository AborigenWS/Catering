using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Catering.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        [Route("[action]")]
        [HttpPost]
        public void Test([FromBody]string email)
        {
            string test = email;
        }
    }
}
