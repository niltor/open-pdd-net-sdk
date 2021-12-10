namespace PddOpenSdk.Models.Response.Mall;
public partial class GetMallInfoGroupRemoveStoreResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("mall_info_group_remove_store_get_response")]
    public MallInfoGroupRemoveStoreGetResponseResponse MallInfoGroupRemoveStoreGetResponse { get; set; }
    public partial class MallInfoGroupRemoveStoreGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

