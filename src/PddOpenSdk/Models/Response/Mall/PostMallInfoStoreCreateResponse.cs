namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoStoreCreateResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("mall_info_store_create_post_response")]
    public MallInfoStoreCreatePostResponseResponse MallInfoStoreCreatePostResponse { get; set; }
    public partial class MallInfoStoreCreatePostResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

