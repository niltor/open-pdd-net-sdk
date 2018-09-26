using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class QueryGoodsRelationResponse
    {

        /// <summary>
        /// Examples: 2417899393, 2417899395, 2417899418
        /// </summary>
        [JsonProperty("pdd_goods_id")]
        public object PddGoodsId { get; set; }

        /// <summary>
        /// Examples: 0, 12
        /// </summary>
        [JsonProperty("out_goods_platform")]
        public int OutGoodsPlatform { get; set; }

        /// <summary>
        /// Examples: 1, 2
        /// </summary>
        [JsonProperty("out_goods_id")]
        public int OutGoodsId { get; set; }
    }

    public class RelationGoodsGetResponseModel
    {

        /// <summary>
        /// Examples: [{"pdd_goods_id":2417899393,"out_goods_platform":0,"out_goods_id":1},{"pdd_goods_id":2417899395,"out_goods_platform":0,"out_goods_id":1},{"pdd_goods_id":2417899418,"out_goods_platform":12,"out_goods_id":2}]
        /// </summary>
        [JsonProperty("query_goods_relation_response")]
        public IList<QueryGoodsRelationResponse> QueryGoodsRelationResponse { get; set; }
    }


}
