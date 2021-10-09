namespace PddOpenSdk.Models.Response.Ad;
public partial class ProfileAdApiUnitBidQueryBaseLocationResponse : PddResponseModel
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
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 资源位描述
            /// </summary>
            [JsonPropertyName("locationName")]
            public string LocationName { get; set; }

            /// <summary>
            /// 资源位类型
            /// </summary>
            [JsonPropertyName("locationType")]
            public int? LocationType { get; set; }

            /// <summary>
            /// 资源位预估人群
            /// </summary>
            [JsonPropertyName("pvString")]
            public string PvString { get; set; }

        }

    }

}

