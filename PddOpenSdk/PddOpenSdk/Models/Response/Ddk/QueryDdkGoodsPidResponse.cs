namespace PddOpenSdk.Models.Response.Ddk;
public partial class QueryDdkGoodsPidResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("p_id_query_response")]
    public PIdQueryResponseResponse PIdQueryResponse { get; set; }
    public partial class PIdQueryResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 多多进宝推广位对象列表
        /// </summary>
        [JsonPropertyName("p_id_list")]
        public List<PIdListResponse> PIdList { get; set; }

        /// <summary>
        /// 返回推广位总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; }
        public partial class PIdListResponse : PddResponseModel
        {

            /// <summary>
            /// 推广位生成时间
            /// </summary>
            [JsonPropertyName("create_time")]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 媒体id
            /// </summary>
            [JsonPropertyName("media_id")]
            public long? MediaId { get; set; }

            /// <summary>
            /// 推广位名称
            /// </summary>
            [JsonPropertyName("pid_name")]
            public string PidName { get; set; }

            /// <summary>
            /// 推广位ID
            /// </summary>
            [JsonPropertyName("p_id")]
            public string PId { get; set; }

            /// <summary>
            /// 推广位状态：0-正常，1-封禁
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

        }

    }

}

