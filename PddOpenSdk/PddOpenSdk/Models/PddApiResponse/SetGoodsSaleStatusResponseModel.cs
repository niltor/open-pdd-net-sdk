using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SetGoodsSaleStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("goods_sale_status_set_response")]
        public object GoodsSaleStatusSetResponse { get; set; }

        public partial class GoodsSaleStatusSetResponseResponseModel : PddResponseModel
        {

        }

    }
}
