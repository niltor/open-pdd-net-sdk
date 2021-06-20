using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsAdvicePriceRequestModel : PddRequestModel
{
/// <summary>
/// 获取商品建议价格请求参数
/// </summary>
[JsonProperty("request")]
public RequestRequestModel Request {get;set;}
public partial class RequestRequestModel : PddRequestModel
{
/// <summary>
/// 页码，默认1
/// </summary>
[JsonProperty("page")]
public int? Page {get;set;}
/// <summary>
/// 每页数量，默认100，最大100
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}

}

}

}
