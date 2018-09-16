using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class VerificationVoucherVirtualCardResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("voucher_voucher_info_verify_response")]
public object VoucherVoucherInfoVerifyResponse {get;set;}

    public partial class VoucherVoucherInfoVerifyResponseResponseModel : PddResponseModel
    {
        
}

}
}
