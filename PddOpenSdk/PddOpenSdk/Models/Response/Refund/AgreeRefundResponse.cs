namespace PddOpenSdk.Models.Response.Refund;
public partial class AgreeRefundResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("after_sales_id")]
            public long? AfterSalesId { get; set; }

            /// <summary>
            /// 退款操作成功      退款操作结果信息。如果退款失败，会返回失败原因
            /// </summary>
            [JsonPropertyName("message")]
            public string Message { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 接口调用成功
            /// </summary>
            [JsonPropertyName("succ")]
            public bool? Succ { get; set; }

        }

    }

}

