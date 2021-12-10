# PddOpenSdk 核心类库使用

支持 `NET6.0` ，安装 Nuget 包 `MSDev.PddOpenSdk`。

## 使用示例:
### 使用clientId等创建服务并获取token
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