using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class CountryList
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Examples: "安道尔"
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }
    }

    public class GoodsCountryGetResponse
    {

        /// <summary>
        /// Examples: [{"country_id":1,"country_name":"安道尔"}]
        /// </summary>
        [JsonProperty("country_list")]
        public IList<CountryList> CountryList { get; set; }
    }

    public class GetGoodsCountryResponseModel
    {

        /// <summary>
        /// Examples: {"country_list":[{"country_id":1,"country_name":"安道尔"}]}
        /// </summary>
        [JsonProperty("goods_country_get_response")]
        public GoodsCountryGetResponse GoodsCountryGetResponse { get; set; }
    }


}
