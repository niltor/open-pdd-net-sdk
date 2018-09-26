using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class UnitBaseInfoList
    {

        /// <summary>
        /// Examples: 5949471
        /// </summary>
        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        /// <summary>
        /// Examples: 10088079
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("unit_status")]
        public int UnitStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("keyword_count")]
        public int KeywordCount { get; set; }
    }

    public class AdUnitBaseInfoListResponse
    {

        /// <summary>
        /// Examples: [{"unit_id":5949471,"goods_id":10088079,"unit_status":1,"keyword_count":1}]
        /// </summary>
        [JsonProperty("unit_base_info_list")]
        public IList<UnitBaseInfoList> UnitBaseInfoList { get; set; }
    }

    public class IdAdUnitGetByPlanResponseModel
    {

        /// <summary>
        /// Examples: {"unit_base_info_list":[{"unit_id":5949471,"goods_id":10088079,"unit_status":1,"keyword_count":1}]}
        /// </summary>
        [JsonProperty("ad_unit_base_info_List_response")]
        public AdUnitBaseInfoListResponse AdUnitBaseInfoListResponse { get; set; }
    }


}
