using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public class VoucherVoucherInfoSendResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class SendVoucherVoucherInfoResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("voucher_voucher_info_send_response")]
        public VoucherVoucherInfoSendResponse VoucherVoucherInfoSendResponse { get; set; }
    }


}
