namespace PddOpenSdk.Models.Request.Voucher;
public partial class SendVoucherAppointmentInfo
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
    /// 预约时间, 距离格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总毫秒数
    /// </summary>
    [JsonPropertyName("appointment_time")]
    public long AppointmentTime { get; set; }
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

