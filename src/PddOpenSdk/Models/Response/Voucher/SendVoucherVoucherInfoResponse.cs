namespace PddOpenSdk.Models.Response.Voucher;
public partial class SendVoucherVoucherInfoResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("voucher_voucher_info_send_response")]
    public VoucherVoucherInfoSendResponseResponse VoucherVoucherInfoSendResponse { get; set; }
    public partial class VoucherVoucherInfoSendResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

