using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class BidAdDeleteResponseModel : PddResponseModel {
        /// <summary>
        /// 开平返回结果
        /// </summary>
        [JsonProperty ("open_api_response")]
        public OpenApiResponseResponseModel OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel {
            /// <summary>
            /// api是否成功
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}