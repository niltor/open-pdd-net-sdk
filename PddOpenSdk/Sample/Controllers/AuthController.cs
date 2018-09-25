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
            _pdd.Test();
            return View();
        }

        public async Task<IActionResult> Callback(string code)
        {

            //var pddRequest = new AuthApi();
            //var token = await pddRequest.GetAccessTokenAsync(code, "https://pdd.guandian.tech/pdd/callback");
            //System.Console.WriteLine(token);
            return Content("");
        }

        public async Task<IActionResult> Test()
        {
            var ddk = new DdkApi();
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
