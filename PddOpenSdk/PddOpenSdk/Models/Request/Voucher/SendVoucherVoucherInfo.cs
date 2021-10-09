namespace PddOpenSdk.Models.Request.Voucher;
public partial class SendVoucherVoucherInfo
{

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 外部流水号
    /// </summary>
    [JsonPropertyName("out_biz_no")]
    public string OutBizNo { get; set; }

    /// <summary>
    /// 卡券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]
    /// </summary>
    [JsonPropertyName("voucher_list")]
    public List<VoucherListModel> VoucherList { get; set; }
    public partial class VoucherListModel
    {

        /// <summary>
        /// 卡券ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 卡券号
        /// </summary>
        [JsonPropertyName("voucher_no")]
        public string VoucherNo { get; set; }

    }

}

