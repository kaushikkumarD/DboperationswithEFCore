using DbOperationsEFCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> 7eb291bf87849e4569c3cc94cfa745120882d663

namespace DbOperationsEFCoreApp.Controllers
{
    [Route("api/Currency")]
<<<<<<< HEAD
    [ApiController] 
=======
    [ApiController]
>>>>>>> 7eb291bf87849e4569c3cc94cfa745120882d663

    public class CurrencyController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
<<<<<<< HEAD

        [HttpGet] 
        public async Task< IActionResult> GetAll()
        {
            var result = await _appDbContext.Currencies.ToListAsync();
=======
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _appDbContext.Currencies.ToList();
>>>>>>> 7eb291bf87849e4569c3cc94cfa745120882d663
            return Ok(result);
        }
    }
}
