using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotLineServices.Data;
using HotLineServices.Models;
using Microsoft.EntityFrameworkCore;

namespace HotLineServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatchController : ControllerBase
    {
        private CatchDbContext _context;

        public CatchController(CatchDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Catch>> Get()
        {
            return await _context.Catches.ToListAsync();
        }
    }
}
