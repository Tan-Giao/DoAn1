using DoAn1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAn1.Controllers
{
    public class CategorieController : Controller
    {
        public readonly QlbhdtContext qlbhdtContext;
        public CategorieController(QlbhdtContext qlbhdt)
        {
            qlbhdtContext = qlbhdt; 
        }
        public async Task<IActionResult> IndexAsync()
        {
            var catogorie = qlbhdtContext.Categories.AsQueryable();
            return View(await catogorie.ToListAsync());
        }
    }
}
