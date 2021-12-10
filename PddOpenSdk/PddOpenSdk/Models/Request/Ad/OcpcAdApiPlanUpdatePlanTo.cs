namespace PddOpenSdk.Models.Request.Ad;
public partial class OcpcAdApiPlanUpdatePlanTo
{

    /// <summary>
    /// 单元OCPC信息列表
    /// </summary>
    [JsonPropertyName("adUnitUpdateOcpcMessageList")]
    public List<AdUnitUpdateOcpcMessageListModel> AdUnitUpdateOcpcMessageList { get; set; }

    /// <summary>
    /// 广告计划Id
    /// </summary>
    [JsonPropertyName("planId")]
    public long PlanId { get; set; }

    /// <summary>
    /// 场景类型。0表示搜索。
    /// </summary>
    [JsonPropertyName("scenesType")]
    public int ScenesType { get; set; }
    public partial class AdUnitUpdateOcpcMessageListModel
    {

        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonPropertyName("adId")]
        public long AdId { get; set; }

        /// <summary>
        /// OCPC信息
        /// </summary>
        [JsonPropertyName("optimizationMessage")]
        public OptimizationMessageModel OptimizationMessage { get; set; }
        public partial class OptimizationMessageModel
        {

            /// <summary>
            /// 智能投放期出价
            /// </summary>
            [JsonPropertyName("optimizationBid")]
            public long OptimizationBid { get; set; }

            /// <summary>
            /// 优化目标。单元使用OCPC功能时，该值必须传2。
            /// </summary>
            [JsonPropertyName("optimizationGoal")]
            public int OptimizationGoal { get; set; }

            /// <summary>
            /// 优化方式。当使用OCPC时，该值必须传2。
            /// </summary>
            [JsonPropertyName("optimizationMethod")]
            public int OptimizationMethod { get; set; }

        }

    }

}

