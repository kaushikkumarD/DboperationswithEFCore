using DbOperationsEFCoreApp.Data;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAll()
        {
            var result = _appDbContext.Currencies.ToList();
            return Ok(result);
        }
    }
}
