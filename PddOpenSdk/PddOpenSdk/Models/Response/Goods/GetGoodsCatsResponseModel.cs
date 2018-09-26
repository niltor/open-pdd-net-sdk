using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsCatsList
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("cat_id")]
        public int CatId { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("parent_cat_id")]
        public int ParentCatId { get; set; }

        /// <summary>
        /// Examples: "服饰鞋包"
        /// </summary>
        [JsonProperty("cat_name")]
        public string CatName { get; set; }
    }

    public class GoodsCatsGetResponse
    {

        /// <summary>
        /// Examples: [{"level":1,"cat_id":1,"parent_cat_id":0,"cat_name":"服饰鞋包"}]
        /// </summary>
        [JsonProperty("goods_cats_list")]
        public IList<GoodsCatsList> GoodsCatsList { get; set; }
    }

    public class GetGoodsCatsResponseModel
    {

        /// <summary>
        /// Examples: {"goods_cats_list":[{"level":1,"cat_id":1,"parent_cat_id":0,"cat_name":"服饰鞋包"}]}
        /// </summary>
        [JsonProperty("goods_cats_get_response")]
        public GoodsCatsGetResponse GoodsCatsGetResponse { get; set; }
    }


}
