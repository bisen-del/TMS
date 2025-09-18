using Microsoft.AspNetCore.Mvc;

namespace TMS.Controllers
{
    public class Login : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
