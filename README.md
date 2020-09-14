# 说明文档

[![Build status](https://dev.azure.com/msdev-zpty/pdd-open-net-sdk/_apis/build/status/pdd-open-net-sdk-CI)](https://dev.azure.com/msdev-zpty/pdd-open-net-sdk/_build/latest?definitionId=1)
[![NuGet](https://img.shields.io/nuget/v/MSDev.PddOpenSdk.AspNetCore.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/MSDev.PddOpenSdk.AspNetCore/)
[![NuGet](https://img.shields.io/nuget/dt/MSDev.PddOpenSdk.AspNetCore.svg)](https://www.nuget.org/packages/MSDev.PddOpenSdk.AspNetCore/)
[![Join the chat at https://gitter.im/open-pdd-net-sdk/Lobby](https://badges.gitter.im/open-pdd-net-sdk/Lobby.svg)](https://gitter.im/open-pdd-net-sdk/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

open-pdd-net-sdk，拼多多开放平台 DotNet SDK。

## **特别说明**

遇到任何问题可通过底部联系方式反馈，作者会第一时间进行处理！

## 更新说明
更新文档已经迁移到[`CHANGELOG.md`](https://github.com/niltor/open-pdd-net-sdk/blob/dev/CHANGELOG.md)。

## 类库说明

支持基于 NETStandardv2.0 的项目，支持 **.NetFramework 4.5.2+，C#8.0**。

ASP.NET Core 项目请使用 Nuget 包 `MSDev.PddOpenSdk.AspNetCore`，可直接通过注入服务的方式使用。

其他类型使用 Nuget 包 `MSDev.PddOpenSdk`。

## 使用说明

### Console项目

该项目是通过官方接口获取并自动生成所有请求模型类、返回模型类以及请求服务类，生成后部分类名会有重名,更改成不同的类名即可。

执行方法，打开Console目录，然后执行`dotnet run`命令即可。

执行成功后，可使用Visual Studio自带的代码清理，对所有文件进行代码格式化操作。

### PddOpenSdk 核心类库使用

支持 `.Net Framework4.5.2`及`Net Standard 2.0` ，安装 Nuget 包 `MSDev.PddOpenSdk`。

使用示例:
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

### ASP.NET Core 项目使用

先安装Nuget 包 `MSDev.PddOpenSdk.AspNetCore`。

更多 [示例代码](https://github.com/niltor/open-pdd-net-sdk/tree/dev/PddOpenSdk/Sample)。

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

## 已知问题

 l
## 问题反馈

欢迎通过以下方式反馈问题:

- 提交 GitHub Issues
- Email： zpty@outlook.com（优先处理）
- QQ 群：737822525
