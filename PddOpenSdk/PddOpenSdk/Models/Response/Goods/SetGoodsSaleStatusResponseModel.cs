using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsSaleStatusSetResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class SetGoodsSaleStatusResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("goods_sale_status_set_response")]
        public GoodsSaleStatusSetResponse GoodsSaleStatusSetResponse { get; set; }
    }


}
