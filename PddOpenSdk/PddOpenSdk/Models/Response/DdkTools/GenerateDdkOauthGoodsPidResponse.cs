namespace PddOpenSdk.Models.Response.DdkTools;
public partial class GenerateDdkOauthGoodsPidResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("p_id_generate_response")]
    public PIdGenerateResponseResponse PIdGenerateResponse { get; set; }
    public partial class PIdGenerateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 多多进宝推广位对象列表
        /// </summary>
        [JsonPropertyName("p_id_list")]
        public List<PIdListResponse> PIdList { get; set; }

        /// <summary>
        /// PID剩余数量
        /// </summary>
        [JsonPropertyName("remain_pid_count")]
        public int? RemainPidCount { get; set; }
        public partial class PIdListResponse : PddResponseModel
        {

            /// <summary>
            /// 推广位创建时间
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
            /// 调用方推广位ID
            /// </summary>
            [JsonPropertyName("p_id")]
            public string PId { get; set; }

        }

    }

}

