using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumWordAPI.Models;
using ConvertService.Classes;

namespace NumWordAPI.Controllers
{
    [Route("api/[controller]")]
    public class NumWordController : Controller
    {
        //  GET api/NumWords/5
        [HttpGet("{num}")]
        public ActionResult<string> GetAll(int num){

            Conversion conv = new Conversion(new FileLogger("log.txt"));
            return conv.NumberToWords(num);  
        }
            

    }
}