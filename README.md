# 说明文档

[![Build status](https://dev.azure.com/msdev-zpty/pdd-open-net-sdk/_apis/build/status/pdd-open-net-sdk-CI)](https://dev.azure.com/msdev-zpty/pdd-open-net-sdk/_build/latest?definitionId=1)
[![NuGet](https://img.shields.io/nuget/v/MSDev.PddOpenSdk.AspNetCore.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/MSDev.PddOpenSdk.AspNetCore/)
[![NuGet](https://img.shields.io/nuget/dt/MSDev.PddOpenSdk.AspNetCore.svg)](https://www.nuget.org/packages/MSDev.PddOpenSdk.AspNetCore/)
[![Join the chat at https://gitter.im/open-pdd-net-sdk/Lobby](https://badges.gitter.im/open-pdd-net-sdk/Lobby.svg)](https://gitter.im/open-pdd-net-sdk/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

open-pdd-net-sdk，拼多多开放平台 DotNet SDK。

## **特别说明**

遇到任何问题可通过底部联系方式反馈，作者会第一时间进行处理！

## 更新说明

### V1.10(2019/03/19)

- 核心类库添加了对 `Net452` 框架的支持，方便非Net Core直接使用核心类库。
- 测试了图片上传功能。官方文档并没有明确图片上传的内容，只是说提交一个base64字符串，实际上你需要上传的内容应该类似下面:

  `data:image/png;base64,XXXXXX`

你需要在你的base64前面拼接上`data:image`相关信息，这样才能成功，否则会提示图片格式错误。

### V1.04(2019/03/12)

- 修复复杂请求模型，签名验证错误的问题。

### V1.02(2019/02/25)

- 同步更新到官方最新接口。

### V1.0 (2019/01/10)

- 添加完善新接口，同步到官方最新，如消息服务API。
- 完善所有请求和返回类，新增新接口所需类型。

### V0.2.0 (2018/11/12)

- 添加完善新接口，同步到官方最新。
- 完善所有请求和返回类，新增新接口所需类型。
- 处理某种情况下签名错误的问题。

### V0.1beta

- 添加了仓储 API。
- 添加 PddService 相关接口字段属性的中文注释。

## 类库说明

支持基于 NETStandardv2.0 的项目，支持 **.NetFramework 4.5.2+，C#7.1**。

ASP.NET Core 项目请使用 Nuget 包 `MSDev.PddOpenSdk.AspNetCore`，可直接通过注入服务的方式使用。

其他类型使用 Nuget 包 `MSDev.PddOpenSdk`。

## 使用说明

### Console项目

该项目是可以遍历并自动生成所有请求模型类、返回模型类以及请求服务类，生成后部分会有重名，更改即可。

### PddOpenSdk 核心类库使用

支持 `.Net Framework4.5.2`及`Net Standard 2.0` ，安装 Nuget 包 `MSDev.PddOpenSdk`。

使用示例:

```csharp
class Program
{
    static async Task Main(string[] args)
    {
        // 先使用code换取token
        string code = "";
        var authApi = new AuthApi();
        await authApi.GetAccessTokenAsync(code);
        // 设置ClientId与ClientSecret
        PddCommonApi.ClientId = "ID";
        PddCommonApi.ClientSecret = "Secret";
        // 构造请求内容
        var model = new GenDdkWeappQrcodeUrlRequestModel
        {
            PId = "123133",
            GoodsIdList = new System.Collections.Generic.List<long> { 1122, 331323 }
        };
        var api = new DdkApi();
        var result = await api.GenDdkWeappQrcodeUrlAsync(model);

    }
}
```

### ASP.NET Core 项目使用

先安装Nuget 包 `MSDev.PddOpenSdk.AspNetCore`。

可参考[示例代码](https://github.com/niltor/open-pdd-net-sdk/tree/dev/PddOpenSdk/Sample)

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

- 签名错误问题，主要检查一下时间戳的获取是否正确。
- 由于拼多多官方文档中存在一些问题，可能会有一些返回模型是有问题的，无法正确解析到类型，导致没有正确返回数据！遇到这类问题，可直接修改源代码，提交代码合并申请；或者直接找作者反馈。

## 问题反馈

欢迎通过以下方式反馈问题:

- 提交 GitHub Issues（优先处理）
- Email： zpty@outlook.com
- QQ 群：737822525
