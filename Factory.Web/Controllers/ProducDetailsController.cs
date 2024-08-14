using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace Factory.Web.Controllers
{
    public class ProducDetailsController : Controller
    {
        LocalEarnFactory _localEarnFactory;
        ForeignEarnFactory _foreignEarnFactory;

        public ProducDetailsController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {

            // Product (object that generates the fabric)
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();    

            // total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);
    

            return View();
        }
    }
}
