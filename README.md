# 说明文档
[![publish](https://github.com/niltor/open-pdd-net-sdk/actions/workflows/publish.yml/badge.svg?branch=nuget)](https://github.com/niltor/open-pdd-net-sdk/actions/workflows/publish.yml)

[![NuGet](https://img.shields.io/nuget/v/MSDev.PddOpenSdk.AspNetCore.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/MSDev.PddOpenSdk.AspNetCore/)
[![NuGet](https://img.shields.io/nuget/dt/MSDev.PddOpenSdk.AspNetCore.svg)](https://www.nuget.org/packages/MSDev.PddOpenSdk.AspNetCore/)


open-pdd-net-sdk，拼多多开放平台 DotNet SDK。

## **特别说明**

- `2.2.0 `版本开始，将提供多商户支持，同时将目标框架统一调整到.net5.0.
- `2.3.0` 提供消息服务支持，核心类库不再支持 `.net framework`.
- `6.0 `版本开始，目标框架统一调整到`.NET6`.
- `7.0 `版本，同时支持`.NET6` 和`.NET7`.

## 更新说明
更新文档已经迁移到[`CHANGELOG.md`](https://github.com/niltor/open-pdd-net-sdk/blob/v6/docs/CHANGELOG.md)。

## 类库说明

核心类库 `MSDev.PddOpenSdk` 支持基于 `.NET6.0+` 的项目，**C#10.0**。
控制台、客户端等类型项目可使用。

ASP.NET Core 项目请使用 Nuget 包 `MSDev.PddOpenSdk.AspNetCore`，可直接通过注入服务的方式使用。

## Console项目

该项目是通过官方接口获取并自动生成所有请求模型类、返回模型类以及请求服务类，生成后部分类名会有重名,更改成不同的类名即可。

执行方法，打开Console目录，然后执行`dotnet run`命令即可。

执行成功后，可使用Visual Studio自带的代码清理，对所有文件进行代码格式化操作。

## 使用说明

### PddOpenSdk 核心类库使用

适用于客户端、控制台等程序，Web应用请使用Nuget包 `MSDev.PddOpenSdk.AspNetCore`。

支持 `NET6.0+` ，安装 Nuget 包 `MSDev.PddOpenSdk`。

### 使用示例:
最新[示例代码](https://github.com/niltor/open-pdd-net-sdk/tree/v6/src/ConsoleSample)。
```csharp
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

```


### ASP.NET Core 项目使用

先安装Nuget 包 `MSDev.PddOpenSdk.AspNetCore`。

最新[示例代码](https://github.com/niltor/open-pdd-net-sdk/tree/v6/src/Sample)。

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
    "CallbackUrl": "",
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

`XXXHostService` 类可参考[Sample](https://github.com/niltor/open-pdd-net-sdk/tree/v6/src/Sample/MyHostService.cs)项目。

- 心跳检测间隔可在`appsetting.json`配置中进行配置，可参考`Sample`项目中的配置。
此外可在自定义的`XXXHostService`类中的构造方法中设置`HeartBeartSeconds`值，会覆盖配置中的值。


> 所有方法名与官方文档保持一致，并有中文注释提醒，只是更改了命名规范，非常容易查找使用。

## 已知问题

## 问题反馈

欢迎通过以下方式反馈问题:

- 提交 GitHub Issues
- Email： zpty@outlook.com（优先处理）
- QQ 群：737822525
