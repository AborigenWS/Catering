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
        public IActionResult Test([FromBody]A account)
        {
            Console.Clear();
            Console.WriteLine("это мыло");
            Console.WriteLine(account.Email + " " + account.Password);
            Console.WriteLine("это конец мыла");
            return Ok();
        }
        
    }
    public class A
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
