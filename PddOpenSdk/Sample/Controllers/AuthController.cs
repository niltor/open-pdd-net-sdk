using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PddOpenSdk.Services;
using Sample.Models;

namespace Sample.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            var pddRequest = new PddRequest();

            ViewData["url"] = pddRequest.GetDDKOAuthUrl("https://pdd.guandian.tech/pdd/callback");
            return View();
        }

        public async Task<IActionResult> Callback(string code)
        {

            var pddRequest = new PddRequest();
            var token = await pddRequest.GetAccessTokenAsync(code, "https://pdd.guandian.tech/pdd/callback");
            System.Console.WriteLine(token);
            return Content(token);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
