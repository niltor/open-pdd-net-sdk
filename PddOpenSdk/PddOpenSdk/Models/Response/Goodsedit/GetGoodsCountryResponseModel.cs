using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goodsedit
{
    public partial class GetGoodsCountryResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_country_get_response")]
        public GoodsCountryGetResponseResponseModel GoodsCountryGetResponse { get; set; }
        public partial class GoodsCountryGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 国家或地区对象列表
            /// </summary>
            [JsonProperty("country_list")]
            public List<CountryListResponseModel> CountryList { get; set; }
            public partial class CountryListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 国家或地区对应的ID
                /// </summary>
                [JsonProperty("country_id")]
                public long? CountryId { get; set; }
                /// <summary>
                /// 对应ID下的国家或地区名称
                /// </summary>
                [JsonProperty("country_name")]
                public string CountryName { get; set; }

            }

        }

    }

}
