namespace PddOpenSdk.Models.Request.Voucher;
public partial class GetVoucherRealtimeOrderno
{

    /// <summary>
    /// 请求体
    /// </summary>
    [JsonPropertyName("data")]
    public DataModel Data { get; set; }
    public partial class DataModel
    {

        /// <summary>
        /// 拼多多订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

    }

}

