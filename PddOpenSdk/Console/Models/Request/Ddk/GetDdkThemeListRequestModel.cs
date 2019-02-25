using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class GetDdkThemeListRequestModel : PddRequestModel
{
/// <summary>
/// 返回的一页数据数量
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}
/// <summary>
/// 返回的页码
/// </summary>
[JsonProperty("page")]
public int? Page {get;set;}

}

}
