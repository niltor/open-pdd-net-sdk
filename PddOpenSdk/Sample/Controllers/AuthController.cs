using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreMvc;
using Newtonsoft.Json;
using PddOpenSdk.Models.PddApiRequest;
using PddOpenSdk.Services.PddApi;
using Sample.Models;

namespace Sample.Controllers
{
    public class AuthController : Controller
    {

        readonly PddService _pdd;

        public AuthController(PddService pdd)
        {
            _pdd = pdd;
        }
        public IActionResult Index()
        {
            string url = _pdd.AuthApi.GetDDKOAuthUrl();
            ViewData["url"] = url;
            return View();
        }

        public async Task<IActionResult> Callback(string code)
        {

            var token = await _pdd.AuthApi.GetAccessTokenAsync(code);
            System.Console.WriteLine(token);
            return Content(token.AccessToken);
        }

        public ActionResult Test()
        {
            _pdd.Test();
            return Content("");
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

    public class User
    {
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
    public class Blog
    {
        public string Title { get; set; }
    }
}
