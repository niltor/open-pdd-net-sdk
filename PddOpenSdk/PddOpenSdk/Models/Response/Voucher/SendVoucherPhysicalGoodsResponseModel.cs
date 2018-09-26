using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public class VoucherPhysicalVoucherSendResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class SendVoucherPhysicalGoodsResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("voucher_physical_voucher_send_response")]
        public VoucherPhysicalVoucherSendResponse VoucherPhysicalVoucherSendResponse { get; set; }
    }


}
