namespace PddOpenSdk.Models.Response.Ticket;
public partial class GetTicketScenicResponse : PddResponseModel
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
        [JsonPropertyName("area_list")]
        public List<AreaListResponse> AreaList { get; set; }
        public partial class AreaListResponse : PddResponseModel
        {

            /// <summary>
            /// 纬度
            /// </summary>
            [JsonPropertyName("latitude")]
            public double? Latitude { get; set; }

            /// <summary>
            /// 定位类型 1.百度 2.google
            /// </summary>
            [JsonPropertyName("location_type")]
            public int? LocationType { get; set; }

            /// <summary>
            /// 经度
            /// </summary>
            [JsonPropertyName("longitude")]
            public double? Longitude { get; set; }

            /// <summary>
            /// 拼多多景区编码
            /// </summary>
            [JsonPropertyName("scenic_id")]
            public long? ScenicId { get; set; }

            /// <summary>
            /// 拼多多景区名称
            /// </summary>
            [JsonPropertyName("scenic_name")]
            public string ScenicName { get; set; }

        }

    }

}

