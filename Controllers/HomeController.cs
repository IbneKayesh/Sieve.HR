using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sieve.HR.Models;
using System.Diagnostics;

namespace Sieve.HR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult TopBar()
        {
            List<TOP_BAR_ICONS> objList = new List<TOP_BAR_ICONS>();
            objList.Add(new TOP_BAR_ICONS { NAME = "Home", ICON = "fa fa-th", LINK = "/Home/Index" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Products", ICON = "fa fa-barcode", LINK = "/products" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Sales", ICON = "fa fa-shopping-cart", LINK = "/Sales" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Opened Bills", ICON = "fa fa-bell", LINK = "/Open_Bills" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Categories", ICON = "fa fa-folder-open", LINK = "/Categories" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Gift Card", ICON = "fa fa-credit-card", LINK = "/Gift_Card" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Customers", ICON = "fa fa-users", LINK = "/Customers" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Settings", ICON = "fa fa-cogs", LINK = "/Settings" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Reports", ICON = "fa fa-bar-chart", LINK = "/Reports" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Users", ICON = "fa fa-users", LINK = "/Users" });
            objList.Add(new TOP_BAR_ICONS { NAME = "Backups", ICON = "fa fa-database", LINK = "/Backups" });
            //var str = HttpContext.Session.GetString("topBar");
            //if (!string.IsNullOrWhiteSpace(str))
            //{
            //    objList = JsonConvert.DeserializeObject<List<TOP_BAR_ICONS>>(str);
            //}
            return PartialView("_topBar", objList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}