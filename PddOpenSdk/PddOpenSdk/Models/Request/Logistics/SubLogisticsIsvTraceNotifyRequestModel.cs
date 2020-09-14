using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Logistics
{
    public partial class SubLogisticsIsvTraceNotifyRequestModel : PddRequestModel
    {
        /// <summary>
        /// 快递公司编码
        /// </summary>
        [JsonProperty("ship_code")]
        public string ShipCode { get; set; }
        /// <summary>
        /// 收件人手机
        /// </summary>
        [JsonProperty("tel")]
        public string Tel { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonProperty("track_no")]
        public string TrackNo { get; set; }

    }

}
