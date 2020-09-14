using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Refund
{
    public partial class UpdateNextoneLogisticsWarehouseResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// result
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// after_sales_id
                /// </summary>
                [JsonProperty("after_sales_id")]
                public long? AfterSalesId { get; set; }
                /// <summary>
                /// order_sn
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }

            }

        }

    }

}
