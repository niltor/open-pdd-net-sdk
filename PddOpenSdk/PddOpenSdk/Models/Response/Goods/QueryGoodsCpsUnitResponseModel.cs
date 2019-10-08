using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class QueryGoodsCpsUnitResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long? GoodsId { get; set; }
        /// <summary>
        /// 佣金比例（千分比）
        /// </summary>
        [JsonProperty("rate")]
        public int? Rate { get; set; }
        /// <summary>
        /// 即将生效的全店推广计划佣金比（千分比），若没有则为null
        /// </summary>
        [JsonProperty("rate_to_be")]
        public int? RateToBe { get; set; }
        /// <summary>
        /// 商品状态，1-推广中，2-暂停，3-删除
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }
        /// <summary>
        /// 即将生效的全店推广计划状态：1-推广中，2-暂停推广，若没有则为null
        /// </summary>
        [JsonProperty("status_to_be")]
        public int? StatusToBe { get; set; }
        /// <summary>
        /// 计划使用的优惠券信息。商品没有优惠券将返回null，有优惠券将返回优惠券信息，包括优惠券起始结束时间，优惠券数量，剩余数量，金额等
        /// </summary>
        [JsonProperty("coupon_vo")]
        public CouponVoResponseModel CouponVo { get; set; }
        /// <summary>
        /// 通用推广计划佣金生效时间
        /// </summary>
        [JsonProperty("rate_to_be_day")]
        public string RateToBeDay { get; set; }
        /// <summary>
        /// 通用推广计划状态生效时间
        /// </summary>
        [JsonProperty("status_to_be_day")]
        public string StatusToBeDay { get; set; }
        public partial class CouponVoResponseModel : PddResponseModel
        {
            /// <summary>
            /// coupon_start_time
            /// </summary>
            [JsonProperty("coupon_start_time")]
            public string CouponStartTime { get; set; }
            /// <summary>
            /// coupon_end_time
            /// </summary>
            [JsonProperty("coupon_end_time")]
            public string CouponEndTime { get; set; }
            /// <summary>
            /// discount
            /// </summary>
            [JsonProperty("discount")]
            public int? Discount { get; set; }
            /// <summary>
            /// init_quantity
            /// </summary>
            [JsonProperty("init_quantity")]
            public long? InitQuantity { get; set; }
            /// <summary>
            /// remain_quantity
            /// </summary>
            [JsonProperty("remain_quantity")]
            public long? RemainQuantity { get; set; }

        }

    }

}
