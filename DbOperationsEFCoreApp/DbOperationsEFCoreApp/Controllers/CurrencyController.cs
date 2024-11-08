using DbOperationsEFCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsEFCoreApp.Controllers
{
    [Route("api/Currency")]
    [ApiController] 

    public class CurrencyController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task< IActionResult> GetAll()
        {
            var result = await _appDbContext.Currencies.ToListAsync();
            return Ok(result);
        }
    }
}
