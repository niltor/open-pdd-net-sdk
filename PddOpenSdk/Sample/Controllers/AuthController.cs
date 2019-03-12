using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PddOpenSdk.AspNetCore;
using PddOpenSdk.Models.Request.Ddk;
using PddOpenSdk.Models.Request.Goods;
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
            PddCommonApi.AccessToken = "bf4e43499f864333bfed2272e702575446daad5d";
            //var model1 = new GetGoodsCatsRequestModel
            //{
            //    ParentCatId = 0
            //};
            //var result1 = await _pdd.GoodsApi.GetGoodsCatsAsync(model1);

            var model = new AddGoodsRequestModel
            {
                GoodsName = "葡萄",
                GoodsType = 1,
                GoodsDesc = "葡萄串",
                CatId = 1,
                CountryId = 1,
                MarketPrice = 12,
                IsPreSale = false,
                ShipmentLimitSecond = 3600 * 24,
                CostTemplateId = 1000000,
                IsRefundable = true,
                SecondHand = false,
                IsFolt = true,
                SkuList = new System.Collections.Generic.List<AddGoodsRequestModel.SkuListRequestModel>
                {
                    new AddGoodsRequestModel.SkuListRequestModel
                    {
                       ThumbUrl = "https://t00img.yangkeduo.com/goods/images/2019-03-09/dacebcdc-9c26-479c-9174-f3ecf0b579b6.jpg",
                       OverseaSku = new AddGoodsRequestModel.SkuListRequestModel.OverseaSkuRequestModel
                       {
                           MeasurementCode = "123",
                           Taxation = 0,
                           Specifications = "spe"
                       },
                       SpecIdList = "[1754889520]",
                       Weight = 200,
                       Quantity = 10,
                       MultiPrice = 12,
                       Price = 15,
                       LimitQuantity = 10,
                       IsOnsale = 1
                    }
                },
                CarouselGallery = new System.Collections.Generic.List<string>
                {
                    "https://t00img.yangkeduo.com/goods/images/2019-03-09/dacebcdc-9c26-479c-9174-f3ecf0b579b6.jpg",
                    "https://t00img.yangkeduo.com/goods/images/2019-03-09/0a1ee8e4-e94e-4d5c-89ab-fe4a4e163ee9.jpg"
                },
                DetailGallery = new System.Collections.Generic.List<string>
                {
                    "https://t00img.yangkeduo.com/goods/images/2019-03-09/0a1ee8e4-e94e-4d5c-89ab-fe4a4e163ee9.jpg"
                }
            };
            var result = await _pdd.GoodsApi.AddGoodsAsync(model);



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
