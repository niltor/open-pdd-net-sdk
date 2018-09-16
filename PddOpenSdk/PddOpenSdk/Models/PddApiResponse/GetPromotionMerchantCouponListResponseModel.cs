using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetPromotionMerchantCouponListResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回店铺优惠券批次列表
/// </summary>
[JsonProperty("merchant_coupon_batch_list_response")]
public object MerchantCouponBatchListResponse {get;set;}

    public partial class MerchantCouponBatchListResponseResponseModel : PddResponseModel
    {
        
}

}
}
