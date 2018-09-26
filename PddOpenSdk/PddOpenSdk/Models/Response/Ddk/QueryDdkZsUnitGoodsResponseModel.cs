using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class ZsUnitGoodsQueryResponse
    {

        /// <summary>
        /// Examples: []
        /// </summary>
        [JsonProperty("list")]
        public IList<object> List { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class QueryDdkZsUnitGoodsResponseModel
    {

        /// <summary>
        /// Examples: {"list":[],"total_count":0}
        /// </summary>
        [JsonProperty("zs_unit_goods_query_response")]
        public ZsUnitGoodsQueryResponse ZsUnitGoodsQueryResponse { get; set; }
    }


}
