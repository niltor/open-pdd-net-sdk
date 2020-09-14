using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class PostMallInfoGroupAddStoreResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mall_info_group_add_store_post_response")]
        public MallInfoGroupAddStorePostResponseResponseModel MallInfoGroupAddStorePostResponse { get; set; }
        public partial class MallInfoGroupAddStorePostResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
