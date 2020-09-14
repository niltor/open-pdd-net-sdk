using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class PostMallInfoStoreDeleteResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mall_info_store_delete_post_response")]
        public MallInfoStoreDeletePostResponseResponseModel MallInfoStoreDeletePostResponse { get; set; }
        public partial class MallInfoStoreDeletePostResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
