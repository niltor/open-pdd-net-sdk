using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QueryDdkZsUnitGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("zs_unit_goods_query_response")]
        public object ZsUnitGoodsQueryResponse { get; set; }

        public partial class ZsUnitGoodsQueryResponseResponseModel : PddResponseModel
        {

        }

    }
}
