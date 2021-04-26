using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class MessageAdApiUnitUpdateOptimizationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }
        /// <summary>
        /// 优化信息
        /// </summary>
        [JsonProperty("optimizationMessage")]
        public OptimizationMessageRequestModel OptimizationMessage { get; set; }
        public partial class OptimizationMessageRequestModel : PddRequestModel
        {
            /// <summary>
            /// 数据积累期出价。当使用OCPX时对该字段赋值。
            /// </summary>
            [JsonProperty("accumulationBid")]
            public long? AccumulationBid { get; set; }
            /// <summary>
            /// 智能投放期出价。当使用OCPX时对该字段赋值。
            /// </summary>
            [JsonProperty("optimizationBid")]
            public long? OptimizationBid { get; set; }
            /// <summary>
            /// 优化目标。0表示不优化。1表示优化ROI，2表示优化转化成本。当计划使用智能推广时，该值必须传1；当单元使用自动调价功能(ECPC)时，该值必须传1；当单元使用OCPC功能时，该值必须传2。
            /// </summary>
            [JsonProperty("optimizationGoal")]
            public int OptimizationGoal { get; set; }
            /// <summary>
            /// 优化方式。0表示不优化，1表示ECPC，2表示OCPC。当计划使用智能推广时，该值必须传0；当单元使用ECPC时，该值必须传1；当使用OCPC时，该值必须传2。
            /// </summary>
            [JsonProperty("optimizationMethod")]
            public int? OptimizationMethod { get; set; }
            /// <summary>
            /// 可选优化出价列表。当使用OCPX时对该字段赋值。
            /// </summary>
            [JsonProperty("optionalOptimizationBidMessageList")]
            public List<OptionalOptimizationBidMessageListRequestModel> OptionalOptimizationBidMessageList { get; set; }
            public partial class OptionalOptimizationBidMessageListRequestModel : PddRequestModel
            {
                /// <summary>
                /// 可选优化出价价格
                /// </summary>
                [JsonProperty("optimizationBid")]
                public long OptimizationBid { get; set; }
                /// <summary>
                /// 可选优化出价目标。3表示优化店铺关注，4表示优化商品收藏，5表示优化询单
                /// </summary>
                [JsonProperty("optimizationGoal")]
                public int OptimizationGoal { get; set; }

            }

        }

    }

}
