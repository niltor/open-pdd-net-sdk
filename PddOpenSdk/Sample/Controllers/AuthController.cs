using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PddOpenSdk.Common;
using PddOpenSdk.Models.PddApiRequest;
using PddOpenSdk.Services;
using PddOpenSdk.Services.PddApiRequest;
using Sample.Models;

namespace Sample.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            var pddRequest = new PddRequest();

            var user = new User
            {
                Name = "niltor",
                Blogs = new List<Blog>
                {
                    new Blog{Title = "博文1" },
                    new Blog{Title = "22"}
                }
            };

            var dic = Function.ToDictionary(user);


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

        public async Task<IActionResult> Test()
        {
            var ddk = new DdkApiRequest();
            var result = await ddk.SearchDdkGoodsAsync(new SearchDdkGoodsRequestModel
            {
                SortType = 0,
                WithCoupon = false
            });

            System.Console.WriteLine(JsonConvert.SerializeObject(result));
            return Content(JsonConvert.SerializeObject(result));
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
