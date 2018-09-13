using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CreatePromotionHomeCouponResponseModel : PddResponseModel
    {
        /// <summary>
/// 创建店铺首页优惠券批次对象
/// </summary>
[JsonProperty("home_coupon_batch_create_response")]
public object HomeCouponBatchCreateResponse {get;set;}
/// <summary>
/// 批次id
/// </summary>
[JsonProperty("batch_id")]
public object BatchId {get;set;}

    public partial class HomeCouponBatchCreateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 批次id
/// </summary>
[JsonProperty("batch_id")]
public object BatchId {get;set;}

}

}
}
