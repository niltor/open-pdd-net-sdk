using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class SendVoucherAppointmentInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public object OrderSn { get; set; }
        /// <summary>
        /// 外部流水号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public object OutBizNo { get; set; }
        /// <summary>
        /// 优惠券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]
        /// </summary>
        [JsonProperty("voucher_list")]
        public object VoucherList { get; set; }
        /// <summary>
        /// 物流方式  1  物流发货   2 自提
        /// </summary>
        [JsonProperty("logistics_type")]
        public int LogisticsType { get; set; }
        /// <summary>
        /// 预约时间, 距离格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总毫秒数
        /// </summary>
        [JsonProperty("appointment_time")]
        public int AppointmentTime { get; set; }

        public partial class VoucherListRequestModel : PddRequestModel
        {

        }

    }
}
