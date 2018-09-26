using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsFabricList
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Examples: "棉"
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }
    }

    public class GoodsFabricGetResponse
    {

        /// <summary>
        /// Examples: [{"code":1,"desc":"棉"}]
        /// </summary>
        [JsonProperty("goods_fabric_list")]
        public IList<GoodsFabricList> GoodsFabricList { get; set; }
    }

    public class GetGoodsFabricResponseModel
    {

        /// <summary>
        /// Examples: {"goods_fabric_list":[{"code":1,"desc":"棉"}]}
        /// </summary>
        [JsonProperty("goods_fabric_get_response")]
        public GoodsFabricGetResponse GoodsFabricGetResponse { get; set; }
    }


}
