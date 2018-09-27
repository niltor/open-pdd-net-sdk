using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class SearchDdkGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 多多进宝商品对象列表
        /// </summary>
        [JsonProperty("goods_search_response")]
        public GoodsSearchResponse DuoduojinbaoGoodsList { get; set; }

        public partial class GoodsSearchResponse
        {
            [JsonProperty("goods_list")]
            public GoodsList[] GoodsList { get; set; }

            [JsonProperty("total_count")]
            public long TotalCount { get; set; }
        }

        public class GoodsList 
        {
            [JsonProperty("create_at")]
            public long CreateAt { get; set; }

            [JsonProperty("goods_id")]
            public long GoodsId { get; set; }

            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }

            [JsonProperty("goods_desc")]
            public object GoodsDesc { get; set; }

            [JsonProperty("goods_thumbnail_url")]
            public string GoodsThumbnailUrl { get; set; }

            [JsonProperty("goods_image_url")]
            public string GoodsImageUrl { get; set; }

            [JsonProperty("goods_gallery_urls")]
            public object GoodsGalleryUrls { get; set; }

            [JsonProperty("sold_quantity")]
            public long SoldQuantity { get; set; }

            [JsonProperty("min_group_price")]
            public long MinGroupPrice { get; set; }

            [JsonProperty("min_normal_price")]
            public long MinNormalPrice { get; set; }

            [JsonProperty("mall_name")]
            public string MallName { get; set; }

            [JsonProperty("merchant_type")]
            public long MerchantType { get; set; }

            [JsonProperty("category_id")]
            public long? CategoryId { get; set; }

            [JsonProperty("category_name")]
            public string CategoryName { get; set; }

            [JsonProperty("opt_id")]
            public long? OptId { get; set; }

            [JsonProperty("opt_name")]
            public string OptName { get; set; }

            [JsonProperty("opt_ids")]
            public long[] OptIds { get; set; }

            [JsonProperty("cat_ids")]
            public long[] CatIds { get; set; }

            [JsonProperty("mall_cps")]
            public long MallCps { get; set; }

            [JsonProperty("has_coupon")]
            public bool HasCoupon { get; set; }

            [JsonProperty("coupon_min_order_amount")]
            public long CouponMinOrderAmount { get; set; }

            [JsonProperty("coupon_discount")]
            public long CouponDiscount { get; set; }

            [JsonProperty("coupon_total_quantity")]
            public long CouponTotalQuantity { get; set; }

            [JsonProperty("coupon_remain_quantity")]
            public long CouponRemainQuantity { get; set; }

            [JsonProperty("coupon_start_time")]
            public long CouponStartTime { get; set; }

            [JsonProperty("coupon_end_time")]
            public long CouponEndTime { get; set; }

            [JsonProperty("promotion_rate")]
            public long PromotionRate { get; set; }

            [JsonProperty("goods_eval_score")]
            public double? GoodsEvalScore { get; set; }

            [JsonProperty("goods_eval_count")]
            public long GoodsEvalCount { get; set; }

            [JsonProperty("cat_id")]
            public object CatId { get; set; }

            [JsonProperty("avg_desc")]
            public long AvgDesc { get; set; }

            [JsonProperty("avg_lgst")]
            public long AvgLgst { get; set; }

            [JsonProperty("avg_serv")]
            public long AvgServ { get; set; }

            [JsonProperty("desc_pct")]
            public double? DescPct { get; set; }

            [JsonProperty("lgst_pct")]
            public double? LgstPct { get; set; }

            [JsonProperty("serv_pct")]
            public double? ServPct { get; set; }

        }

    }

}
