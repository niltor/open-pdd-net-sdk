// See https://aka.ms/new-console-template for more information

using MSDev.PddOpenSdk;
using PddOpenSdk.Models.Request.Ddk;
using System.Text.Json;

var client = new PddClient(new ClientConfig
{
    ClientId = "YourClientId",
    ClientSecret = "YourClientSecret",
    CallbackUrl = "YourCallbackUrl"
});

// 网页授权获取code 
var code = "df55b7b7a62545fc8bc639e4fce595e607437327";
// 获取token
var token = await client.GetAccessTokenAsync(code);

if (token == null)
{
    Console.WriteLine(client.ErrorResponse.ErrorMsg);
}
else
{
    Console.WriteLine("token:"+ token.AccessToken); 
}
// 接口请求
var result = await client.DdkApi.GetDdkGoodsRecommendAsync(
    new GetDdkGoodsRecommend
    {
        CatId = 20100
    });

var response = result.GoodsBasicDetailResponse;
Console.WriteLine(JsonSerializer.Serialize(response));
