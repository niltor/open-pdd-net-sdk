### 使用说明

先安装Nuget 包 `MSDev.PddOpenSdk.AspNetCore`。

最新[示例代码](https://github.com/niltor/open-pdd-net-sdk/tree/v6/PddOpenSdk/Sample)。

- 在 Startup.cs 中注入服务

```csharp
services.Configure<PddOptions>(Configuration.GetSection("Pdd"));
services.AddPdd();
```
- `appsettings.json `配置项参考:
```json
"Pdd": {
    "ClientId": "",
    "ClientSecret": "",
    "RedirectUri": ""，
    "SocketUrl": "",
    // 心跳间隔
    "HeartBeatSeconds": 5
}
```
- 然后在控制器使用注入服务

```csharp
readonly PddService _pdd;
public YourController(PddService pdd)
{
    _pdd = pdd;
}
```

#### 在控制器中使用
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
#### 使用socket消息订阅服务

- 在`StartUp.cs`添加`PddOption`选项。
    ```csharp
        // 获取选项
        services.Configure<PddOptions>(Configuration.GetSection("Pdd"));
    ```
- 创建一个`XXXHostService`类，继承`PddSocketHostServiceBase`。
- 重写`XXXHostService`的`OnMessage`方法，以进行消息的自定义处理。
- 在`Program.cs`中添加启用服务的代码，如：
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

`XXXHostService` 类可参考[Sample](https://github.com/niltor/open-pdd-net-sdk/tree/v6/PddOpenSdk/Sample/MyHostService.cs)项目。

- 心跳检测间隔可在`appsetting.json`配置中进行配置，可参考`Sample`项目中的配置。
此外可在自定义的`XXXHostService`类中的构造方法中设置`HeartBeartSeconds`值，会覆盖配置中的值。


> 所有方法名与官方文档保持一致，并有中文注释提醒，只是更改了命名规范，非常容易查找使用。
