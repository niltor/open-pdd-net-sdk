using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreatePromotionGoodsCouponResponseModel : PddResponseModel
    {
        /// <summary>
/// 创建无门槛商品劵批次对象
/// </summary>
[JsonProperty("goods_coupon_batch_create_response")]
public GoodsCouponBatchCreateResponseResponseModel GoodsCouponBatchCreateResponse {get;set;}

    public partial class GoodsCouponBatchCreateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 创建的无门槛商品劵批次id
/// </summary>
[JsonProperty("batch_id")]
public object BatchId {get;set;}

}

}
}