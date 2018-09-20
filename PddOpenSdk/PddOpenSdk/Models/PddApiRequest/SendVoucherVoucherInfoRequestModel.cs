using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class SendVoucherVoucherInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
        /// <summary>
        /// 外部流水号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
        /// <summary>
        /// 卡券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]
        /// </summary>
        [JsonProperty("voucher_list")]
        public VoucherListRequestModel VoucherList { get; set; }

        public partial class VoucherListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 卡券ID
            /// </summary>
            [JsonProperty("voucher_id")]
            public string VoucherId { get; set; }
            /// <summary>
            /// 卡券号
            /// </summary>
            [JsonProperty("voucher_no")]
            public string VoucherNo { get; set; }

        }

    }
}
