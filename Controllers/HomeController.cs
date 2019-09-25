using ClassProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace ClassProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Mainpage");
        }
        public ViewResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Register(UserResponse user)
        {
            return View();
        }
        public ViewResult Register()
        {
            return View();
        }
        public ViewResult Rescue()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Account()
        {
            return View();
        }

        public ViewResult Result()
        {
            return View();
        }
        public ViewResult Example()
        {
            return View();
        }

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
