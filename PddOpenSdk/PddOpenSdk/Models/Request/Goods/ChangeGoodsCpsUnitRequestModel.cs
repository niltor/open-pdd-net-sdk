using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class ChangeGoodsCpsUnitRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 佣金比例（千分比）
        /// </summary>
        [JsonProperty("rate")]
        public long Rate { get; set; }
        /// <summary>
        /// 优惠券id
        /// </summary>
        [JsonProperty("coupon_id")]
        public long? CouponId { get; set; }
        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        [JsonProperty("coupon_start_time")]
        public string CouponStartTime { get; set; }
        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        [JsonProperty("coupon_end_time")]
        public string CouponEndTime { get; set; }
        /// <summary>
        /// 优惠券面额（单位为分）
        /// </summary>
        [JsonProperty("discount")]
        public long? Discount { get; set; }
        /// <summary>
        /// 设置的优惠券张数
        /// </summary>
        [JsonProperty("init_quantity")]
        public long? InitQuantity { get; set; }
        /// <summary>
        /// 优惠券剩余数量
        /// </summary>
        [JsonProperty("remain_quantity")]
        public long? RemainQuantity { get; set; }

    }

}
