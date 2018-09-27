using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Erp
{
    public class OrderInfoItemList
    {

        /// <summary>
        /// Examples: "2525296157"
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// Examples: "51972265894"
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("outer_goods_id")]
        public string OuterGoodsId { get; set; }

        /// <summary>
        /// Examples: "全国联保只换不修必开发票测试"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: 11.01
        /// </summary>
        [JsonProperty("goods_price")]
        public double GoodsPrice { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("goods_spec")]
        public string GoodsSpec { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("goods_count")]
        public int GoodsCount { get; set; }

        /// <summary>
        /// Examples: "http://t00img.yangkeduo.com/goods/images/2018-08-05/30c20539280527dde161494efae95c41.jpeg"
        /// </summary>
        [JsonProperty("goods_img")]
        public string GoodsImg { get; set; }
    }

    public class OrderInfo
    {

        /// <summary>
        /// Examples: "180831-481803633911509"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: "2018-08-31 10:42:33"
        /// </summary>
        [JsonProperty("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// Examples: "展护卫"
        /// </summary>
        [JsonProperty("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Examples: "2018-08-31 10:42:33"
        /// </summary>
        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Examples: "中国"
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Examples: "上海市"
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// Examples: "上海市"
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Examples: "长宁区"
        /// </summary>
        [JsonProperty("town")]
        public string Town { get; set; }

        /// <summary>
        /// Examples: "上海市上海市长宁区娄山关路533号金虹桥国际中心28楼拼多多"
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Examples: "18667163376"
        /// </summary>
        [JsonProperty("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// Examples: 11.01
        /// </summary>
        [JsonProperty("pay_amount")]
        public double PayAmount { get; set; }

        /// <summary>
        /// Examples: 11.01
        /// </summary>
        [JsonProperty("goods_amount")]
        public double GoodsAmount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("discount_amount")]
        public int DiscountAmount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("postage")]
        public int Postage { get; set; }

        /// <summary>
        /// Examples: "4200000189201808312824969961"
        /// </summary>
        [JsonProperty("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// Examples: "WEIXIN"
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("id_card_num")]
        public string IdCardNum { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("id_card_name")]
        public string IdCardName { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("logistics_id")]
        public int LogisticsId { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("shipping_time")]
        public string ShippingTime { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("is_lucky_flag")]
        public int IsLuckyFlag { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("refund_status")]
        public int RefundStatus { get; set; }

        /// <summary>
        /// Examples: "2018-08-31 10:42:33"
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Examples: "2018-09-02 10:42:33"
        /// </summary>
        [JsonProperty("last_ship_time")]
        public string LastShipTime { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Examples: 25
        /// </summary>
        [JsonProperty("province_id")]
        public int ProvinceId { get; set; }

        /// <summary>
        /// Examples: 321
        /// </summary>
        [JsonProperty("city_id")]
        public int CityId { get; set; }

        /// <summary>
        /// Examples: 2703
        /// </summary>
        [JsonProperty("town_id")]
        public int TownId { get; set; }

        /// <summary>
        /// Examples: [{"goods_id":"2525296157","sku_id":"51972265894","outer_id":"","outer_goods_id":"","goods_name":"全国联保只换不修必开发票测试","goods_price":11.01,"goods_spec":"","goods_count":1,"goods_img":"http://t00img.yangkeduo.com/goods/images/2018-08-05/30c20539280527dde161494efae95c41.jpeg"}]
        /// </summary>
        [JsonProperty("item_list")]
        public IList<OrderInfoItemList> ItemList { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("platform_discount")]
        public int PlatformDiscount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("seller_discount")]
        public int SellerDiscount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("capital_free_discount")]
        public int CapitalFreeDiscount { get; set; }

        /// <summary>
        /// Examples: 6209
        /// </summary>
        [JsonProperty("cat_id_1")]
        public int CatId1 { get; set; }

        /// <summary>
        /// Examples: 6227
        /// </summary>
        [JsonProperty("cat_id_2")]
        public int CatId2 { get; set; }

        /// <summary>
        /// Examples: 6228
        /// </summary>
        [JsonProperty("cat_id_3")]
        public int CatId3 { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("cat_id_4")]
        public int CatId4 { get; set; }

        /// <summary>
        /// Examples: -1
        /// </summary>
        [JsonProperty("stock_out_handle_status")]
        public int StockOutHandleStatus { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("is_stock_out")]
        public int IsStockOut { get; set; }

        /// <summary>
        /// Examples: "XP0018083110200983094646005030"
        /// </summary>
        [JsonProperty("inner_transaction_id")]
        public string InnerTransactionId { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("buyer_memo")]
        public string BuyerMemo { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("invoice_status")]
        public int InvoiceStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("free_sf")]
        public int FreeSf { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("home_delivery_type")]
        public int HomeDeliveryType { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("after_sales_status")]
        public int AfterSalesStatus { get; set; }

        /// <summary>
        /// Examples: []
        /// </summary>
        [JsonProperty("card_info_list")]
        public IList<object> CardInfoList { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("is_pre_sale")]
        public int IsPreSale { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("pre_sale_time")]
        public string PreSaleTime { get; set; }
    }

    public class OrderInfoGetResponse
    {

        /// <summary>
        /// Examples: {"order_sn":"180831-481803633911509","confirm_time":"2018-08-31 10:42:33","receiver_name":"展护卫","created_time":"2018-08-31 10:42:33","country":"中国","province":"上海市","city":"上海市","town":"长宁区","address":"上海市上海市长宁区娄山关路533号金虹桥国际中心28楼拼多多","receiver_phone":"18667163376","pay_amount":11.01,"goods_amount":11.01,"discount_amount":0,"postage":0,"pay_no":"4200000189201808312824969961","pay_type":"WEIXIN","id_card_num":"","id_card_name":"","logistics_id":0,"tracking_number":"","shipping_time":"","order_status":1,"is_lucky_flag":1,"refund_status":1,"updated_at":"2018-08-31 10:42:33","last_ship_time":"2018-09-02 10:42:33","remark":"","receive_time":"","country_id":0,"province_id":25,"city_id":321,"town_id":2703,"item_list":[{"goods_id":"2525296157","sku_id":"51972265894","outer_id":"","outer_goods_id":"","goods_name":"全国联保只换不修必开发票测试","goods_price":11.01,"goods_spec":"","goods_count":1,"goods_img":"http://t00img.yangkeduo.com/goods/images/2018-08-05/30c20539280527dde161494efae95c41.jpeg"}],"platform_discount":0,"seller_discount":0,"capital_free_discount":0,"cat_id_1":6209,"cat_id_2":6227,"cat_id_3":6228,"cat_id_4":0,"stock_out_handle_status":-1,"is_stock_out":0,"inner_transaction_id":"XP0018083110200983094646005030","buyer_memo":"","invoice_status":0,"free_sf":1,"home_delivery_type":0,"after_sales_status":0,"card_info_list":[],"is_pre_sale":0,"pre_sale_time":""}
        /// </summary>
        [JsonProperty("order_info")]
        public OrderInfo OrderInfo { get; set; }
    }

    public class GetOrderInformationResponseModel
    {

        /// <summary>
        /// Examples: {"order_info":{"order_sn":"180831-481803633911509","confirm_time":"2018-08-31 10:42:33","receiver_name":"展护卫","created_time":"2018-08-31 10:42:33","country":"中国","province":"上海市","city":"上海市","town":"长宁区","address":"上海市上海市长宁区娄山关路533号金虹桥国际中心28楼拼多多","receiver_phone":"18667163376","pay_amount":11.01,"goods_amount":11.01,"discount_amount":0,"postage":0,"pay_no":"4200000189201808312824969961","pay_type":"WEIXIN","id_card_num":"","id_card_name":"","logistics_id":0,"tracking_number":"","shipping_time":"","order_status":1,"is_lucky_flag":1,"refund_status":1,"updated_at":"2018-08-31 10:42:33","last_ship_time":"2018-09-02 10:42:33","remark":"","receive_time":"","country_id":0,"province_id":25,"city_id":321,"town_id":2703,"item_list":[{"goods_id":"2525296157","sku_id":"51972265894","outer_id":"","outer_goods_id":"","goods_name":"全国联保只换不修必开发票测试","goods_price":11.01,"goods_spec":"","goods_count":1,"goods_img":"http://t00img.yangkeduo.com/goods/images/2018-08-05/30c20539280527dde161494efae95c41.jpeg"}],"platform_discount":0,"seller_discount":0,"capital_free_discount":0,"cat_id_1":6209,"cat_id_2":6227,"cat_id_3":6228,"cat_id_4":0,"stock_out_handle_status":-1,"is_stock_out":0,"inner_transaction_id":"XP0018083110200983094646005030","buyer_memo":"","invoice_status":0,"free_sf":1,"home_delivery_type":0,"after_sales_status":0,"card_info_list":[],"is_pre_sale":0,"pre_sale_time":""}}
        /// </summary>
        [JsonProperty("order_info_get_response")]
        public OrderInfoGetResponse OrderInfoGetResponse { get; set; }
    }


}
