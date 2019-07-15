using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Adplan
{
    public partial class BidAdDeleteLocationResponseModel : PddResponseModel
    {
        /// <summary>
        /// 开平返回
        /// </summary>
        [JsonProperty("open_api_response")]
        public OpenApiResponseResponseModel OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 执行标识， true 成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
