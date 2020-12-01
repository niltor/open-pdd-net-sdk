using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class DiscountAdApiPlanUpdatePlanRequestModel : PddRequestModel
    {
        /// <summary>
        /// 分时折扣
        /// </summary>
        [JsonProperty("planDiscount")]
        public PlanDiscountRequestModel PlanDiscount { get; set; }
        /// <summary>
        /// 广告计划Id
        /// </summary>
        [JsonProperty("planId")]
        public long PlanId { get; set; }
        public partial class PlanDiscountRequestModel : PddRequestModel
        {
            /// <summary>
            /// 分时折扣配置列表
            /// </summary>
            [JsonProperty("discounts")]
            public List<DiscountsRequestModel> Discounts { get; set; }
            public partial class DiscountsRequestModel : PddRequestModel
            {
                /// <summary>
                /// 小时。0-23分别表示第1个小时到第24个小时。
                /// </summary>
                [JsonProperty("index")]
                public int Index { get; set; }
                /// <summary>
                /// 折扣比例。千分比（即rate等于1000表示比例100%）。
                /// </summary>
                [JsonProperty("rate")]
                public int Rate { get; set; }

            }

        }

    }

}
