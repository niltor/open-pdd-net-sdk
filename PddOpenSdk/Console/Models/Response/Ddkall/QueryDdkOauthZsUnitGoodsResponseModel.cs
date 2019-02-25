using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddkall
{
public partial class QueryDdkOauthZsUnitGoodsResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("zs_unit_goods_query_response")]
public ZsUnitGoodsQueryResponseResponseModel ZsUnitGoodsQueryResponse {get;set;}
public partial class ZsUnitGoodsQueryResponseResponseModel : PddResponseModel
{
/// <summary>
/// 请求到的结果数
/// </summary>
[JsonProperty("total_count")]
public int? TotalCount {get;set;}
/// <summary>
/// 列表
/// </summary>
[JsonProperty("list")]
public List<ListResponseModel> List {get;set;}
public partial class ListResponseModel : PddResponseModel
{
/// <summary>
/// coupon_total_quantity
/// </summary>
[JsonProperty("coupon_total_quantity")]
public long? CouponTotalQuantity {get;set;}

}

}

}

}
