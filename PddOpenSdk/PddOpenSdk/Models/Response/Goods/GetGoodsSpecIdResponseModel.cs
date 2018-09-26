using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsSpecIdGetResponse
    {

        /// <summary>
        /// Examples: 1216
        /// </summary>
        [JsonProperty("parent_spec_id")]
        public int ParentSpecId { get; set; }

        /// <summary>
        /// Examples: "XL"
        /// </summary>
        [JsonProperty("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("spec_id")]
        public int SpecId { get; set; }
    }

    public class GetGoodsSpecIdResponseModel
    {

        /// <summary>
        /// Examples: {"parent_spec_id":1216,"spec_name":"XL","spec_id":2}
        /// </summary>
        [JsonProperty("goods_spec_id_get_response")]
        public GoodsSpecIdGetResponse GoodsSpecIdGetResponse { get; set; }
    }


}
