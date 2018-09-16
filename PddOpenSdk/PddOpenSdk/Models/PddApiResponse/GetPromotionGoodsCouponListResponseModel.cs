using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetPromotionGoodsCouponListResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回商品优惠券批次表
/// </summary>
[JsonProperty("merchant_coupon_batch_list_response")]
public object MerchantCouponBatchListResponse {get;set;}

    public partial class MerchantCouponBatchListResponseResponseModel : PddResponseModel
    {
        
}

}
}
