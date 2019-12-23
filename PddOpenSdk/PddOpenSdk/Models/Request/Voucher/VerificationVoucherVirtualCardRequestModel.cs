using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Voucher
{
    public partial class VerificationVoucherVirtualCardRequestModel : PddRequestModel
    {
        /// <summary>
        /// 拼多多订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
        /// <summary>
        /// 券信息列表
        /// </summary>
        [JsonProperty("voucher_data_list")]
        public List<VoucherDataListRequestModel> VoucherDataList { get; set; }
        public partial class VoucherDataListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 流水号
            /// </summary>
            [JsonProperty("out_trans_no")]
            public string OutTransNo { get; set; }
            /// <summary>
            /// 券状态更改时间
            /// </summary>
            [JsonProperty("voucher_time")]
            public long VoucherTime { get; set; }
            /// <summary>
            /// 券状态 1：已核销；2：已销毁
            /// </summary>
            [JsonProperty("voucher_status")]
            public int VoucherStatus { get; set; }
            /// <summary>
            /// 券号
            /// </summary>
            [JsonProperty("voucher_no")]
            public string VoucherNo { get; set; }

        }

    }

}
