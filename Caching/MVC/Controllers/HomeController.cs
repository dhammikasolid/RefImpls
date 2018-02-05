using System.Web.Mvc;
using System.Runtime.Caching;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        MemoryCache cache;

        public HomeController()
        {
            cache = MemoryCache.Default;
        }

        public ActionResult Index()
        {
            cache.Remove("a");
            cache.Remove("b");

            return View();
        }

        public ActionResult About()
        {
            cache["a"] = "A";
            return View();
        }

        public ActionResult Contact()
        {
            cache["b"] = "B";
            return View();
        }

        public string CachedValueA()
        {
            return cache["a"] as string;
        }

        public string CachedValueB()
        {
            return cache["b"] as string;
        }
    }
}