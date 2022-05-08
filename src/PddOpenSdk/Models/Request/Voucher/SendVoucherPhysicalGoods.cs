namespace PddOpenSdk.Models.Request.Voucher;
public partial class SendVoucherPhysicalGoods
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
    /// 优惠券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]
    /// </summary>
    [JsonPropertyName("voucher_list")]
    public List<VoucherListModel> VoucherList { get; set; }

    /// <summary>
    /// 物流方式  1  物流发货   2 自提
    /// </summary>
    [JsonPropertyName("logistics_type")]
    public int LogisticsType { get; set; }

    /// <summary>
    /// 收件人
    /// </summary>
    [JsonPropertyName("recipient")]
    public string Recipient { get; set; }

    /// <summary>
    /// 收件人电话
    /// </summary>
    [JsonPropertyName("recipient_mobile")]
    public string RecipientMobile { get; set; }

    /// <summary>
    /// 收件人地址
    /// </summary>
    [JsonPropertyName("recipient_address")]
    public string RecipientAddress { get; set; }

    /// <summary>
    /// 物流单号
    /// </summary>
    [JsonPropertyName("logistics_no")]
    public string LogisticsNo { get; set; }

    /// <summary>
    /// 物流公司编号
    /// </summary>
    [JsonPropertyName("logistics_company_id")]
    public string LogisticsCompanyId { get; set; }

    /// <summary>
    /// 物流公司名称
    /// </summary>
    [JsonPropertyName("logistics_company")]
    public string LogisticsCompany { get; set; }
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

