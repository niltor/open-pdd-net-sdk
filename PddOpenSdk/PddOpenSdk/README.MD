### PddOpenSdk 核心类库使用

支持 `.Net Framework4.5.2`及`Net Standard 2.0` ，安装 Nuget 包 `MSDev.PddOpenSdk`。

使用示例:

#### 2.2.0及以后版本
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

#### 2.1.0及以前版本：
- 基本请求及错误信息
```csharp
class Program
{
    static async Task Main(string[] args)
    {
        // 设置ClientId与ClientSecret
        PddCommonApi.ClientId = "ID";
        PddCommonApi.ClientSecret = "Secret";
        // 先使用code换取token
        string code = "";
        var authApi = new AuthApi();
        await authApi.GetAccessTokenAsync(code);
    
        // 构造请求内容
        var model = new GenDdkWeappQrcodeUrlRequestModel
        {
            PId = "123133",
            GoodsIdList = new System.Collections.Generic.List<long> { 1122, 331323 }
        };
        var api = new DdkApi();
        var result = await api.GenDdkWeappQrcodeUrlAsync(model);

        // 获取Pdd官方返回的错误信息
        var errorResponse = _pdd.DdkApi.ErrorResponse.Value;
        Console.WriteLine(errorResponse.Error_msg);

    }
}
```

- 图片上传示例
```csharp
    var filePath = Path.Combine("images", "logo.png");
    byte[] bytes = System.IO.File.ReadAllBytes(filePath);

    // 构造图片上传内容
    string base64 = "data:image/png;base64," + Convert.ToBase64String(bytes);
    var model = new UploadGoodsImageRequestModel
    {
        Image = base64
    };
    var result = await _pdd.GoodsApi.UploadGoodsImageAsync(model)
```