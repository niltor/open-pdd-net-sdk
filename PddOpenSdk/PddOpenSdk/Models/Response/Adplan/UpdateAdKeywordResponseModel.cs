using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Adplan
{
    public partial class UpdateAdKeywordResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_keyword_update_response")]
        public AdKeywordUpdateResponseResponseModel AdKeywordUpdateResponse { get; set; }
        public partial class AdKeywordUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
