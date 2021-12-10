namespace PddOpenSdk.Models.Request.Refund;
public partial class AgreeRefund
{

    /// <summary>
    /// request
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
        /// 退款备注，商家留言
        /// </summary>
        [JsonPropertyName("operate_desc")]
        public string OperateDesc { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

    }

}

