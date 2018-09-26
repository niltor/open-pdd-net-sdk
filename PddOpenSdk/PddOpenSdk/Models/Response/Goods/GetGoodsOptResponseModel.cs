using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsOptList
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Examples: 1, 4, 12, 13
        /// </summary>
        [JsonProperty("opt_id")]
        public int OptId { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("parent_opt_id")]
        public int ParentOptId { get; set; }

        /// <summary>
        /// Examples: "年货", "母婴", "海淘", "水果"
        /// </summary>
        [JsonProperty("opt_name")]
        public string OptName { get; set; }
    }

    public class GoodsOptGetResponse
    {

        /// <summary>
        /// Examples: [{"level":1,"opt_id":1,"parent_opt_id":0,"opt_name":"年货"},{"level":1,"opt_id":4,"parent_opt_id":0,"opt_name":"母婴"},{"level":1,"opt_id":12,"parent_opt_id":0,"opt_name":"海淘"},{"level":1,"opt_id":13,"parent_opt_id":0,"opt_name":"水果"}]
        /// </summary>
        [JsonProperty("goods_opt_list")]
        public IList<GoodsOptList> GoodsOptList { get; set; }
    }

    public class GetGoodsOptResponseModel
    {

        /// <summary>
        /// Examples: {"goods_opt_list":[{"level":1,"opt_id":1,"parent_opt_id":0,"opt_name":"年货"},{"level":1,"opt_id":4,"parent_opt_id":0,"opt_name":"母婴"},{"level":1,"opt_id":12,"parent_opt_id":0,"opt_name":"海淘"},{"level":1,"opt_id":13,"parent_opt_id":0,"opt_name":"水果"}]}
        /// </summary>
        [JsonProperty("goods_opt_get_response")]
        public GoodsOptGetResponse GoodsOptGetResponse { get; set; }
    }


}
