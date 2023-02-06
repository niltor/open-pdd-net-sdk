namespace PddOpenSdk.Models.Request.Order;
public partial class AgreeRefundReturngoods
{

    /// <summary>
    /// 请求入参
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 售后id
        /// </summary>
        [JsonPropertyName("after_sales_id")]
        public long AfterSalesId { get; set; }

        /// <summary>
        /// 给用户留言
        /// </summary>
        [JsonPropertyName("operate_desc")]
        public string OperateDesc { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// 退货地址列表中已有的退货地址id
        /// </summary>
        [JsonPropertyName("return_address_id")]
        public string ReturnAddressId { get; set; }

    }

}

