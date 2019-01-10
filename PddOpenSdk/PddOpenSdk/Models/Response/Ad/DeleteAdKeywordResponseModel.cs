using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class DeleteAdKeywordResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_keyword_delete_response")]
        public AdKeywordDeleteResponseResponseModel AdKeywordDeleteResponse { get; set; }
        public partial class AdKeywordDeleteResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
