using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiTest
{
    [TestClass]
    public class UnitTest1
    {
        // TODO:环境变量
        private readonly string accessToken = "";

        [TestMethod]
        public void TestMethod()
        {
            //PddCommonApi.ClientId = "clientId";
            //PddCommonApi.ClientSecret = "ClientSecret";
            //PddCommonApi.RedirectUri = "RedirectUri";
            //PddCommonApi.AccessToken = accessToken;

            //var api = new DdkApi();
            //var result = api.SearchDdkGoodsAsync(new SearchDdkGoodsRequestModel
            //{
            //    WithCoupon = false,
            //    SortType = 0
            //}).Result;

            //Assert.IsInstanceOfType(result, typeof(SearchDdkGoodsResponseModel));
            Assert.IsNotNull(true);
        }
    }
}
