using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsOptResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("goods_opt_get_response")]
        public object GoodsOptGetResponse { get; set; }

        public partial class GoodsOptGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
