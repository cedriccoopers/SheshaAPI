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
    public class UserController : ControllerBase
    {
        private readonly SheshaContext _context;

        public UserController(SheshaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetAllUsers()
        {
            return _context.Users;
        }

        [HttpGet("Name")]
        public ActionResult<Users> GetUserByName(string name)
        {
            IEnumerable<Users> allUsers = _context.Users;
            return (from p in allUsers
                    where p.UserFirstName == name
                        select p).FirstOrDefault();
        }
    }
}
