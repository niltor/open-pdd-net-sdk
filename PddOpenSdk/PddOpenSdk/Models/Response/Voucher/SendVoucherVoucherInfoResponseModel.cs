using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public partial class SendVoucherVoucherInfoResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("voucher_voucher_info_send_response")]
        public VoucherVoucherInfoSendResponseResponseModel VoucherVoucherInfoSendResponse { get; set; }
        public partial class VoucherVoucherInfoSendResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 是否请求成功
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}