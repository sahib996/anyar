using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32.SafeHandles;

namespace Anyar_1_.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
    }
}
