using Microsoft.AspNetCore.Mvc;

namespace Trading_App.Controllers
{
    public class TradeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
