using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public class VoucherVoucherComplainResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class ComplainVoucherVoucherResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("voucher_voucher_complain_response")]
        public VoucherVoucherComplainResponse VoucherVoucherComplainResponse { get; set; }
    }


}
