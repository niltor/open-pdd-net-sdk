using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logistics
{
    public class LogisticsAddressList
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        /// <summary>
        /// Examples: "中国"
        /// </summary>
        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("region_type")]
        public int RegionType { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("national_code")]
        public string NationalCode { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("is_enabled")]
        public int IsEnabled { get; set; }
    }

    public class LogisticsAddressGetResponse
    {

        /// <summary>
        /// Examples: [{"id":1,"parent_id":0,"region_name":"中国","region_type":0,"national_code":"","is_enabled":1}]
        /// </summary>
        [JsonProperty("logistics_address_list")]
        public IList<LogisticsAddressList> LogisticsAddressList { get; set; }
    }

    public class GetLogisticsAddressResponseModel
    {

        /// <summary>
        /// Examples: {"logistics_address_list":[{"id":1,"parent_id":0,"region_name":"中国","region_type":0,"national_code":"","is_enabled":1}]}
        /// </summary>
        [JsonProperty("logistics_address_get_response")]
        public LogisticsAddressGetResponse LogisticsAddressGetResponse { get; set; }
    }


}
