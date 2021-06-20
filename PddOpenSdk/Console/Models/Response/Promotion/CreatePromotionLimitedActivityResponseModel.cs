using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Promotion
{
public partial class CreatePromotionLimitedActivityResponseModel : PddResponseModel
{
/// <summary>
/// 结果列表
/// </summary>
[JsonProperty("result_list")]
public List<ResultListResponseModel> ResultList {get;set;}
public partial class ResultListResponseModel : PddResponseModel
{
/// <summary>
/// 创建失败时的失败原因
/// </summary>
[JsonProperty("fail_reason")]
public string FailReason {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public string GoodsId {get;set;}
/// <summary>
/// 商品是否创建成功。0代表成功，非0代表失败
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}

}

}

}
