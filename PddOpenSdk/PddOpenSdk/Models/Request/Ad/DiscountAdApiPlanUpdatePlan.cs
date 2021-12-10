namespace PddOpenSdk.Models.Request.Ad;
public partial class DiscountAdApiPlanUpdatePlan
{

    /// <summary>
    /// 分时折扣
    /// </summary>
    [JsonPropertyName("planDiscount")]
    public PlanDiscountModel PlanDiscount { get; set; }

    /// <summary>
    /// 广告计划Id
    /// </summary>
    [JsonPropertyName("planId")]
    public long PlanId { get; set; }
    public partial class PlanDiscountModel
    {

        /// <summary>
        /// 分时折扣配置列表
        /// </summary>
        [JsonPropertyName("discounts")]
        public List<DiscountsModel> Discounts { get; set; }
        public partial class DiscountsModel
        {

            /// <summary>
            /// 小时。0-23分别表示第1个小时到第24个小时。
            /// </summary>
            [JsonPropertyName("index")]
            public int Index { get; set; }

            /// <summary>
            /// 折扣比例。千分比（即rate等于1000表示比例100%）。
            /// </summary>
            [JsonPropertyName("rate")]
            public int Rate { get; set; }

        }

    }

}

