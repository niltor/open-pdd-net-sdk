namespace PddOpenSdk.Models.Response.Refund;
public partial class GetLogisticsOrdertraceResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("logistics_ordertrace_get_resposne")]
    public LogisticsOrdertraceGetResposneResponse LogisticsOrdertraceGetResposne { get; set; }
    public partial class LogisticsOrdertraceGetResposneResponse : PddResponseModel
    {

        /// <summary>
        /// 返回列表
        /// </summary>
        [JsonPropertyName("trace_list")]
        public List<TraceListResponse> TraceList { get; set; }
        public partial class TraceListResponse : PddResponseModel
        {

            /// <summary>
            /// 节点说明 ，指明当前节点揽收、派送，签收。
            /// </summary>
            [JsonPropertyName("action")]
            public string Action { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [JsonPropertyName("desc")]
            public string Desc { get; set; }

            /// <summary>
            /// 地址地一
            /// </summary>
            [JsonPropertyName("node_description")]
            public string NodeDescription { get; set; }

            /// <summary>
            /// 状态描述
            /// </summary>
            [JsonPropertyName("status_desc")]
            public string StatusDesc { get; set; }

            /// <summary>
            /// 状态发生的时间
            /// </summary>
            [JsonPropertyName("status_time")]
            public string StatusTime { get; set; }

            /// <summary>
            /// 时间。。
            /// </summary>
            [JsonPropertyName("time")]
            public string Time { get; set; }

        }

    }

}

