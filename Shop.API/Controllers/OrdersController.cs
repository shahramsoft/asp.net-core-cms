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
    public class OrdersController : ControllerBase
    {

        private readonly ApiContext _context;

        public OrdersController(ApiContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Order>>> Get()
        {
            return await _context.Order.OrderBy(x => x.Id).ToListAsync();
        }

    }
}
