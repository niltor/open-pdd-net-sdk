using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsCountryResponseModel : PddResponseModel
    {
        /// <summary>
        /// 国家或地区对象列表
        /// </summary>
        [JsonProperty("country_list")]
        public object CountryList { get; set; }

        public partial class CountryListResponseModel : PddResponseModel
        {

        }

    }
}
