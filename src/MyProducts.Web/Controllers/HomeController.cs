using Microsoft.AspNetCore.Mvc;

namespace MyProducts.Web.Controllers
{
    public class HomeController : MyProductsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}