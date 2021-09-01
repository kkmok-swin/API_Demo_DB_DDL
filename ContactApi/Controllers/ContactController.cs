using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContactApi.Controllers
{
    [ApiController]  //create end points
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        public static List<Contact> contactList = new List<Contact>();

        [HttpGet]
        public List<Contact> Get()
        {
           
        }
    }
}
