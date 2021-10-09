namespace PddOpenSdk.Models.Request.Refund;
public partial class UpdateNextoneLogisticsWarehouse
{

    /// <summary>
    /// request
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 售后id
        /// </summary>
        [JsonPropertyName("after_sales_id")]
        public long AfterSalesId { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonPropertyName("operate_time")]
        public long OperateTime { get; set; }

        /// <summary>
        /// order_sn
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// 物流公司id
        /// </summary>
        [JsonPropertyName("reverse_logistics_id")]
        public int? ReverseLogisticsId { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("reverse_tracking_number")]
        public string ReverseTrackingNumber { get; set; }

        /// <summary>
        /// 退货入库状态 1：成功；2：失败
        /// </summary>
        [JsonPropertyName("warehouse_status")]
        public int WarehouseStatus { get; set; }

    }

}

