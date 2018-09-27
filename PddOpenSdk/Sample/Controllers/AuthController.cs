using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PddOpenSdk.AspNetCore;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
using PddOpenSdk.Models.Request.Ddk;
using PddOpenSdk.Services;
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

        /// <summary>
        /// 测试获取token
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public async Task<IActionResult> Callback(string code)
        {
            var token = await _pdd.AuthApi.GetAccessTokenAsync(code);

            return Content(token.AccessToken);
        }

        public async Task<ActionResult> Test()
        {
            PddCommonApi.AccessToken = "b4d18c1d5f6445288ecd0439a58af010113a600d";
            var model = new SearchDdkGoodsRequestModel
            {
               SortType =0,
               WithCoupon = false
            };
            var result = await _pdd.DdkApi.SearchDdkGoodsAsync(model);
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
}
