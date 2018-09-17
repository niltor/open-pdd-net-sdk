using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetOrderNumberListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.order.number.list.get
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 发货状态，1：待发货  2：已发货待签收  3：已签收 5：全部 暂时只开放待发货订单查询
        /// </summary>
        [JsonProperty("order_status")]
        public object OrderStatus { get; set; }
        /// <summary>
        /// 返回数量，默认100。最大100
        /// </summary>
        [JsonProperty("page_size")]
        public object PageSize { get; set; }
        /// <summary>
        /// 返回页码 默认1，页码从1开始; PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用默认值
        /// </summary>
        [JsonProperty("page")]
        public object Page { get; set; }

    }
}
