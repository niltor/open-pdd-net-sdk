using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class DdkMallGoodsList
    {
        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("create_at")]
        public object CreateAt { get; set; }

        /// <summary>
        /// Examples: 10080856
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: "婴儿代餐粉团长送礼"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_desc")]
        public object GoodsDesc { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2018-05-03/ed435a59a7767b66286ada3f51f1092f.jpeg"
        /// </summary>
        [JsonProperty("goods_thumbnail_url")]
        public string GoodsThumbnailUrl { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("goods_image_url")]
        public string GoodsImageUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_gallery_urls")]
        public object GoodsGalleryUrls { get; set; }

        /// <summary>
        /// Examples: 11
        /// </summary>
        [JsonProperty("sold_quantity")]
        public int SoldQuantity { get; set; }

        /// <summary>
        /// Examples: 20000
        /// </summary>
        [JsonProperty("goods_mark_price")]
        public int GoodsMarkPrice { get; set; }

        /// <summary>
        /// Examples: 15000
        /// </summary>
        [JsonProperty("goods_fact_price")]
        public int GoodsFactPrice { get; set; }

        /// <summary>
        /// Examples: 15000
        /// </summary>
        [JsonProperty("min_group_price")]
        public int MinGroupPrice { get; set; }

        /// <summary>
        /// Examples: 18000
        /// </summary>
        [JsonProperty("min_normal_price")]
        public int MinNormalPrice { get; set; }

        /// <summary>
        /// Examples: 7606022
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: "seven7"
        /// </summary>
        [JsonProperty("mall_name")]
        public string MallName { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("merchant_type")]
        public int MerchantType { get; set; }

        /// <summary>
        /// Examples: 4
        /// </summary>
        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Examples: "母婴"
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// Examples: 4
        /// </summary>
        [JsonProperty("opt_id")]
        public int OptId { get; set; }

        /// <summary>
        /// Examples: "母婴"
        /// </summary>
        [JsonProperty("opt_name")]
        public string OptName { get; set; }

        /// <summary>
        /// Examples: [19,4,889,11,12,220,335]
        /// </summary>
        [JsonProperty("opt_ids")]
        public IList<int> OptIds { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("cat_ids")]
        public object CatIds { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }

        /// <summary>
        /// Examples: false
        /// </summary>
        [JsonProperty("has_coupon")]
        public bool HasCoupon { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("coupon_id")]
        public object CouponId { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_min_order_amount")]
        public int CouponMinOrderAmount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_discount")]
        public int CouponDiscount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("coupon_total_quantity")]
        public object CouponTotalQuantity { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("coupon_remain_quantity")]
        public object CouponRemainQuantity { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("coupon_start_time")]
        public object CouponStartTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("coupon_end_time")]
        public object CouponEndTime { get; set; }

        /// <summary>
        /// Examples: 150
        /// </summary>
        [JsonProperty("promotion_rate")]
        public int PromotionRate { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_price")]
        public int CouponPrice { get; set; }

        /// <summary>
        /// Examples: 150
        /// </summary>
        [JsonProperty("goods_rate")]
        public int GoodsRate { get; set; }

        /// <summary>
        /// Examples: 2250
        /// </summary>
        [JsonProperty("market_fee")]
        public int MarketFee { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("mall_cps")]
        public int MallCps { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("goods_eval_score")]
        public int GoodsEvalScore { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("goods_eval_count")]
        public int GoodsEvalCount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("cat_id")]
        public object CatId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("share_desc")]
        public object ShareDesc { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("avg_desc")]
        public object AvgDesc { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("avg_lgst")]
        public object AvgLgst { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("avg_serv")]
        public object AvgServ { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("desc_pct")]
        public object DescPct { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("lgst_pct")]
        public object LgstPct { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("serv_pct")]
        public object ServPct { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("sale_num24")]
        public int SaleNum24 { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("sale_num_today")]
        public object SaleNumToday { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("rank")]
        public object Rank { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("broker")]
        public object Broker { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("lock_edit")]
        public object LockEdit { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("qr_code_image_url")]
        public object QrCodeImageUrl { get; set; }

        /// <summary>
        /// Examples: 150
        /// </summary>
        [JsonProperty("mall_rate")]
        public int MallRate { get; set; }
    }

    public class GoodsInfoListResponse
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"create_at":null,"goods_id":10080856,"goods_name":"婴儿代餐粉团长送礼","goods_desc":null,"goods_thumbnail_url":"http://pddtestimg.yangkeduo.com/test/2018-05-03/ed435a59a7767b66286ada3f51f1092f.jpeg","goods_image_url":"","goods_gallery_urls":null,"sold_quantity":11,"goods_mark_price":20000,"goods_fact_price":15000,"min_group_price":15000,"min_normal_price":18000,"mall_id":7606022,"mall_name":"seven7","merchant_type":1,"category_id":4,"category_name":"母婴","opt_id":4,"opt_name":"母婴","opt_ids":[19,4,889,11,12,220,335],"cat_ids":null,"goods_type":1,"has_coupon":false,"coupon_id":null,"coupon_min_order_amount":0,"coupon_discount":0,"coupon_total_quantity":null,"coupon_remain_quantity":null,"coupon_start_time":null,"coupon_end_time":null,"promotion_rate":150,"coupon_price":0,"goods_rate":150,"market_fee":2250,"mall_cps":1,"goods_eval_score":0,"goods_eval_count":0,"cat_id":null,"share_desc":null,"avg_desc":null,"avg_lgst":null,"avg_serv":null,"desc_pct":null,"lgst_pct":null,"serv_pct":null,"sale_num24":0,"sale_num_today":null,"rank":null,"broker":null,"lock_edit":null,"qr_code_image_url":null,"mall_rate":150}]
        /// </summary>
        [JsonProperty("goods_list")]
        public IList<DdkMallGoodsList> GoodsList { get; set; }
    }

    public class GetDdkMallGoodsListResponseModel
    {

        /// <summary>
        /// Examples: {"total":1,"goods_list":[{"create_at":null,"goods_id":10080856,"goods_name":"婴儿代餐粉团长送礼","goods_desc":null,"goods_thumbnail_url":"http://pddtestimg.yangkeduo.com/test/2018-05-03/ed435a59a7767b66286ada3f51f1092f.jpeg","goods_image_url":"","goods_gallery_urls":null,"sold_quantity":11,"goods_mark_price":20000,"goods_fact_price":15000,"min_group_price":15000,"min_normal_price":18000,"mall_id":7606022,"mall_name":"seven7","merchant_type":1,"category_id":4,"category_name":"母婴","opt_id":4,"opt_name":"母婴","opt_ids":[19,4,889,11,12,220,335],"cat_ids":null,"goods_type":1,"has_coupon":false,"coupon_id":null,"coupon_min_order_amount":0,"coupon_discount":0,"coupon_total_quantity":null,"coupon_remain_quantity":null,"coupon_start_time":null,"coupon_end_time":null,"promotion_rate":150,"coupon_price":0,"goods_rate":150,"market_fee":2250,"mall_cps":1,"goods_eval_score":0,"goods_eval_count":0,"cat_id":null,"share_desc":null,"avg_desc":null,"avg_lgst":null,"avg_serv":null,"desc_pct":null,"lgst_pct":null,"serv_pct":null,"sale_num24":0,"sale_num_today":null,"rank":null,"broker":null,"lock_edit":null,"qr_code_image_url":null,"mall_rate":150}]}
        /// </summary>
        [JsonProperty("goods_info_list_response")]
        public GoodsInfoListResponse GoodsInfoListResponse { get; set; }
    }


}
