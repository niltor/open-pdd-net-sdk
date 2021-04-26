using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Voucher
{
    public partial class SyncVoucherRealtimeVerifyRequestModel : PddRequestModel
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestModel Request { get; set; }
        public partial class RequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 订单号
            /// </summary>
            [JsonProperty("order_sn")]
            public string OrderSn { get; set; }
            /// <summary>
            /// 备注
            /// </summary>
            [JsonProperty("remark")]
            public string Remark { get; set; }
            /// <summary>
            /// ISV核销流水号
            /// </summary>
            [JsonProperty("serial_no")]
            public string SerialNo { get; set; }
            /// <summary>
            /// 门店名称
            /// </summary>
            [JsonProperty("shop_name")]
            public string ShopName { get; set; }
            /// <summary>
            /// 门店编号
            /// </summary>
            [JsonProperty("shop_no")]
            public string ShopNo { get; set; }
            /// <summary>
            /// 卡券核销时间（13 位毫秒）
            /// </summary>
            [JsonProperty("verify_time")]
            public long VerifyTime { get; set; }
            /// <summary>
            /// 卡券编号
            /// </summary>
            [JsonProperty("out_voucher_id")]
            public string OutVoucherId { get; set; }

        }

    }

}
