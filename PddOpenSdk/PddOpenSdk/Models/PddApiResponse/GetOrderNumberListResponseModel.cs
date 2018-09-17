using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetOrderNumberListResponseModel : PddResponseModel
    {
        /// <summary>
        /// 订单全量列表响应对象
        /// </summary>
        [JsonProperty("order_sn_list_get_response")]
        public object OrderSnListGetResponse { get; set; }

        public partial class OrderSnListGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
