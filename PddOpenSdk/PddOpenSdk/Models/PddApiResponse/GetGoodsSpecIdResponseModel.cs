using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsSpecIdResponseModel : PddResponseModel
    {
        /// <summary>
        /// 生成规格响应对象
        /// </summary>
        [JsonProperty("goods_spec_id_get_response")]
        public object GoodsSpecIdGetResponse { get; set; }

        public partial class GoodsSpecIdGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
