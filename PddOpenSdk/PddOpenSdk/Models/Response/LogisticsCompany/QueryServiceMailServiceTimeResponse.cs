namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class QueryServiceMailServiceTimeResponse : PddResponseModel
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
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("flag")]
        public bool? Flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("serviceTimes")]
        public List<ServiceTimesResponse> ServiceTimes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("serviceOptions")]
        public ServiceOptionsResponse ServiceOptions { get; set; }
        public partial class ServiceTimesResponse : PddResponseModel
        {

            /// <summary>
            /// 开始服务时间
            /// </summary>
            [JsonPropertyName("startTime")]
            public string StartTime { get; set; }

            /// <summary>
            /// 结束服务时间
            /// </summary>
            [JsonPropertyName("endTime")]
            public string EndTime { get; set; }

            /// <summary>
            /// 服务日期
            /// </summary>
            [JsonPropertyName("serviceDate")]
            public string ServiceDate { get; set; }

        }
        public partial class ServiceOptionsResponse : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("canSend")]
            public bool? CanSend { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("canReceivce")]
            public bool? CanReceivce { get; set; }

        }

    }

}

