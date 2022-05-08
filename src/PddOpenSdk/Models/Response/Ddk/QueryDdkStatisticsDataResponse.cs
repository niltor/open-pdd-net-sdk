namespace PddOpenSdk.Models.Response.Ddk;
public partial class QueryDdkStatisticsDataResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("statistics_data_response")]
    public StatisticsDataResponseResponse StatisticsDataResponse { get; set; }
    public partial class StatisticsDataResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<DataListResponse> DataList { get; set; }
        public partial class DataListResponse : PddResponseModel
        {

            /// <summary>
            /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。（如果使用GET请求，请使用URLEncode处理参数）
            /// </summary>
            [JsonPropertyName("custom_parameters")]
            public string CustomParameters { get; set; }

            /// <summary>
            /// 结束时间，格式: "yyyy-MM-dd"
            /// </summary>
            [JsonPropertyName("end_time")]
            public string EndTime { get; set; }

            /// <summary>
            /// GMV,单位为分
            /// </summary>
            [JsonPropertyName("order_amount")]
            public long? OrderAmount { get; set; }

            /// <summary>
            /// 订单数
            /// </summary>
            [JsonPropertyName("order_num")]
            public long? OrderNum { get; set; }

            /// <summary>
            /// 推广位ID
            /// </summary>
            [JsonPropertyName("p_id")]
            public string PId { get; set; }

            /// <summary>
            /// 开始时间，格式: "yyyy-MM-dd"
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; }

        }

    }

}

