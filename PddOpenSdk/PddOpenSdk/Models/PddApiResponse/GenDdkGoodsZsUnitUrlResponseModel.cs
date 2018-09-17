using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkGoodsZsUnitUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_zs_unit_generate_response")]
        public object GoodsZsUnitGenerateResponse { get; set; }

        public partial class GoodsZsUnitGenerateResponseResponseModel : PddResponseModel
        {

        }

    }
}
