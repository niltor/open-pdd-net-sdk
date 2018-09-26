using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Refund
{
    public class RefundList
    {

        /// <summary>
        /// Examples: 301851299
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: "180410-416081954561509"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: "2018-04-10 17:01:23"
        /// </summary>
        [JsonProperty("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// Examples: "货物与描述不符"
        /// </summary>
        [JsonProperty("after_sale_reason")]
        public string AfterSaleReason { get; set; }

        /// <summary>
        /// Examples: 10
        /// </summary>
        [JsonProperty("after_sales_status")]
        public int AfterSalesStatus { get; set; }

        /// <summary>
        /// Examples: 3
        /// </summary>
        [JsonProperty("after_sales_type")]
        public int AfterSalesType { get; set; }

        /// <summary>
        /// Examples: "8.00"
        /// </summary>
        [JsonProperty("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// Examples: "8.00"
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// Examples: "13182332985"
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// Examples: "04"
        /// </summary>
        [JsonProperty("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("outer_goods_id")]
        public string OuterGoodsId { get; set; }

        /// <summary>
        /// Examples: "10.00"
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Examples: "18.00"
        /// </summary>
        [JsonProperty("goods_price")]
        public string GoodsPrice { get; set; }

        /// <summary>
        /// Examples: "1"
        /// </summary>
        [JsonProperty("goods_number")]
        public string GoodsNumber { get; set; }

        /// <summary>
        /// Examples: 863369485
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: "我是一个可爱的抱枕抱枕就是可爱的我我是一个可爱的抱枕抱枕--测试"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: "http://t01img.yangkeduo.com/images/2018-03-29/e42c3c4d05654c65ef5edc7f78f29be2.jpeg"
        /// </summary>
        [JsonProperty("good_image")]
        public string GoodImage { get; set; }

        /// <summary>
        /// Examples: "123456123456"
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Examples: "2018-04-10 17:03:29"
        /// </summary>
        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Examples: "2018-04-10 17:18:03"
        /// </summary>
        [JsonProperty("updated_time")]
        public string UpdatedTime { get; set; }
    }

    public class RefundIncrementGetResponse
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Examples: [{"id":301851299,"order_sn":"180410-416081954561509","confirm_time":"2018-04-10 17:01:23","after_sale_reason":"货物与描述不符","after_sales_status":10,"after_sales_type":3,"order_amount":"8.00","refund_amount":"8.00","sku_id":"13182332985","outer_id":"04","outer_goods_id":"","discount_amount":"10.00","goods_price":"18.00","goods_number":"1","goods_id":863369485,"goods_name":"我是一个可爱的抱枕抱枕就是可爱的我我是一个可爱的抱枕抱枕--测试","good_image":"http://t01img.yangkeduo.com/images/2018-03-29/e42c3c4d05654c65ef5edc7f78f29be2.jpeg","tracking_number":"123456123456","created_time":"2018-04-10 17:03:29","updated_time":"2018-04-10 17:18:03"}]
        /// </summary>
        [JsonProperty("refund_list")]
        public IList<RefundList> RefundList { get; set; }
    }

    public class GetRefundListIncrementResponseModel
    {

        /// <summary>
        /// Examples: {"total_count":1,"refund_list":[{"id":301851299,"order_sn":"180410-416081954561509","confirm_time":"2018-04-10 17:01:23","after_sale_reason":"货物与描述不符","after_sales_status":10,"after_sales_type":3,"order_amount":"8.00","refund_amount":"8.00","sku_id":"13182332985","outer_id":"04","outer_goods_id":"","discount_amount":"10.00","goods_price":"18.00","goods_number":"1","goods_id":863369485,"goods_name":"我是一个可爱的抱枕抱枕就是可爱的我我是一个可爱的抱枕抱枕--测试","good_image":"http://t01img.yangkeduo.com/images/2018-03-29/e42c3c4d05654c65ef5edc7f78f29be2.jpeg","tracking_number":"123456123456","created_time":"2018-04-10 17:03:29","updated_time":"2018-04-10 17:18:03"}]}
        /// </summary>
        [JsonProperty("refund_increment_get_response")]
        public RefundIncrementGetResponse RefundIncrementGetResponse { get; set; }
    }


}
