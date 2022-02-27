// See https://aka.ms/new-console-template for more information

using MSDev.PddOpenSdk;
using PddOpenSdk.Models.Request.Ddk;
using System.Text.Json;

// 替代下面配置信息
var client = new PddClient(new ClientConfig
{
    ClientId = "YourClientId",
    ClientSecret = "YourClientSecret",
    CallbackUrl = "YourCallbackUrl"
});

// 需要先拿到授权返回的code
var code = "";
// 使用code换取token
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
