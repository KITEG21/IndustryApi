using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndustryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IndustryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Company> GetCompany(int CompanyID)
        {
            
            

            return Ok();
        }
        

    }
}