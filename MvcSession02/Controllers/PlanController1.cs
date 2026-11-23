using GymManagmentSystemG01.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystemG01.Controllers
{
    public class PlanController1 : Controller
    {
        private GymDbContext dbContext = new GymDbContext();
        public async Task<IActionResult> Index()
        {
            var Plans = await dbContext.Plans.ToListAsync();
            return View(Plans);
        }
    }
} 
