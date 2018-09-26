using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class SkuList
    {

        /// <summary>
        /// Examples: "", "uu", "看看", "sdf "
        /// </summary>
        [JsonProperty("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// Examples: "6113246631", "6259240999", "6259290000", "6576701894"
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// Examples: "2", "1200", "1000", "0"
        /// </summary>
        [JsonProperty("sku_quantity")]
        public string SkuQuantity { get; set; }

        /// <summary>
        /// Examples: "", "345234", "345234423", "0"
        /// </summary>
        [JsonProperty("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("outer_goods_id")]
        public string OuterGoodsId { get; set; }

        /// <summary>
        /// Examples: "", "http://omsproductionimg.yangkeduo.com/images/2017-12-24/f9fcc9eb5bcda280047a865b4c2afbc7.jpeg", "http://omsproductionimg.yangkeduo.com/images/2017-12-24/7bb52691e45803a0ccfe4a2056d38b42.jpeg", "http://omsproductionimg.yangkeduo.com/images/2017-12-29/37a1bfe00611843d66891fc554d3a6e3.png"
        /// </summary>
        [JsonProperty("sku_img")]
        public string SkuImg { get; set; }

        /// <summary>
        /// Examples: "70.00", "6999.00"
        /// </summary>
        [JsonProperty("group_price")]
        public string GroupPrice { get; set; }

        /// <summary>
        /// Examples: "90.00", "70001.00", "9000.00"
        /// </summary>
        [JsonProperty("single_price")]
        public string SinglePrice { get; set; }

        /// <summary>
        /// Examples: "0", "1"
        /// </summary>
        [JsonProperty("is_sku_onsale")]
        public string IsSkuOnsale { get; set; }
    }

    public class GoodsInfo
    {

        /// <summary>
        /// Examples: "367872698"
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// Examples: "367872698"
        /// </summary>
        [JsonProperty("goods_sn")]
        public string GoodsSn { get; set; }

        /// <summary>
        /// Examples: "1"
        /// </summary>
        [JsonProperty("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// Examples: "数码电器"
        /// </summary>
        [JsonProperty("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// Examples: "智能机"
        /// </summary>
        [JsonProperty("last_category")]
        public string LastCategory { get; set; }

        /// <summary>
        /// Examples: "1"
        /// </summary>
        [JsonProperty("is_refundable")]
        public string IsRefundable { get; set; }

        /// <summary>
        /// Examples: "172800"
        /// </summary>
        [JsonProperty("shipment_limit_second")]
        public string ShipmentLimitSecond { get; set; }

        /// <summary>
        /// Examples: "9879我是一个棒棒哒商品哦哦哦哦飞天茅台"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Examples: 2202
        /// </summary>
        [JsonProperty("goods_quantity")]
        public int GoodsQuantity { get; set; }

        /// <summary>
        /// Examples: "0"
        /// </summary>
        [JsonProperty("is_onsale")]
        public string IsOnsale { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("second_hand")]
        public int SecondHand { get; set; }

        /// <summary>
        /// Examples: "2"
        /// </summary>
        [JsonProperty("group_required_customer_num")]
        public string GroupRequiredCustomerNum { get; set; }

        /// <summary>
        /// Examples: [{"spec":"","sku_id":"6113246631","sku_quantity":"2","outer_id":"","outer_goods_id":"","sku_img":"","group_price":"70.00","single_price":"90.00","is_sku_onsale":"0"},{"spec":"uu","sku_id":"6259240999","sku_quantity":"1200","outer_id":"345234","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-24/f9fcc9eb5bcda280047a865b4c2afbc7.jpeg","group_price":"6999.00","single_price":"70001.00","is_sku_onsale":"1"},{"spec":"看看","sku_id":"6259290000","sku_quantity":"1000","outer_id":"345234423","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-24/7bb52691e45803a0ccfe4a2056d38b42.jpeg","group_price":"6999.00","single_price":"9000.00","is_sku_onsale":"1"},{"spec":"sdf ","sku_id":"6576701894","sku_quantity":"0","outer_id":"0","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-29/37a1bfe00611843d66891fc554d3a6e3.png","group_price":"6999.00","single_price":"9000.00","is_sku_onsale":"1"}]
        /// </summary>
        [JsonProperty("sku_list")]
        public IList<SkuList> SkuList { get; set; }
    }

    public class GoodsInfoGetResponse
    {

        /// <summary>
        /// Examples: {"goods_id":"367872698","goods_sn":"367872698","goods_type":"1","goods_category":"数码电器","last_category":"智能机","is_refundable":"1","shipment_limit_second":"172800","goods_name":"9879我是一个棒棒哒商品哦哦哦哦飞天茅台","image_url":"","goods_quantity":2202,"is_onsale":"0","second_hand":0,"group_required_customer_num":"2","sku_list":[{"spec":"","sku_id":"6113246631","sku_quantity":"2","outer_id":"","outer_goods_id":"","sku_img":"","group_price":"70.00","single_price":"90.00","is_sku_onsale":"0"},{"spec":"uu","sku_id":"6259240999","sku_quantity":"1200","outer_id":"345234","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-24/f9fcc9eb5bcda280047a865b4c2afbc7.jpeg","group_price":"6999.00","single_price":"70001.00","is_sku_onsale":"1"},{"spec":"看看","sku_id":"6259290000","sku_quantity":"1000","outer_id":"345234423","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-24/7bb52691e45803a0ccfe4a2056d38b42.jpeg","group_price":"6999.00","single_price":"9000.00","is_sku_onsale":"1"},{"spec":"sdf ","sku_id":"6576701894","sku_quantity":"0","outer_id":"0","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-29/37a1bfe00611843d66891fc554d3a6e3.png","group_price":"6999.00","single_price":"9000.00","is_sku_onsale":"1"}]}
        /// </summary>
        [JsonProperty("goods_info")]
        public GoodsInfo GoodsInfo { get; set; }
    }

    public class GetGoodsInformationResponseModel
    {

        /// <summary>
        /// Examples: {"goods_info":{"goods_id":"367872698","goods_sn":"367872698","goods_type":"1","goods_category":"数码电器","last_category":"智能机","is_refundable":"1","shipment_limit_second":"172800","goods_name":"9879我是一个棒棒哒商品哦哦哦哦飞天茅台","image_url":"","goods_quantity":2202,"is_onsale":"0","second_hand":0,"group_required_customer_num":"2","sku_list":[{"spec":"","sku_id":"6113246631","sku_quantity":"2","outer_id":"","outer_goods_id":"","sku_img":"","group_price":"70.00","single_price":"90.00","is_sku_onsale":"0"},{"spec":"uu","sku_id":"6259240999","sku_quantity":"1200","outer_id":"345234","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-24/f9fcc9eb5bcda280047a865b4c2afbc7.jpeg","group_price":"6999.00","single_price":"70001.00","is_sku_onsale":"1"},{"spec":"看看","sku_id":"6259290000","sku_quantity":"1000","outer_id":"345234423","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-24/7bb52691e45803a0ccfe4a2056d38b42.jpeg","group_price":"6999.00","single_price":"9000.00","is_sku_onsale":"1"},{"spec":"sdf ","sku_id":"6576701894","sku_quantity":"0","outer_id":"0","outer_goods_id":"","sku_img":"http://omsproductionimg.yangkeduo.com/images/2017-12-29/37a1bfe00611843d66891fc554d3a6e3.png","group_price":"6999.00","single_price":"9000.00","is_sku_onsale":"1"}]}}
        /// </summary>
        [JsonProperty("goods_info_get_response")]
        public GoodsInfoGetResponse GoodsInfoGetResponse { get; set; }
    }


}
