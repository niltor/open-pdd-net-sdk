### 使用说明

先安装Nuget 包 `MSDev.PddOpenSdk.AspNetCore`。

最新[示例代码](https://github.com/niltor/open-pdd-net-sdk/tree/dev/PddOpenSdk/Sample)。

- 在 Startup.cs 中注入服务

```csharp
services.AddPdd(options =>
{
    // 使用appsettings 配置你的ClientId等参数
    options.ClientId = Configuration.GetSection("Pdd")["ClientId"];
    options.CallbackUrl = Configuration.GetSection("Pdd")["RedirectUri"];
    options.ClientSecret = Configuration.GetSection("Pdd")["ClientSecret"];
});
```

- 然后在控制器使用注入服务

```csharp
readonly PddService _pdd;
public YourController(PddService pdd)
{
    _pdd = pdd;
}
```

#### 2.2.0及以后版本
```csharp
/// <summary>
/// 测试获取token
/// </summary>
/// <param name="code"></param>
/// <returns></returns>
public async Task<IActionResult> Callback(string code)
{
    var token = await _pdd.GetAccessTokenAsync(code);
    return Content(token.AccessToken);
}

/// <summary>
/// 多租户测试
/// </summary>
/// <returns></returns>
public async Task<ActionResult> MultiTenantAsync()
{
    var service = new PddService(new PddOptions
    {
        ClientId = "",
        ClientSecret = "",
        CallbackUrl = "",
        // 也可直接将token
        // AccessToken=""

    });
    // 如果没有token，可通过该方法获取token
    await service.GetAccessTokenAsync(code: "");
    var result = await service.DdkApi.GetDdkGoodsRecommendAsync(
        new GetDdkGoodsRecommendRequestModel
        {
            CatId = 20100
        });
    return Json(result);
}
```
##### 使用socket消息订阅服务
- 在`StartUp.cs`添加`PddOption`选项。
    ```csharp

    ```
- 创建一个`XXXHostService`类，继承`PddSocketHostServiceBase`。
- 重写`OnMessage`方法，以进行消息的自定义处理。
- 在`Program.cs`中添加后台服务。
    ```csharp
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).ConfigureServices(services =>
                {
                    services.AddHostedService<XXXHostService>();
                });
    ```


可参考`Sample`项目。


#### 2.1.0及以前版本

- 获取 AccessToken
```csharp
/// <summary>
/// 测试获取token
/// </summary>
/// <param name="code"></param>
/// <returns></returns>
public async Task<IActionResult> Callback(string code)
{
    var token = await _pdd.AuthApi.GetAccessTokenAsync(code);
    // 自行维护Token过期时间
    return Content(token.AccessToken);
}
```

- 调用其他接口

  **获取 AccessToken 之后才能正常调用其他接口。**

```csharp
public async Task<ActionResult> Test()
{
    // 构造请求模型
    var requestModel = new SearchDdkGoodsRequestModel
    {
        SortType = 0,
        WithCoupon = false
    };
    // 调用相应接口方法
    var result = await _pdd.DdkApi.SearchDdkGoodsAsync(requestModel);
    return Content(JsonConvert.SerializeObject(result));
}
```

> 所有方法名与官方文档保持一致，并有中文注释提醒，只是更改了命名规范，非常容易查找使用。
