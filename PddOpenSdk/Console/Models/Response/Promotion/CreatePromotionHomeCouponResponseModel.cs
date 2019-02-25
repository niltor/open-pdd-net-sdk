using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Promotion
{
public partial class CreatePromotionHomeCouponResponseModel : PddResponseModel
{
/// <summary>
/// 创建店铺首页优惠券批次对象
/// </summary>
[JsonProperty("home_coupon_batch_create_response")]
public HomeCouponBatchCreateResponseResponseModel HomeCouponBatchCreateResponse {get;set;}
public partial class HomeCouponBatchCreateResponseResponseModel : PddResponseModel
{
/// <summary>
/// 批次id
/// </summary>
[JsonProperty("batch_id")]
public long? BatchId {get;set;}

}

}

}
