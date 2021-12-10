namespace PddOpenSdk.Models.Response.Voucher;
public partial class ComplainVoucherVoucherResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("voucher_voucher_complain_response")]
    public VoucherVoucherComplainResponseResponse VoucherVoucherComplainResponse { get; set; }
    public partial class VoucherVoucherComplainResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

