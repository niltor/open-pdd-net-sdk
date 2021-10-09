namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoGroupAddStoreResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("mall_info_group_add_store_post_response")]
    public MallInfoGroupAddStorePostResponseResponse MallInfoGroupAddStorePostResponse { get; set; }
    public partial class MallInfoGroupAddStorePostResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

