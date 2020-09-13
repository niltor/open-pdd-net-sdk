using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class PageAdApiGoodsQueryRequestModel : PddRequestModel
{
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goodsName")]
public string GoodsName {get;set;}
/// <summary>
/// 分页查询，查询第几页
/// </summary>
[JsonProperty("pageNumber")]
public int PageNumber {get;set;}
/// <summary>
/// 分页查询，每页的大小
/// </summary>
[JsonProperty("pageSize")]
public int PageSize {get;set;}
/// <summary>
/// 计划Id
/// </summary>
[JsonProperty("planId")]
public long? PlanId {get;set;}

}

}
