using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.LogisticsCompany
{
    public partial class SubLogisticsCoTrackRequestModel : PddRequestModel
    {
        /// <summary>
        /// 快递公司伙伴ID
        /// </summary>
        [JsonProperty("ship_id")]
        public string ShipId { get; set; }
        /// <summary>
        /// 消息体
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

    }

}
