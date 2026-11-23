using Microsoft.AspNetCore.Mvc;

namespace GymManagmentSystemG01.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            int Data = 10;
            return View(Data);
        }


        public IActionResult mahmoud(int id)
        {
            int Data = 10;
            return View(id);
        }
    }
}
  