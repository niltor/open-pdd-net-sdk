using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.WayBill
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
                public List<DatasResponseModel> Datas { get; set; }
                public partial class DatasResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// custom_area_id
                    /// </summary>
                    [JsonProperty("custom_area_id")]
                    public long? CustomAreaId { get; set; }
                    /// <summary>
                    /// custom_area_name
                    /// </summary>
                    [JsonProperty("custom_area_name")]
                    public string CustomAreaName { get; set; }
                    /// <summary>
                    /// custom_area_url
                    /// </summary>
                    [JsonProperty("custom_area_url")]
                    public string CustomAreaUrl { get; set; }
                    /// <summary>
                    /// keys
                    /// </summary>
                    [JsonProperty("keys")]
                    public List<object> Keys { get; set; }

                }

            }

        }

    }

}
