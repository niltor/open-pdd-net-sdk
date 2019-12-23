using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class PostMallInfoStoreUpdateResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mall_info_store_update_post_response")]
        public MallInfoStoreUpdatePostResponseResponseModel MallInfoStoreUpdatePostResponse { get; set; }
        public partial class MallInfoStoreUpdatePostResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
