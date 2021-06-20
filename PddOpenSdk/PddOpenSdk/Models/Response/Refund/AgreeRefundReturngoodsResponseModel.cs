using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Refund
{
    public partial class AgreeRefundReturngoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 接口调用错误编码
            /// </summary>
            [JsonProperty("error_code")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 接口调用错误描述
            /// </summary>
            [JsonProperty("error_msg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 返回内容
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            /// <summary>
            /// 接口是否调用成功
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 售后id
                /// </summary>
                [JsonProperty("after_sales_id")]
                public long? AfterSalesId { get; set; }
                /// <summary>
                /// 退货是否成功描述
                /// </summary>
                [JsonProperty("message")]
                public string Message { get; set; }
                /// <summary>
                /// 订单号
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }
                /// <summary>
                /// 退货是否成功
                /// </summary>
                [JsonProperty("success")]
                public bool? Success { get; set; }

            }

        }

    }

}
