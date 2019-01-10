using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Voucher
{
    public partial class VerificationVoucherVirtualCardResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("voucher_voucher_info_verify_response")]
        public VoucherVoucherInfoVerifyResponseResponseModel VoucherVoucherInfoVerifyResponse { get; set; }
        public partial class VoucherVoucherInfoVerifyResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 拼多多订单号
            /// </summary>
            [JsonProperty("order_sn")]
            public string OrderSn { get; set; }
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }
            /// <summary>
            /// 商品属性id
            /// </summary>
            [JsonProperty("sku_id")]
            public long? SkuId { get; set; }
            /// <summary>
            /// 店铺id
            /// </summary>
            [JsonProperty("mall_id")]
            public long? MallId { get; set; }
            /// <summary>
            /// 券信息数组
            /// </summary>
            [JsonProperty("voucher_list")]
            public List<VoucherListResponseModel> VoucherList { get; set; }
            public partial class VoucherListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 卡号
                /// </summary>
                [JsonProperty("card_no")]
                public string CardNo { get; set; }
                /// <summary>
                /// 卡密
                /// </summary>
                [JsonProperty("card_code")]
                public string CardCode { get; set; }
                /// <summary>
                /// 标准密码
                /// </summary>
                [JsonProperty("mark_password")]
                public string MarkPassword { get; set; }
                /// <summary>
                /// 状态
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 返回状态
                /// </summary>
                [JsonProperty("refund_status")]
                public int? RefundStatus { get; set; }
                /// <summary>
                /// 验证处
                /// </summary>
                [JsonProperty("verification_at")]
                public long? VerificationAt { get; set; }

            }

        }

    }

}
