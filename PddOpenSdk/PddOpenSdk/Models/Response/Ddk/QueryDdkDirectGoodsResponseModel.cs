using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class List
    {

        /// <summary>
        /// Examples: 55253387
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: "透明收纳箱塑料衣柜透明小号收纳盒加厚衣服收纳筐被子玩具收纳"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_desc")]
        public object GoodsDesc { get; set; }

        /// <summary>
        /// Examples: "http://t00img.yangkeduo.com/t02img/images/2018-06-12/0a2e2eff45a83a03b74c4e11cd3ef767.jpeg"
        /// </summary>
        [JsonProperty("goods_thumbnail_url")]
        public string GoodsThumbnailUrl { get; set; }

        /// <summary>
        /// Examples: "http://omsproductionimg.yangkeduo.com/images/2018-01-11/83f050deeb74799aad496e6b2f7e6c01.jpeg"
        /// </summary>
        [JsonProperty("goods_image_url")]
        public string GoodsImageUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_gallery_urls")]
        public object GoodsGalleryUrls { get; set; }

        /// <summary>
        /// Examples: 41346
        /// </summary>
        [JsonProperty("sold_quantity")]
        public int SoldQuantity { get; set; }

        /// <summary>
        /// Examples: 550
        /// </summary>
        [JsonProperty("goods_fact_price")]
        public int GoodsFactPrice { get; set; }

        /// <summary>
        /// Examples: 550
        /// </summary>
        [JsonProperty("min_group_price")]
        public int MinGroupPrice { get; set; }

        /// <summary>
        /// Examples: 750
        /// </summary>
        [JsonProperty("min_normal_price")]
        public int MinNormalPrice { get; set; }

        /// <summary>
        /// Examples: "简梦恒泽专卖店"
        /// </summary>
        [JsonProperty("mall_name")]
        public string MallName { get; set; }

        /// <summary>
        /// Examples: 12
        /// </summary>
        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Examples: "海淘"
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// Examples: 12
        /// </summary>
        [JsonProperty("opt_id")]
        public int OptId { get; set; }

        /// <summary>
        /// Examples: "海淘"
        /// </summary>
        [JsonProperty("opt_name")]
        public string OptName { get; set; }

        /// <summary>
        /// Examples: [519,521,761,0]
        /// </summary>
        [JsonProperty("cat_ids")]
        public IList<int> CatIds { get; set; }

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("has_coupon")]
        public bool HasCoupon { get; set; }

        /// <summary>
        /// Examples: 78508062
        /// </summary>
        [JsonProperty("coupon_id")]
        public int CouponId { get; set; }

        /// <summary>
        /// Examples: 300
        /// </summary>
        [JsonProperty("coupon_min_order_amount")]
        public int CouponMinOrderAmount { get; set; }

        /// <summary>
        /// Examples: 300
        /// </summary>
        [JsonProperty("coupon_discount")]
        public int CouponDiscount { get; set; }

        /// <summary>
        /// Examples: 111
        /// </summary>
        [JsonProperty("coupon_total_quantity")]
        public int CouponTotalQuantity { get; set; }

        /// <summary>
        /// Examples: 111
        /// </summary>
        [JsonProperty("coupon_remain_quantity")]
        public int CouponRemainQuantity { get; set; }

        /// <summary>
        /// Examples: 1529424000
        /// </summary>
        [JsonProperty("coupon_start_time")]
        public int CouponStartTime { get; set; }

        /// <summary>
        /// Examples: 1529596799
        /// </summary>
        [JsonProperty("coupon_end_time")]
        public int CouponEndTime { get; set; }

        /// <summary>
        /// Examples: 900
        /// </summary>
        [JsonProperty("promotion_rate")]
        public int PromotionRate { get; set; }

        /// <summary>
        /// Examples: 300
        /// </summary>
        [JsonProperty("coupon_price")]
        public int CouponPrice { get; set; }

        /// <summary>
        /// Examples: 900
        /// </summary>
        [JsonProperty("goods_rate")]
        public int GoodsRate { get; set; }

        /// <summary>
        /// Examples: 4.7
        /// </summary>
        [JsonProperty("goods_eval_score")]
        public double GoodsEvalScore { get; set; }

        /// <summary>
        /// Examples: 257
        /// </summary>
        [JsonProperty("goods_eval_count")]
        public int GoodsEvalCount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("cat_id")]
        public object CatId { get; set; }

        /// <summary>
        /// Examples: 491
        /// </summary>
        [JsonProperty("avg_desc")]
        public int AvgDesc { get; set; }

        /// <summary>
        /// Examples: 482
        /// </summary>
        [JsonProperty("avg_lgst")]
        public int AvgLgst { get; set; }

        /// <summary>
        /// Examples: 480
        /// </summary>
        [JsonProperty("avg_serv")]
        public int AvgServ { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("sale_num24")]
        public object SaleNum24 { get; set; }
    }

    public class DirectGoodsQueryResponse
    {

        /// <summary>
        /// Examples: [{"goods_id":55253387,"goods_name":"透明收纳箱塑料衣柜透明小号收纳盒加厚衣服收纳筐被子玩具收纳","goods_desc":null,"goods_thumbnail_url":"http://t00img.yangkeduo.com/t02img/images/2018-06-12/0a2e2eff45a83a03b74c4e11cd3ef767.jpeg","goods_image_url":"http://omsproductionimg.yangkeduo.com/images/2018-01-11/83f050deeb74799aad496e6b2f7e6c01.jpeg","goods_gallery_urls":null,"sold_quantity":41346,"goods_fact_price":550,"min_group_price":550,"min_normal_price":750,"mall_name":"简梦恒泽专卖店","category_id":12,"category_name":"海淘","opt_id":12,"opt_name":"海淘","cat_ids":[519,521,761,0],"has_coupon":true,"coupon_id":78508062,"coupon_min_order_amount":300,"coupon_discount":300,"coupon_total_quantity":111,"coupon_remain_quantity":111,"coupon_start_time":1529424000,"coupon_end_time":1529596799,"promotion_rate":900,"coupon_price":300,"goods_rate":900,"goods_eval_score":4.7,"goods_eval_count":257,"cat_id":null,"avg_desc":491,"avg_lgst":482,"avg_serv":480,"sale_num24":null}]
        /// </summary>
        [JsonProperty("list")]
        public IList<List> List { get; set; }

        /// <summary>
        /// Examples: 3
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class QueryDdkDirectGoodsResponseModel
    {

        /// <summary>
        /// Examples: {"list":[{"goods_id":55253387,"goods_name":"透明收纳箱塑料衣柜透明小号收纳盒加厚衣服收纳筐被子玩具收纳","goods_desc":null,"goods_thumbnail_url":"http://t00img.yangkeduo.com/t02img/images/2018-06-12/0a2e2eff45a83a03b74c4e11cd3ef767.jpeg","goods_image_url":"http://omsproductionimg.yangkeduo.com/images/2018-01-11/83f050deeb74799aad496e6b2f7e6c01.jpeg","goods_gallery_urls":null,"sold_quantity":41346,"goods_fact_price":550,"min_group_price":550,"min_normal_price":750,"mall_name":"简梦恒泽专卖店","category_id":12,"category_name":"海淘","opt_id":12,"opt_name":"海淘","cat_ids":[519,521,761,0],"has_coupon":true,"coupon_id":78508062,"coupon_min_order_amount":300,"coupon_discount":300,"coupon_total_quantity":111,"coupon_remain_quantity":111,"coupon_start_time":1529424000,"coupon_end_time":1529596799,"promotion_rate":900,"coupon_price":300,"goods_rate":900,"goods_eval_score":4.7,"goods_eval_count":257,"cat_id":null,"avg_desc":491,"avg_lgst":482,"avg_serv":480,"sale_num24":null}],"total_count":3}
        /// </summary>
        [JsonProperty("direct_goods_query_response")]
        public DirectGoodsQueryResponse DirectGoodsQueryResponse { get; set; }
    }


}
