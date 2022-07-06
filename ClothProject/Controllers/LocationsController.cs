using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClothProject.Models;

namespace ClothProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly DataContext _context;

        public LocationsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("all/{userId}")]
        public async Task<IActionResult> GetLocations(int userId)
        {
            var locations = await _context.Locations.Where(x => x.UserId == userId).ToListAsync();

            return Ok(locations);
        }

        [HttpPost("create")]
        public async Task<IActionResult> PostLocation(Location model)
        {
            await _context.Locations.AddAsync(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }
    }
}
