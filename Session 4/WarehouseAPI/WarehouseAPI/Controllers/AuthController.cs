using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseAPI.Models;

namespace WarehouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Employees loginUser)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(u => u.Login == loginUser.Login && u.Password == loginUser.Password);
            if (employee != null)
            {
                return Ok("Login successful!");
            }
            return Unauthorized("Invalid login or password.");
        }


        [HttpPost("loginByEmail")]
        public async Task<IActionResult> LoginByEmail([FromBody] Employees loginUser)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(u => u.Email == loginUser.Email && u.Password == loginUser.Password);
            if (employee != null)
            {
                return Ok("Email successful!");
            }
            return Unauthorized("Invalid email or password.");
        }
    }
}
