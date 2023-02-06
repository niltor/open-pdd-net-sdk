namespace PddOpenSdk.Models.Response.Ddk;
public partial class ListDdkTmcActivityResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("tmc_aty_list_response")]
    public TmcAtyListResponseResponse TmcAtyListResponse { get; set; }
    public partial class TmcAtyListResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 实际查询的结束时间
        /// </summary>
        [JsonPropertyName("query_end_time")]
        public string QueryEndTime { get; set; }

        /// <summary>
        /// 实际查询的开始时间
        /// </summary>
        [JsonPropertyName("query_start_time")]
        public string QueryStartTime { get; set; }

        /// <summary>
        /// 千万神券活动列表
        /// </summary>
        [JsonPropertyName("tmc_aty_vo_list")]
        public List<TmcAtyVoListResponse> TmcAtyVoList { get; set; }

        /// <summary>
        /// 活动总数
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        public partial class TmcAtyVoListResponse : PddResponseModel
        {

            /// <summary>
            /// 活动结束时间
            /// </summary>
            [JsonPropertyName("end_time")]
            public string EndTime { get; set; }

            /// <summary>
            /// 神券活动编号 用于生链是传递
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 活动名称
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; }

            /// <summary>
            /// 活动开始时间
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; }

            /// <summary>
            /// 活动类型 1日常活动日 2品牌日
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

        }

    }

}

