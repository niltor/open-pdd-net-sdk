using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsCatsList
    {

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("cat_id")]
        public int CatId { get; set; }

        /// <summary>
        /// Examples: "食品饮料"
        /// </summary>
        [JsonProperty("cat_name")]
        public string CatName { get; set; }
    }

    public class GoodsAuthCatsGetResponse
    {

        /// <summary>
        /// Examples: [{"cat_id":2,"cat_name":"食品饮料"}]
        /// </summary>
        [JsonProperty("goods_cats_list")]
        public IList<GoodsCatsList> GoodsCatsList { get; set; }
    }

    public class CatsGoodsAuthorizationResponseModel
    {

        /// <summary>
        /// Examples: {"goods_cats_list":[{"cat_id":2,"cat_name":"食品饮料"}]}
        /// </summary>
        [JsonProperty("goods_auth_cats_get_response")]
        public GoodsAuthCatsGetResponse GoodsAuthCatsGetResponse { get; set; }
    }


}
