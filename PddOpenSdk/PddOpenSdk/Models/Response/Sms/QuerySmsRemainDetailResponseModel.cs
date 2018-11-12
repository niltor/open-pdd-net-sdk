using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class QuerySmsRemainDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_remain_detail_query_response")]
        public SmsRemainDetailQueryResponseResponseModel SmsRemainDetailQueryResponse { get; set; }
        public partial class SmsRemainDetailQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 剩余金额
            /// </summary>
            [JsonProperty("remain_money")]
            public long RemainMoney { get; set; }
            /// <summary>
            /// 剩余数量
            /// </summary>
            [JsonProperty("remain_number")]
            public long RemainNumber { get; set; }

        }

    }

}
