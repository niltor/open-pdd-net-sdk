using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SetGoodsRelationResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_relation_set_response")]
        public object GoodsRelationSetResponse { get; set; }

        public partial class GoodsRelationSetResponseResponseModel : PddResponseModel
        {

        }

    }
}
