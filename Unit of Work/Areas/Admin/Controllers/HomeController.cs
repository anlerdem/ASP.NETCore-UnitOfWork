using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Unit_of_Work.Areas.Controllers
{

    [Area("Admin")]
    public class HomeController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
