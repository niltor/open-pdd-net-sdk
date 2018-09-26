using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Refund
{
    public class OrderSnsExistsRefund
    {

        /// <summary>
        /// Examples: "180415-352642978562639"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
    }

    public class RefundStatusCheckResponse
    {

        /// <summary>
        /// Examples: [{"order_sn":"180415-352642978562639"}]
        /// </summary>
        [JsonProperty("order_sns_exists_refund")]
        public IList<OrderSnsExistsRefund> OrderSnsExistsRefund { get; set; }
    }

    public class CheckRefundStatusResponseModel
    {

        /// <summary>
        /// Examples: {"order_sns_exists_refund":[{"order_sn":"180415-352642978562639"}]}
        /// </summary>
        [JsonProperty("refund_status_check_response")]
        public RefundStatusCheckResponse RefundStatusCheckResponse { get; set; }
    }


}
