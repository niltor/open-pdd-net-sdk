using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddkoauth
{
    public partial class QueryDdkOauthFinanceCpaRequestModel : PddRequestModel
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("date_end")]
        public string DateEnd { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("date_start")]
        public string DateStart { get; set; }
        /// <summary>
        /// 场景值(全部、单品、红包、转盘免单、转盘优惠券、新人红包)
        /// </summary>
        [JsonProperty("source_type")]
        public int? SourceType { get; set; }

    }

}
