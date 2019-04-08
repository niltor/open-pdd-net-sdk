using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class GetMallInfoVerifyCodeResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("mall_info_verify_code_get_response")]
        public MallInfoVerifyCodeGetResponseResponseModel MallInfoVerifyCodeGetResponse { get; set; }
        public partial class MallInfoVerifyCodeGetResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 核实验证码
            /// </summary>
            [JsonProperty ("verify_code")]
            public string VerifyCode { get; set; }

        }

    }

}