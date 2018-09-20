using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkMerchantListResponseModel : PddResponseModel
    {
        /// <summary>
        /// 店铺信息列表
        /// </summary>
        [JsonProperty("mall_search_info_vo_list")]
        public MallSearchInfoVoListResponseModel MallSearchInfoVoList { get; set; }
        /// <summary>
        /// 店铺券列表
        /// </summary>
        [JsonProperty("mall_coupon_info_list")]
        public MallCouponInfoListResponseModel MallCouponInfoList { get; set; }
        /// <summary>
        /// 商品详情列表
        /// </summary>
        [JsonProperty("goods_detail_vo_list")]
        public GoodsDetailVoListResponseModel GoodsDetailVoList { get; set; }

        public partial class MallSearchInfoVoListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品类目id列表
            /// </summary>
            [JsonProperty("cat_id_list")]
            public string CatIdList { get; set; }
            /// <summary>
            /// 店铺id
            /// </summary>
            [JsonProperty("mall_id")]
            public string MallId { get; set; }
            /// <summary>
            /// 店铺名字
            /// </summary>
            [JsonProperty("mall_name")]
            public string MallName { get; set; }
            /// <summary>
            /// 全店推广佣金比
            /// </summary>
            [JsonProperty("mall_rate")]
            public string MallRate { get; set; }
            /// <summary>
            /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
            /// </summary>
            [JsonProperty("merchant_type")]
            public int MerchantType { get; set; }
            /// <summary>
            /// 商品主图
            /// </summary>
            [JsonProperty("img_url")]
            public string ImgUrl { get; set; }
            /// <summary>
            /// 售卖数量
            /// </summary>
            [JsonProperty("sold_quantity")]
            public string SoldQuantity { get; set; }
            /// <summary>
            /// 商品数量
            /// </summary>
            [JsonProperty("goods_num")]
            public string GoodsNum { get; set; }
            /// <summary>
            /// 描述评分
            /// </summary>
            [JsonProperty("avg_desc")]
            public object AvgDesc { get; set; }
            /// <summary>
            /// 物流评分
            /// </summary>
            [JsonProperty("avg_lgst")]
            public object AvgLgst { get; set; }
            /// <summary>
            /// 服务评分
            /// </summary>
            [JsonProperty("avg_serv")]
            public object AvgServ { get; set; }
            /// <summary>
            /// 描述评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("desc_pct")]
            public object DescPct { get; set; }
            /// <summary>
            /// 物流评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("lgst_pct")]
            public object LgstPct { get; set; }
            /// <summary>
            /// 服务评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("serv_pct")]
            public object ServPct { get; set; }

        }

        public partial class MallCouponInfoListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 店铺id
            /// </summary>
            [JsonProperty("mall_id")]
            public string MallId { get; set; }
            /// <summary>
            /// 优惠券id
            /// </summary>
            [JsonProperty("coupon_id")]
            public string CouponId { get; set; }
            /// <summary>
            /// 优惠券类型（224是满减，225是折扣）
            /// </summary>
            [JsonProperty("coupon_type")]
            public string CouponType { get; set; }
            /// <summary>
            /// 折扣券，折扣力度 60/100 即6折；满减券，优惠券面额（单位为分 即60分）
            /// </summary>
            [JsonProperty("discount")]
            public string Discount { get; set; }
            /// <summary>
            /// 使用优惠券门槛金额
            /// </summary>
            [JsonProperty("min_order_amount")]
            public string MinOrderAmount { get; set; }
            /// <summary>
            /// 使用优惠券最高减的金额
            /// </summary>
            [JsonProperty("max_discount_amount")]
            public string MaxDiscountAmount { get; set; }
            /// <summary>
            /// 优惠券总数量
            /// </summary>
            [JsonProperty("coupon_quantity")]
            public string CouponQuantity { get; set; }
            /// <summary>
            /// 优惠券剩余数量
            /// </summary>
            [JsonProperty("coupon_remain_quantity")]
            public string CouponRemainQuantity { get; set; }
            /// <summary>
            /// 优惠券开始时间（unix时间戳）
            /// </summary>
            [JsonProperty("coupon_start_time")]
            public string CouponStartTime { get; set; }
            /// <summary>
            /// 优惠券结束时间（unix时间戳）
            /// </summary>
            [JsonProperty("coupon_end_time")]
            public string CouponEndTime { get; set; }

        }

        public partial class GoodsDetailVoListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 创建时间
            /// </summary>
            [JsonProperty("create_at")]
            public string CreateAt { get; set; }
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public string GoodsId { get; set; }
            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }
            /// <summary>
            /// 商品描述
            /// </summary>
            [JsonProperty("goods_desc")]
            public string GoodsDesc { get; set; }
            /// <summary>
            /// 商品缩略图
            /// </summary>
            [JsonProperty("goods_thumbnail_url")]
            public string GoodsThumbnailUrl { get; set; }
            /// <summary>
            /// 商品主图
            /// </summary>
            [JsonProperty("goods_image_url")]
            public string GoodsImageUrl { get; set; }
            /// <summary>
            /// 商品详情图
            /// </summary>
            [JsonProperty("goods_gallery_urls")]
            public string GoodsGalleryUrls { get; set; }
            /// <summary>
            /// 商品售卖件数
            /// </summary>
            [JsonProperty("sold_quantity")]
            public string SoldQuantity { get; set; }
            /// <summary>
            /// 商品最小成团价（单位为分）
            /// </summary>
            [JsonProperty("min_group_price")]
            public string MinGroupPrice { get; set; }
            /// <summary>
            /// 商品单买价（单位为分）
            /// </summary>
            [JsonProperty("min_normal_price")]
            public string MinNormalPrice { get; set; }
            /// <summary>
            /// 店铺名称
            /// </summary>
            [JsonProperty("mall_name")]
            public string MallName { get; set; }
            /// <summary>
            /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
            /// </summary>
            [JsonProperty("merchant_type")]
            public int MerchantType { get; set; }
            /// <summary>
            /// 商品类目
            /// </summary>
            [JsonProperty("category_id")]
            public string CategoryId { get; set; }
            /// <summary>
            /// 商品类目名
            /// </summary>
            [JsonProperty("category_name")]
            public string CategoryName { get; set; }
            /// <summary>
            /// 商品标签
            /// </summary>
            [JsonProperty("opt_id")]
            public string OptId { get; set; }
            /// <summary>
            /// 商品标签名
            /// </summary>
            [JsonProperty("opt_name")]
            public string OptName { get; set; }
            /// <summary>
            /// 商品标签列表
            /// </summary>
            [JsonProperty("opt_ids")]
            public string OptIds { get; set; }
            /// <summary>
            /// 商品类目列表
            /// </summary>
            [JsonProperty("cat_ids")]
            public string CatIds { get; set; }
            /// <summary>
            /// 商品所在店铺是否开通全店推广 0：否，1：是
            /// </summary>
            [JsonProperty("mall_cps")]
            public int MallCps { get; set; }
            /// <summary>
            /// 商品是否有优惠券（指单品券）
            /// </summary>
            [JsonProperty("has_coupon")]
            public bool HasCoupon { get; set; }
            /// <summary>
            /// 使用优惠券的门槛金额（单位为分）
            /// </summary>
            [JsonProperty("coupon_min_order_amount")]
            public string CouponMinOrderAmount { get; set; }
            /// <summary>
            /// 优惠券面额（单位为分）
            /// </summary>
            [JsonProperty("coupon_discount")]
            public string CouponDiscount { get; set; }
            /// <summary>
            /// 优惠券总数量
            /// </summary>
            [JsonProperty("coupon_total_quantity")]
            public string CouponTotalQuantity { get; set; }
            /// <summary>
            /// 优惠券剩余数量
            /// </summary>
            [JsonProperty("coupon_remain_quantity")]
            public string CouponRemainQuantity { get; set; }
            /// <summary>
            /// 优惠券开始时间
            /// </summary>
            [JsonProperty("coupon_start_time")]
            public string CouponStartTime { get; set; }
            /// <summary>
            /// 优惠券结束时间
            /// </summary>
            [JsonProperty("coupon_end_time")]
            public string CouponEndTime { get; set; }
            /// <summary>
            /// 佣金比（单位为分）
            /// </summary>
            [JsonProperty("promotion_rate")]
            public string PromotionRate { get; set; }
            /// <summary>
            /// 商品评分
            /// </summary>
            [JsonProperty("goods_eval_score")]
            public string GoodsEvalScore { get; set; }
            /// <summary>
            /// 商品评价数
            /// </summary>
            [JsonProperty("goods_eval_count")]
            public string GoodsEvalCount { get; set; }
            /// <summary>
            /// 类目id
            /// </summary>
            [JsonProperty("cat_id")]
            public string CatId { get; set; }
            /// <summary>
            /// 商品描述评分
            /// </summary>
            [JsonProperty("avg_desc")]
            public string AvgDesc { get; set; }
            /// <summary>
            /// 商品物流评分
            /// </summary>
            [JsonProperty("avg_lgst")]
            public string AvgLgst { get; set; }
            /// <summary>
            /// 商品服务评分
            /// </summary>
            [JsonProperty("avg_serv")]
            public string AvgServ { get; set; }
            /// <summary>
            /// 描述评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("desc_pct")]
            public string DescPct { get; set; }
            /// <summary>
            /// 物流评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("lgst_pct")]
            public string LgstPct { get; set; }
            /// <summary>
            /// 服务评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("serv_pct")]
            public string ServPct { get; set; }

        }

    }
}
