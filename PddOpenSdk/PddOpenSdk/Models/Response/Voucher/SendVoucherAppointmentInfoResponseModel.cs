using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public class VoucherAppointmentInfoSendResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class SendVoucherAppointmentInfoResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("voucher_appointment_info_send_response")]
        public VoucherAppointmentInfoSendResponse VoucherAppointmentInfoSendResponse { get; set; }
    }


}
