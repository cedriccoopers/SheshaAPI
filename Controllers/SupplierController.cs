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
    public class SupplierController : ControllerBase
    {
        private readonly SheshaContext _context;

        public SupplierController(SheshaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Suppliers>> GetSuppliersItems()
        {
            return _context.Suppliers;
        }

        [HttpGet("Name")]
        public ActionResult<Suppliers> GetSupplierByName(string name)
        {
            IEnumerable<Suppliers> allSuppliers = _context.Suppliers;
            return (from p in allSuppliers
                    where p.SupplierName == name
                    select p).FirstOrDefault();
        }
    }
}