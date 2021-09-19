using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.API.Context;
using Shop.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {

        private readonly ApiContext _context;

        public PagesController(ApiContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Page>>> Get()
        {
            return await _context.Pages.OrderBy(x => x.Id).ToListAsync();
        }

    }
}
