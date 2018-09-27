# 说明文档

open-pdd-net-sdk，拼多多开放平台DotNet SDK。

## 类库说明

支持基于NETStandardv2.0的项目。

ASP.NET Core项目请使用Nuget包 `MSDev.PddOpenSdk.AspNetCore`，可直接通过注入服务的方式使用。

其他类型使用Nuget包 `MSDev.PddOpenSdk`。

## 使用说明
### ASP.NET Core 项目使用

可参考[示例代码](https://github.com/niltor/open-pdd-net-sdk/tree/dev/PddOpenSdk/Sample)

- 在Startup.cs中注入服务

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

- 获取AccessToken

```csharp
/// <summary>
/// 测试获取token
/// </summary>
/// <param name="code"></param>
/// <returns></returns>
public async Task<IActionResult> Callback(string code)
{
    var token = await _pdd.AuthApi.GetAccessTokenAsync(code);
    return Content(token.AccessToken);
}
```

- 调用其他接口

**一定要在获取 AccessToken之后调用其他接口**
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

由于拼多多官方文档中存在一些问题，可能会有一些返回模型是有问题的，无法正确解析到类型，导致没有正确返回数据！遇到这类问题，可直接修改源代码，提交代码合并申请；或者直接找作者反馈。

## 问题反馈

欢迎通过以下方式反馈问题:

- 提交GitHub Issues（优先处理）
- Email： zpty@outlook.com
- QQ群：737822525

