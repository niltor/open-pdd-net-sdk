namespace PddOpenSdk.Models.Response.Promotion;
public partial class CreatePromotionGoodsCouponResponse : PddResponseModel
{

    /// <summary>
    /// 创建无门槛商品劵批次对象
    /// </summary>
    [JsonPropertyName("goods_coupon_batch_create_response")]
    public GoodsCouponBatchCreateResponseResponse GoodsCouponBatchCreateResponse { get; set; }
    public partial class GoodsCouponBatchCreateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 创建的无门槛商品劵批次id
        /// </summary>
        [JsonPropertyName("batch_id")]
        public long? BatchId { get; set; }

    }

}

