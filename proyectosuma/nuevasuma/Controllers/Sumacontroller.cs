using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nuevasuma.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Sumacontroller : Controller
    {
        [HttpGet]
        public int suma(int num1, int num2)
        {
            return num1 + num2; 
        }
    }
}
