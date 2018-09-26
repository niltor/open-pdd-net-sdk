using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsSpecList
    {

        /// <summary>
        /// Examples: 1216
        /// </summary>
        [JsonProperty("parent_spec_id")]
        public int ParentSpecId { get; set; }

        /// <summary>
        /// Examples: "尺寸"
        /// </summary>
        [JsonProperty("parent_spec_name")]
        public string ParentSpecName { get; set; }

        /// <summary>
        /// Examples: 8
        /// </summary>
        [JsonProperty("cat_id")]
        public int CatId { get; set; }
    }

    public class GoodsSpecGetResponse
    {

        /// <summary>
        /// Examples: [{"parent_spec_id":1216,"parent_spec_name":"尺寸","cat_id":8}]
        /// </summary>
        [JsonProperty("goods_spec_list")]
        public IList<GoodsSpecList> GoodsSpecList { get; set; }
    }

    public class GetGoodsSpecResponseModel
    {

        /// <summary>
        /// Examples: {"goods_spec_list":[{"parent_spec_id":1216,"parent_spec_name":"尺寸","cat_id":8}]}
        /// </summary>
        [JsonProperty("goods_spec_get_response")]
        public GoodsSpecGetResponse GoodsSpecGetResponse { get; set; }
    }


}
