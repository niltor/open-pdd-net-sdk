using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsCountryResponseModel : PddResponseModel
    {
        /// <summary>
        /// 国家或地区对象列表
        /// </summary>
        [JsonProperty("country_list")]
        public CountryListResponseModel CountryList { get; set; }

        public partial class CountryListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 国家或地区对应的ID
            /// </summary>
            [JsonProperty("country_id")]
            public int CountryId { get; set; }
            /// <summary>
            /// 对应ID下的国家或地区名称
            /// </summary>
            [JsonProperty("country_name")]
            public string CountryName { get; set; }

        }

    }
}
