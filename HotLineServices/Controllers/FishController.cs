using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotLineServices.Data;
using HotLineServices.Models;
using Microsoft.EntityFrameworkCore;

namespace HotLineServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    {
        private FishDbContext _context;

        public FishController(FishDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Fish>> Get()
        {
            return await _context.Fishes.ToListAsync();
        }

        [HttpGet("Id")]
        [ProducesResponseType(typeof(Fish), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(int Id)
        {
            var fish = await _context.Fishes.FindAsync(Id);
            return fish == null ? NotFound() : Ok(fish);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Fish fish)
        {
            await _context.Fishes.AddAsync(fish);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { Id = fish.Id }, fish);
        }
    }
}
