using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Refund
{
    public partial class CheckRefundStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("refund_status_check_response")]
        public RefundStatusCheckResponseResponseModel RefundStatusCheckResponse { get; set; }
        public partial class RefundStatusCheckResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 存在售后的订单
            /// </summary>
            [JsonProperty("order_sns_exists_refund")]
            public List<OrderSnsExistsRefundResponseModel> OrderSnsExistsRefund { get; set; }
            public partial class OrderSnsExistsRefundResponseModel : PddResponseModel
            {
                /// <summary>
                /// 订单编号
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }

            }

        }

    }

}
