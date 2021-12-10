namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoStoreUpdateResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("mall_info_store_update_post_response")]
    public MallInfoStoreUpdatePostResponseResponse MallInfoStoreUpdatePostResponse { get; set; }
    public partial class MallInfoStoreUpdatePostResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

