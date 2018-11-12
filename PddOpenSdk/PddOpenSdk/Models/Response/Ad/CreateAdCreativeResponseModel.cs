using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class CreateAdCreativeResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("open_api_response")]
        public OpenApiResponseResponseModel OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否请求成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool IsSuccess { get; set; }

        }

    }

}
