using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsFabricContentList
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Examples: "96%及以上"
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }
    }

    public class GoodsFabricContentGetResponse
    {

        /// <summary>
        /// Examples: [{"code":1,"desc":"96%及以上"}]
        /// </summary>
        [JsonProperty("goods_fabric_content_list")]
        public IList<GoodsFabricContentList> GoodsFabricContentList { get; set; }
    }

    public class GetGoodsFabricContentResponseModel
    {

        /// <summary>
        /// Examples: {"goods_fabric_content_list":[{"code":1,"desc":"96%及以上"}]}
        /// </summary>
        [JsonProperty("goods_fabric_content_get_response")]
        public GoodsFabricContentGetResponse GoodsFabricContentGetResponse { get; set; }
    }


}
