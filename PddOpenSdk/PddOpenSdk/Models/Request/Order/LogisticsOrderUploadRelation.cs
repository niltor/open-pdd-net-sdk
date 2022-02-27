namespace PddOpenSdk.Models.Request.Order;
public partial class LogisticsOrderUploadRelation
{

    /// <summary>
    /// 订单多包裹发货时使用的其他发货快递信息
    /// </summary>
    [JsonPropertyName("extra_track_list")]
    public List<ExtraTrackListModel> ExtraTrackList { get; set; }

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }
    public partial class ExtraTrackListModel
    {

        /// <summary>
        /// 快递公司id
        /// </summary>
        [JsonPropertyName("shipping_id")]
        public int ShippingId { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

    }

}

