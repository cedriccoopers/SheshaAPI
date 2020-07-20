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
    public class CityController : ControllerBase
    {
        private readonly SheshaContext _context;

        public CityController(SheshaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<City>> GetCityItems()
        {
            return _context.City;
        }

        [HttpGet("Name")]
        public ActionResult<City> GetCityByName(string name)
        {
            IEnumerable<City> allCities = _context.City;
            return (from p in allCities
                    where p.Name == name
                        select p).FirstOrDefault();
        }
    }
}
