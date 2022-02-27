# PddOpenSdk 核心类库使用

支持 `NET6.0` ，安装 Nuget 包 `MSDev.PddOpenSdk`。

## 使用示例:
最新[示例代码](https://github.com/niltor/open-pdd-net-sdk/tree/v6/PddOpenSdk/ConsoleSample)。
```csharp
var service = new PddService(new PddOptions
{
    ClientId = "",
    ClientSecret = "",
    CallbackUrl = ""
});
// 获取token
await service.GetAccessTokenAsync(code: "");
// 接口请求
var result = await service.DdkApi.GetDdkGoodsRecommendAsync(
    new GetDdkGoodsRecommendRequestModel
    {
        CatId = 20100
    });
```