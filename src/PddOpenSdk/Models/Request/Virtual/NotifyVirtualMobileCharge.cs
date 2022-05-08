namespace PddOpenSdk.Models.Request.Virtual;
public partial class NotifyVirtualMobileCharge
{

    /// <summary>
    /// 直充附加信息对象数组
    /// </summary>
    [JsonPropertyName("charge_certi")]
    public List<ChargeCertiModel> ChargeCerti { get; set; }

    /// <summary>
    /// 电子发票信息 0-不支持开具  1-支持开具
    /// </summary>
    [JsonPropertyName("ele_invoice")]
    public int? EleInvoice { get; set; }

    /// <summary>
    /// 拼多多订单编码
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 11122dafa 外部系统订单编码
    /// </summary>
    [JsonPropertyName("outer_order_sn")]
    public string OuterOrderSn { get; set; }

    /// <summary>
    /// 虚拟系统充值结果，SUCCESS-充值成功，FAIL-充值失败
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
    public partial class ChargeCertiModel
    {

        /// <summary>
        /// 直充充值金额（单位：分）
        /// </summary>
        [JsonPropertyName("charge_certi_amount")]
        public long? ChargeCertiAmount { get; set; }

        /// <summary>
        /// 直充充值成功时间 （yyyy-MM-dd HH:mm:ss格式）
        /// </summary>
        [JsonPropertyName("charge_certi_date")]
        public string ChargeCertiDate { get; set; }

        /// <summary>
        /// 直充充值号码
        /// </summary>
        [JsonPropertyName("charge_certi_mobile")]
        public string ChargeCertiMobile { get; set; }

        /// <summary>
        /// 充值卡号尾号
        /// </summary>
        [JsonPropertyName("charge_certi_mobile_tail")]
        public string ChargeCertiMobileTail { get; set; }

        /// <summary>
        /// 直充充值单号
        /// </summary>
        [JsonPropertyName("charge_certi_order_sn")]
        public string ChargeCertiOrderSn { get; set; }

        /// <summary>
        /// 直充短信原文
        /// </summary>
        [JsonPropertyName("charge_certi_text")]
        public string ChargeCertiText { get; set; }

        /// <summary>
        /// 代理商(渠道)编号
        /// </summary>
        [JsonPropertyName("merchant_outer_id")]
        public string MerchantOuterId { get; set; }

    }

}

