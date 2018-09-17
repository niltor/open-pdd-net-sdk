using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreatePromotionGoodsCouponResponseModel : PddResponseModel
    {
        /// <summary>
        /// 创建无门槛商品劵批次对象
        /// </summary>
        [JsonProperty("goods_coupon_batch_create_response")]
        public object GoodsCouponBatchCreateResponse { get; set; }

        public partial class GoodsCouponBatchCreateResponseResponseModel : PddResponseModel
        {

        }

    }
}
