using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class HostNameController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return  $"{Environment.MachineName} / {System.Runtime.InteropServices.RuntimeInformation.OSDescription}";
        }

        

        
    }
}
