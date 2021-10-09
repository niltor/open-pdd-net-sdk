namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsCountryResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_country_get_response")]
    public GoodsCountryGetResponseResponse GoodsCountryGetResponse { get; set; }
    public partial class GoodsCountryGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 国家或地区对象列表
        /// </summary>
        [JsonPropertyName("country_list")]
        public List<CountryListResponse> CountryList { get; set; }
        public partial class CountryListResponse : PddResponseModel
        {

            /// <summary>
            /// 国家或地区对应的ID
            /// </summary>
            [JsonPropertyName("country_id")]
            public long? CountryId { get; set; }

            /// <summary>
            /// 对应ID下的国家或地区名称
            /// </summary>
            [JsonPropertyName("country_name")]
            public string CountryName { get; set; }

        }

    }

}

