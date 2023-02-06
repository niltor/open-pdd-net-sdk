namespace PddOpenSdk.Models.Response.Order;
public partial class UpdateNextoneLogisticsWarehouseResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// after_sales_id
            /// </summary>
            [JsonPropertyName("after_sales_id")]
            public long? AfterSalesId { get; set; }

            /// <summary>
            /// order_sn
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

        }

    }

}

