using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Waybill
{
    public partial class GetCloudprintCustomaresResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_cloudprint_customares_get_response")]
        public PddCloudprintCustomaresGetResponseResponseModel PddCloudprintCustomaresGetResponse { get; set; }
        public partial class PddCloudprintCustomaresGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// result
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// datas
                /// </summary>
                [JsonProperty("datas")]
                public DatasResponseModel Datas { get; set; }
                public partial class DatasResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// custom_area_id
                    /// </summary>
                    [JsonProperty("custom_area_id")]
                    public int? CustomAreaId { get; set; }
                    /// <summary>
                    /// custom_area_name
                    /// </summary>
                    [JsonProperty("custom_area_name")]
                    public string CustomAreaName { get; set; }

                }

            }

        }

    }

}
