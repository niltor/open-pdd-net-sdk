using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Refund
{
    public partial class AgreeRefundResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("after_sales_id")]
                public long? AfterSalesId { get; set; }
                /// <summary>
                /// 退款操作成功      退款操作结果信息。如果退款失败，会返回失败原因
                /// </summary>
                [JsonProperty("message")]
                public string Message { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }
                /// <summary>
                /// 接口调用成功
                /// </summary>
                [JsonProperty("succ")]
                public bool? Succ { get; set; }

            }

        }

    }

}
