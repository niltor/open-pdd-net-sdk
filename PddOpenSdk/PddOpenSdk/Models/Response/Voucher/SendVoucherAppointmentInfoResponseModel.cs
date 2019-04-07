using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public partial class SendVoucherAppointmentInfoResponseModel : PddResponseModel {
        /// <summary>
        /// voucher_appointment_info_send_response
        /// </summary>
        [JsonProperty ("voucher_appointment_info_send_response")]
        public VoucherAppointmentInfoSendResponseResponseModel VoucherAppointmentInfoSendResponse { get; set; }
        public partial class VoucherAppointmentInfoSendResponseResponseModel : PddResponseModel {
            /// <summary>
            /// is_success
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}