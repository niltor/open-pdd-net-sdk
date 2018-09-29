using Microsoft.VisualStudio.TestTools.UnitTesting;
using PddOpenSdk.Models.Request.Ddk;
using PddOpenSdk.Models.Response.Ddk;
using PddOpenSdk.Services;
using PddOpenSdk.Services.PddApi;

namespace ApiTest
{
    [TestClass]
    public class UnitTest1
    {
        //public UnitTest1()
        //{
        //    PddCommonApi.ClientId = clientId;
        //    PddCommonApi.ClientSecret = clientSecret;
        //    PddCommonApi.RedirectUri = RedirectUri;
        //}

        [TestMethod]
        public void TestMethod()
        {
            PddCommonApi.ClientId = "clientId";
            PddCommonApi.ClientSecret = "ClientSecret";
            PddCommonApi.RedirectUri = "RedirectUri";
            var api = new DdkApi();

            var result = api.SearchDdkGoodsAsync(new SearchDdkGoodsRequestModel
            {
                WithCoupon = false,
                SortType = 0
            }).Result;

            Assert.IsInstanceOfType(result, typeof(SearchDdkGoodsResponseModel));
            Assert.IsNotNull(true);
        }
    }
}
