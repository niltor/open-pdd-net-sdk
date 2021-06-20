using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Mall
{
public partial class GetMallInfoResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("mall_info_get_response")]
public MallInfoGetResponseResponseModel MallInfoGetResponse {get;set;}
public partial class MallInfoGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 店铺logo
/// </summary>
[JsonProperty("logo")]
public string Logo {get;set;}
/// <summary>
/// 店铺描述
/// </summary>
[JsonProperty("mall_desc")]
public string MallDesc {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}
/// <summary>
/// 店铺名称
/// </summary>
[JsonProperty("mall_name")]
public string MallName {get;set;}
/// <summary>
/// 店铺类型,1:个人 2:企业 3:旗舰店 4:专卖店 5:专营店 6:普通店
/// </summary>
[JsonProperty("merchant_type")]
public int? MerchantType {get;set;}
/// <summary>
/// 店铺身份,0:厂商 1:分销商 2:都不是 3:都是
/// </summary>
[JsonProperty("mall_character")]
public int? MallCharacter {get;set;}

}

}

}
