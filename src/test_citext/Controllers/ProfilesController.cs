using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_citext.Data;

namespace test_citext.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfilesController: Controller
    {
        private readonly CiDbContext _context;

        public ProfilesController(CiDbContext context)
        {
            _context = context;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetAdmins(string name)
        {
            var admins = await _context.Profiles.Where(p => p.UserName.Equals(name)).ToListAsync();
            return Json(admins);
        }
    }
}
