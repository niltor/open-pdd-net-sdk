using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class SkuList
    {

        /// <summary>
        /// Examples: 1027220
        /// </summary>
        [JsonProperty("sku_id")]
        public int SkuId { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("is_onsale")]
        public int IsOnsale { get; set; }

        /// <summary>
        /// Examples: 999
        /// </summary>
        [JsonProperty("limit_quantity")]
        public int LimitQuantity { get; set; }

        /// <summary>
        /// Examples: 6600
        /// </summary>
        [JsonProperty("multi_price")]
        public int MultiPrice { get; set; }

        /// <summary>
        /// Examples: 8800
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Examples: 22
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Examples: []
        /// </summary>
        [JsonProperty("spec")]
        public IList<object> Spec { get; set; }

        /// <summary>
        /// Examples: "0"
        /// </summary>
        [JsonProperty("out_sku_sn")]
        public string OutSkuSn { get; set; }
    }

    public class GoodsDetailGetResponse
    {

        /// <summary>
        /// Examples: 10076234
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: 999999
        /// </summary>
        [JsonProperty("buy_limit")]
        public int BuyLimit { get; set; }

        /// <summary>
        /// Examples: ["http://pddtestimg.yangkeduo.com/test/2018-03-22/004a5cef31b92cbd8c0f4b8590de8910.jpeg"]
        /// </summary>
        [JsonProperty("carousel_gallery_list")]
        public IList<string> CarouselGalleryList { get; set; }

        /// <summary>
        /// Examples: 119
        /// </summary>
        [JsonProperty("cat_id")]
        public int CatId { get; set; }

        /// <summary>
        /// Examples: 6589
        /// </summary>
        [JsonProperty("cost_template_id")]
        public int CostTemplateId { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("customer_num")]
        public int CustomerNum { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }

        /// <summary>
        /// Examples: "dhdfhdfdjdfjdf二手"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: "山东公司的还是如何打发时间的房价大酒店附近的飞机的饭店附近"
        /// </summary>
        [JsonProperty("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("tiny_name")]
        public string TinyName { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("warehouse")]
        public string Warehouse { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("is_customs")]
        public int IsCustoms { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("customs")]
        public string Customs { get; set; }

        /// <summary>
        /// Examples: 9900
        /// </summary>
        [JsonProperty("market_price")]
        public int MarketPrice { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("is_pre_sale")]
        public int IsPreSale { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("pre_sale_time")]
        public int PreSaleTime { get; set; }

        /// <summary>
        /// Examples: 172800
        /// </summary>
        [JsonProperty("shipment_limit_second")]
        public int ShipmentLimitSecond { get; set; }

        /// <summary>
        /// Examples: 999999
        /// </summary>
        [JsonProperty("order_limit")]
        public int OrderLimit { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("is_refundable")]
        public int IsRefundable { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("is_folt")]
        public int IsFolt { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("warm_tips")]
        public string WarmTips { get; set; }

        /// <summary>
        /// Examples: [{"sku_id":1027220,"is_onsale":1,"limit_quantity":999,"multi_price":6600,"price":8800,"quantity":22,"weight":0,"thumb_url":"","spec":[],"out_sku_sn":"0"}]
        /// </summary>
        [JsonProperty("sku_list")]
        public IList<SkuList> SkuList { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2018-03-22/1af55a53e2a65b8d7dae2e1300ce622c.jpeg"
        /// </summary>
        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2018-03-22/63d96d232238e73412a0b4fdc23155d1.jpeg"
        /// </summary>
        [JsonProperty("hd_thumb_url")]
        public string HdThumbUrl { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Examples: ["http://pddtestimg.yangkeduo.com/test/2018-03-22/869ef81d26365bcaa26d3a332988123f.jpeg"]
        /// </summary>
        [JsonProperty("detail_gallery_list")]
        public IList<string> DetailGalleryList { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("outer_goods_id")]
        public string OuterGoodsId { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("second_hand")]
        public int SecondHand { get; set; }
    }

    public class GetGoodsDetailResponseModel
    {

        /// <summary>
        /// Examples: {"goods_id":10076234,"buy_limit":999999,"carousel_gallery_list":["http://pddtestimg.yangkeduo.com/test/2018-03-22/004a5cef31b92cbd8c0f4b8590de8910.jpeg"],"cat_id":119,"cost_template_id":6589,"country_id":0,"customer_num":2,"goods_type":1,"goods_name":"dhdfhdfdjdfjdf二手","goods_desc":"山东公司的还是如何打发时间的房价大酒店附近的飞机的饭店附近","tiny_name":"","warehouse":"","is_customs":0,"customs":"","market_price":9900,"is_pre_sale":0,"pre_sale_time":0,"shipment_limit_second":172800,"order_limit":999999,"is_refundable":1,"is_folt":1,"warm_tips":"","sku_list":[{"sku_id":1027220,"is_onsale":1,"limit_quantity":999,"multi_price":6600,"price":8800,"quantity":22,"weight":0,"thumb_url":"","spec":[],"out_sku_sn":"0"}],"thumb_url":"http://pddtestimg.yangkeduo.com/test/2018-03-22/1af55a53e2a65b8d7dae2e1300ce622c.jpeg","hd_thumb_url":"http://pddtestimg.yangkeduo.com/test/2018-03-22/63d96d232238e73412a0b4fdc23155d1.jpeg","image_url":"","detail_gallery_list":["http://pddtestimg.yangkeduo.com/test/2018-03-22/869ef81d26365bcaa26d3a332988123f.jpeg"],"outer_goods_id":"","second_hand":0}
        /// </summary>
        [JsonProperty("goods_detail_get_response")]
        public GoodsDetailGetResponse GoodsDetailGetResponse { get; set; }
    }


}
