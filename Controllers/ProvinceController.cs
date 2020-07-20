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
    public class ProvinceController : ControllerBase
    {
        private readonly SheshaContext _context;

        public ProvinceController(SheshaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Province>> GetAllProvince()
        {
            return _context.Province;
        }

        [HttpGet("Name")]
        public ActionResult<Province> GetProvinceByName(string name)
        {
            IEnumerable<Province> allProvince = _context.Province;
            return (from p in allProvince
                    where p.Name == name
                        select p).FirstOrDefault();
        }
    }
}