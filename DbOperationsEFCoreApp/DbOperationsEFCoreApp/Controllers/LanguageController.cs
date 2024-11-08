using DbOperationsEFCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsEFCoreApp.Controllers
{
    [Route("api/Language")]
    [ApiController]

    public class LanguageController : Controller 
    {
        private readonly AppDbContext _appDbContext;

        public LanguageController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task <IActionResult> GetAll()
        {
            var result = await _appDbContext.Languages.ToListAsync();
            return Ok(result);
        }
    }
}
