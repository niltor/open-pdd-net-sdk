using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Voucher
{
    public partial class ComplainVoucherVoucherResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("voucher_voucher_complain_response")]
        public VoucherVoucherComplainResponseResponseModel VoucherVoucherComplainResponse { get; set; }
        public partial class VoucherVoucherComplainResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否请求成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
