namespace PddOpenSdk.Models.Response.Goods;
public partial class QueryGoodsCpsMallUnitResponse : PddResponseModel
{

    /// <summary>
    /// respone
    /// </summary>
    [JsonPropertyName("goods_cps_mall_unit_query_response")]
    public GoodsCpsMallUnitQueryResponseResponse GoodsCpsMallUnitQueryResponse { get; set; }
    public partial class GoodsCpsMallUnitQueryResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 全店推广计划佣金比（千分比）
        /// </summary>
        [JsonPropertyName("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// 修改后生效的佣金费率（千分比）
        /// </summary>
        [JsonPropertyName("rate_to_be")]
        public int? RateToBe { get; set; }

        /// <summary>
        /// 全店推广计划佣金生效时间
        /// </summary>
        [JsonPropertyName("rate_to_be_day")]
        public string RateToBeDay { get; set; }

        /// <summary>
        /// 全店推广计划状态：1-推广中，2-暂停推广
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 修改后生效的状态，1-推广中，2-暂停，3-删除
        /// </summary>
        [JsonPropertyName("status_to_be")]
        public int? StatusToBe { get; set; }

        /// <summary>
        /// 全店推广计划状态生效时间
        /// </summary>
        [JsonPropertyName("status_to_be_day")]
        public string StatusToBeDay { get; set; }

    }

}

