using ApiProduct.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ApiProduct.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get() 
        {
            return new List<Product>();
        }
    }
}
