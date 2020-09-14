using System.Collections.Generic;
using Newtonsoft.Json;
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
                /// 
                /// </summary>
                [JsonProperty("datas")]
                public List<DatasResponseModel> Datas { get; set; }
                public partial class DatasResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("custom_area_id")]
                    public int? CustomAreaId { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("custom_area_name")]
                    public string CustomAreaName { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("custom_area_url")]
                    public string CustomAreaUrl { get; set; }
                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonProperty("keys")]
                    public List<KeysResponseModel> Keys { get; set; }
                    public partial class KeysResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 
                        /// </summary>
                        [JsonProperty("key_name")]
                        public string KeyName { get; set; }

                    }

                }

            }

        }

    }

}
