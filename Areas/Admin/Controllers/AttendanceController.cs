using Microsoft.AspNetCore.Mvc;

namespace Sieve.HR.Areas.Admin.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
