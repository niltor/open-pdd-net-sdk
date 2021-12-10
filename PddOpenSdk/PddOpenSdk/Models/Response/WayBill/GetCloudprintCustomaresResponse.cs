namespace PddOpenSdk.Models.Response.WayBill;
public partial class GetCloudprintCustomaresResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_cloudprint_customares_get_response")]
    public PddCloudprintCustomaresGetResponseResponse PddCloudprintCustomaresGetResponse { get; set; }
    public partial class PddCloudprintCustomaresGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// datas
            /// </summary>
            [JsonPropertyName("datas")]
            public List<DatasResponse> Datas { get; set; }
            public partial class DatasResponse : PddResponseModel
            {

                /// <summary>
                /// custom_area_id
                /// </summary>
                [JsonPropertyName("custom_area_id")]
                public long? CustomAreaId { get; set; }

                /// <summary>
                /// custom_area_name
                /// </summary>
                [JsonPropertyName("custom_area_name")]
                public string CustomAreaName { get; set; }

                /// <summary>
                /// custom_area_url
                /// </summary>
                [JsonPropertyName("custom_area_url")]
                public string CustomAreaUrl { get; set; }

                /// <summary>
                /// keys
                /// </summary>
                [JsonPropertyName("keys")]
                public List<object> Keys { get; set; }

            }

        }

    }

}

