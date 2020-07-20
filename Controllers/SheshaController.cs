using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SheshaAPI.Models;

namespace SheshaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SheshaController : ControllerBase
    {
        private readonly SheshaContext _context;

        public SheshaController(SheshaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<City>> GetCityItems()
        {
            return _context.City;
        }
    }
}
