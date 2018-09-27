using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Erp
{
    public class OrderItemList
    {

        /// <summary>
        /// Examples: "2542137428"
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// Examples: "52494558847"
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
        /// Examples: "文化用品 > 计算器 > 计算器【预售：8月18日发完】"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: 4.5
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
        /// Examples: "http://t00img.yangkeduo.com/goods/images/2018-08-07/a552b61fdb93031120ab1cf8ef0c44b6.jpeg"
        /// </summary>
        [JsonProperty("goods_img")]
        public string GoodsImg { get; set; }
    }

    public class OrderList
    {

        /// <summary>
        /// Examples: "180810-364770100011509"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: "2018-08-10 19:29:58"
        /// </summary>
        [JsonProperty("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// Examples: "展护卫"
        /// </summary>
        [JsonProperty("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Examples: "2018-08-10 19:29:58"
        /// </summary>
        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Examples: "中国"
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Examples: "北京市"
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// Examples: "北京市"
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Examples: "东城区"
        /// </summary>
        [JsonProperty("town")]
        public string Town { get; set; }

        /// <summary>
        /// Examples: "一号大街1号！"
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Examples: "1866716****"
        /// </summary>
        [JsonProperty("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// Examples: 4.5
        /// </summary>
        [JsonProperty("pay_amount")]
        public double PayAmount { get; set; }

        /// <summary>
        /// Examples: 4.5
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
        /// Examples: "2018081076041229"
        /// </summary>
        [JsonProperty("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// Examples: "LIANLIANPAY"
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
        /// Examples: 1
        /// </summary>
        [JsonProperty("logistics_id")]
        public int LogisticsId { get; set; }

        /// <summary>
        /// Examples: "111122223333"
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Examples: "2018-08-10 19:43:33"
        /// </summary>
        [JsonProperty("shipping_time")]
        public string ShippingTime { get; set; }

        /// <summary>
        /// Examples: 2
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
        /// Examples: "2018-08-10 19:43:34"
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Examples: "2018-08-18 23:59:59"
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
        /// Examples: 2
        /// </summary>
        [JsonProperty("province_id")]
        public int ProvinceId { get; set; }

        /// <summary>
        /// Examples: 52
        /// </summary>
        [JsonProperty("city_id")]
        public int CityId { get; set; }

        /// <summary>
        /// Examples: 500
        /// </summary>
        [JsonProperty("town_id")]
        public int TownId { get; set; }

        /// <summary>
        /// Examples: [{"goods_id":"2542137428","sku_id":"52494558847","outer_id":"","outer_goods_id":"","goods_name":"文化用品 > 计算器 > 计算器【预售：8月18日发完】","goods_price":4.5,"goods_spec":"","goods_count":1,"goods_img":"http://t00img.yangkeduo.com/goods/images/2018-08-07/a552b61fdb93031120ab1cf8ef0c44b6.jpeg"}]
        /// </summary>
        [JsonProperty("item_list")]
        public IList<OrderItemList> ItemList { get; set; }

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
        /// Examples: 2629
        /// </summary>
        [JsonProperty("cat_id_1")]
        public int CatId1 { get; set; }

        /// <summary>
        /// Examples: 2663
        /// </summary>
        [JsonProperty("cat_id_2")]
        public int CatId2 { get; set; }

        /// <summary>
        /// Examples: 2741
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
        /// Examples: "XP0018081019200664302889002657"
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
        [JsonProperty("is_pre_sale")]
        public int IsPreSale { get; set; }

        /// <summary>
        /// Examples: "2018-08-18 23:59:59"
        /// </summary>
        [JsonProperty("pre_sale_time")]
        public string PreSaleTime { get; set; }
    }

    public class OrderListGetResponse
    {

        /// <summary>
        /// Examples: [{"order_sn":"180810-364770100011509","confirm_time":"2018-08-10 19:29:58","receiver_name":"展护卫","created_time":"2018-08-10 19:29:58","country":"中国","province":"北京市","city":"北京市","town":"东城区","address":"一号大街1号！","receiver_phone":"1866716****","pay_amount":4.5,"goods_amount":4.5,"discount_amount":0,"postage":0,"pay_no":"2018081076041229","pay_type":"LIANLIANPAY","id_card_num":"","id_card_name":"","logistics_id":1,"tracking_number":"111122223333","shipping_time":"2018-08-10 19:43:33","order_status":2,"is_lucky_flag":1,"refund_status":1,"updated_at":"2018-08-10 19:43:34","last_ship_time":"2018-08-18 23:59:59","remark":"","receive_time":"","country_id":0,"province_id":2,"city_id":52,"town_id":500,"item_list":[{"goods_id":"2542137428","sku_id":"52494558847","outer_id":"","outer_goods_id":"","goods_name":"文化用品 > 计算器 > 计算器【预售：8月18日发完】","goods_price":4.5,"goods_spec":"","goods_count":1,"goods_img":"http://t00img.yangkeduo.com/goods/images/2018-08-07/a552b61fdb93031120ab1cf8ef0c44b6.jpeg"}],"platform_discount":0,"seller_discount":0,"capital_free_discount":0,"cat_id_1":2629,"cat_id_2":2663,"cat_id_3":2741,"cat_id_4":0,"stock_out_handle_status":-1,"is_stock_out":0,"inner_transaction_id":"XP0018081019200664302889002657","buyer_memo":"","invoice_status":0,"is_pre_sale":1,"pre_sale_time":"2018-08-18 23:59:59"}]
        /// </summary>
        [JsonProperty("order_list")]
        public IList<OrderList> OrderList { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GetOrderListResponseModel
    {

        /// <summary>
        /// Examples: {"order_list":[{"order_sn":"180810-364770100011509","confirm_time":"2018-08-10 19:29:58","receiver_name":"展护卫","created_time":"2018-08-10 19:29:58","country":"中国","province":"北京市","city":"北京市","town":"东城区","address":"一号大街1号！","receiver_phone":"1866716****","pay_amount":4.5,"goods_amount":4.5,"discount_amount":0,"postage":0,"pay_no":"2018081076041229","pay_type":"LIANLIANPAY","id_card_num":"","id_card_name":"","logistics_id":1,"tracking_number":"111122223333","shipping_time":"2018-08-10 19:43:33","order_status":2,"is_lucky_flag":1,"refund_status":1,"updated_at":"2018-08-10 19:43:34","last_ship_time":"2018-08-18 23:59:59","remark":"","receive_time":"","country_id":0,"province_id":2,"city_id":52,"town_id":500,"item_list":[{"goods_id":"2542137428","sku_id":"52494558847","outer_id":"","outer_goods_id":"","goods_name":"文化用品 > 计算器 > 计算器【预售：8月18日发完】","goods_price":4.5,"goods_spec":"","goods_count":1,"goods_img":"http://t00img.yangkeduo.com/goods/images/2018-08-07/a552b61fdb93031120ab1cf8ef0c44b6.jpeg"}],"platform_discount":0,"seller_discount":0,"capital_free_discount":0,"cat_id_1":2629,"cat_id_2":2663,"cat_id_3":2741,"cat_id_4":0,"stock_out_handle_status":-1,"is_stock_out":0,"inner_transaction_id":"XP0018081019200664302889002657","buyer_memo":"","invoice_status":0,"is_pre_sale":1,"pre_sale_time":"2018-08-18 23:59:59"}],"total_count":2}
        /// </summary>
        [JsonProperty("order_list_get_response")]
        public OrderListGetResponse OrderListGetResponse { get; set; }
    }


}
