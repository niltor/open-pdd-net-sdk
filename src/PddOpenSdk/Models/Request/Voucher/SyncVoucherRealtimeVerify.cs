namespace PddOpenSdk.Models.Request.Voucher;
public partial class SyncVoucherRealtimeVerify
{

    /// <summary>
    /// 请求入参
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// ISV核销流水号
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 卡券核销时间（13 位毫秒）
        /// </summary>
        [JsonPropertyName("verify_time")]
        public long VerifyTime { get; set; }

        /// <summary>
        /// 卡券编号
        /// </summary>
        [JsonPropertyName("out_voucher_id")]
        public string OutVoucherId { get; set; }

    }

}

