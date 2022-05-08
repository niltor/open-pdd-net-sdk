namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoGroupQueryResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("mall_store_group_list")]
        public List<MallStoreGroupListResponse> MallStoreGroupList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        public partial class MallStoreGroupListResponse : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("group_id")]
            public int? GroupId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("group_name")]
            public string GroupName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("mall_id")]
            public long? MallId { get; set; }

        }

    }

}

