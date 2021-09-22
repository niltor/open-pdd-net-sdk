using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Oversea
{
    public partial class NotifyOverseaDeclarationFailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 1-超过购买额度，2-清关异常（如重量超标、退运、扣留等）
        /// </summary>
        [JsonProperty("fail_reason")]
        public int FailReason { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
