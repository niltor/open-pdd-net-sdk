namespace PddOpenSdk.Models.Request.Voucher;
public partial class VerificationVoucherVirtualCard
{

    /// <summary>
    /// 拼多多订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 券信息列表
    /// </summary>
    [JsonPropertyName("voucher_data_list")]
    public List<VoucherDataListModel> VoucherDataList { get; set; }
    public partial class VoucherDataListModel
    {

        /// <summary>
        /// 流水号
        /// </summary>
        [JsonPropertyName("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 券状态更改时间
        /// </summary>
        [JsonPropertyName("voucher_time")]
        public long VoucherTime { get; set; }

        /// <summary>
        /// 券状态 1：已核销；2：已销毁
        /// </summary>
        [JsonPropertyName("voucher_status")]
        public int VoucherStatus { get; set; }

        /// <summary>
        /// 券号
        /// </summary>
        [JsonPropertyName("voucher_no")]
        public string VoucherNo { get; set; }

    }

}

