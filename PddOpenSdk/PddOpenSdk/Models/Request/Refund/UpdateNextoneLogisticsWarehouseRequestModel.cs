using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Refund
{
    public partial class UpdateNextoneLogisticsWarehouseRequestModel : PddRequestModel
    {
        /// <summary>
        /// request
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestModel Request { get; set; }
        public partial class RequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 售后id
            /// </summary>
            [JsonProperty("after_sales_id")]
            public long AfterSalesId { get; set; }
            /// <summary>
            /// 操作时间
            /// </summary>
            [JsonProperty("operate_time")]
            public long OperateTime { get; set; }
            /// <summary>
            /// order_sn
            /// </summary>
            [JsonProperty("order_sn")]
            public string OrderSn { get; set; }
            /// <summary>
            /// 物流公司id
            /// </summary>
            [JsonProperty("reverse_logistics_id")]
            public int? ReverseLogisticsId { get; set; }
            /// <summary>
            /// 物流单号
            /// </summary>
            [JsonProperty("reverse_tracking_number")]
            public string ReverseTrackingNumber { get; set; }
            /// <summary>
            /// 退货入库状态 1：成功；2：失败
            /// </summary>
            [JsonProperty("warehouse_status")]
            public int WarehouseStatus { get; set; }

        }

    }

}
