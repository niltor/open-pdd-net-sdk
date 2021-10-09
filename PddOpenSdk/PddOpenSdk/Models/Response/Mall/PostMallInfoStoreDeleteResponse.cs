namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoStoreDeleteResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("mall_info_store_delete_post_response")]
    public MallInfoStoreDeletePostResponseResponse MallInfoStoreDeletePostResponse { get; set; }
    public partial class MallInfoStoreDeletePostResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

