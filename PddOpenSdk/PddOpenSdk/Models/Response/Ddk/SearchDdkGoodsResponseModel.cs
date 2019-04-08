using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class SearchDdkGoodsResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("goods_search_response")]
        public GoodsSearchResponseResponseModel GoodsSearchResponse { get; set; }
        public partial class GoodsSearchResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 商品列表
            /// </summary>
            [JsonProperty ("goods_list")]
            public List<GoodsListResponseModel> GoodsList { get; set; }
            /// <summary>
            /// 返回商品总数
            /// </summary>
            [JsonProperty ("total_count")]
            public int TotalCount { get; set; }
            public partial class GoodsListResponseModel : PddResponseModel {
                /// <summary>
                /// 是否有店铺券
                /// </summary>
                [JsonProperty ("has_mall_coupon")]
                public bool? HasMallCoupon { get; set; }
                /// <summary>
                /// 店铺券id
                /// </summary>
                [JsonProperty ("mall_coupon_id")]
                public long? MallCouponId { get; set; }
                /// <summary>
                /// 店铺券折扣
                /// </summary>
                [JsonProperty ("mall_coupon_discount_pct")]
                public int MallCouponDiscountPct { get; set; }
                /// <summary>
                /// 最小使用金额
                /// </summary>
                [JsonProperty ("mall_coupon_min_order_amount")]
                public int MallCouponMinOrderAmount { get; set; }
                /// <summary>
                /// 最大使用金额
                /// </summary>
                [JsonProperty ("mall_coupon_max_discount_amount")]
                public int MallCouponMaxDiscountAmount { get; set; }
                /// <summary>
                /// 店铺券总量
                /// </summary>
                [JsonProperty ("mall_coupon_total_quantity")]
                public long? MallCouponTotalQuantity { get; set; }
                /// <summary>
                /// 店铺券余量
                /// </summary>
                [JsonProperty ("mall_coupon_remain_quantity")]
                public long? MallCouponRemainQuantity { get; set; }
                /// <summary>
                /// 店铺券开始使用时间
                /// </summary>
                [JsonProperty ("mall_coupon_start_time")]
                public long? MallCouponStartTime { get; set; }
                /// <summary>
                /// 店铺券结束使用时间
                /// </summary>
                [JsonProperty ("mall_coupon_end_time")]
                public long? MallCouponEndTime { get; set; }
                /// <summary>
                /// 创建时间（unix时间戳）
                /// </summary>
                [JsonProperty ("create_at")]
                public long? CreateAt { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty ("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonProperty ("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品描述
                /// </summary>
                [JsonProperty ("goods_desc")]
                public string GoodsDesc { get; set; }
                /// <summary>
                /// 商品缩略图
                /// </summary>
                [JsonProperty ("goods_thumbnail_url")]
                public string GoodsThumbnailUrl { get; set; }
                /// <summary>
                /// 商品主图
                /// </summary>
                [JsonProperty ("goods_image_url")]
                public string GoodsImageUrl { get; set; }
                /// <summary>
                /// 商品轮播图
                /// </summary>
                [JsonProperty ("goods_gallery_urls")]
                public List<string> GoodsGalleryUrls { get; set; }
                /// <summary>
                /// 已售卖件数
                /// </summary>
                [JsonProperty ("sold_quantity")]
                public long? SoldQuantity { get; set; }
                /// <summary>
                /// 最小拼团价（单位为分）
                /// </summary>
                [JsonProperty ("min_group_price")]
                public long? MinGroupPrice { get; set; }
                /// <summary>
                /// 最小单买价格（单位为分）
                /// </summary>
                [JsonProperty ("min_normal_price")]
                public long? MinNormalPrice { get; set; }
                /// <summary>
                /// 店铺名字
                /// </summary>
                [JsonProperty ("mall_name")]
                public string MallName { get; set; }
                /// <summary>
                /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
                /// </summary>
                [JsonProperty ("merchant_type")]
                public int MerchantType { get; set; }
                /// <summary>
                /// 商品类目ID，使用pdd.goods.cats.get接口获取
                /// </summary>
                [JsonProperty ("category_id")]
                public long? CategoryId { get; set; }
                /// <summary>
                /// 商品类目名
                /// </summary>
                [JsonProperty ("category_name")]
                public string CategoryName { get; set; }
                /// <summary>
                /// 商品标签ID，使用pdd.goods.opts.get接口获取
                /// </summary>
                [JsonProperty ("opt_id")]
                public long? OptId { get; set; }
                /// <summary>
                /// 商品标签名
                /// </summary>
                [JsonProperty ("opt_name")]
                public string OptName { get; set; }
                /// <summary>
                /// 商品标签id
                /// </summary>
                [JsonProperty ("opt_ids")]
                public List<long?> OptIds { get; set; }
                /// <summary>
                /// 商品类目id
                /// </summary>
                [JsonProperty ("cat_ids")]
                public List<long?> CatIds { get; set; }
                /// <summary>
                /// 该商品所在店铺是否参与全店推广，0：否，1：是
                /// </summary>
                [JsonProperty ("mall_cps")]
                public int MallCps { get; set; }
                /// <summary>
                /// 商品是否有优惠券 true-有，false-没有
                /// </summary>
                [JsonProperty ("has_coupon")]
                public bool? HasCoupon { get; set; }
                /// <summary>
                /// 优惠券门槛价格，单位为分
                /// </summary>
                [JsonProperty ("coupon_min_order_amount")]
                public long? CouponMinOrderAmount { get; set; }
                /// <summary>
                /// 优惠券面额，单位为分
                /// </summary>
                [JsonProperty ("coupon_discount")]
                public long? CouponDiscount { get; set; }
                /// <summary>
                /// 优惠券总数量
                /// </summary>
                [JsonProperty ("coupon_total_quantity")]
                public long? CouponTotalQuantity { get; set; }
                /// <summary>
                /// 优惠券剩余数量
                /// </summary>
                [JsonProperty ("coupon_remain_quantity")]
                public long? CouponRemainQuantity { get; set; }
                /// <summary>
                /// 优惠券生效时间，UNIX时间戳
                /// </summary>
                [JsonProperty ("coupon_start_time")]
                public long? CouponStartTime { get; set; }
                /// <summary>
                /// 优惠券失效时间，UNIX时间戳
                /// </summary>
                [JsonProperty ("coupon_end_time")]
                public long? CouponEndTime { get; set; }
                /// <summary>
                /// 佣金比例，千分比
                /// </summary>
                [JsonProperty ("promotion_rate")]
                public long? PromotionRate { get; set; }
                /// <summary>
                /// 商品评价分
                /// </summary>
                [JsonProperty ("goods_eval_score")]
                public double? GoodsEvalScore { get; set; }
                /// <summary>
                /// 商品评价数量
                /// </summary>
                [JsonProperty ("goods_eval_count")]
                public long? GoodsEvalCount { get; set; }
                /// <summary>
                /// 描述评分
                /// </summary>
                [JsonProperty ("avg_desc")]
                public long? AvgDesc { get; set; }
                /// <summary>
                /// 物流评分
                /// </summary>
                [JsonProperty ("avg_lgst")]
                public long? AvgLgst { get; set; }
                /// <summary>
                /// 服务评分
                /// </summary>
                [JsonProperty ("avg_serv")]
                public long? AvgServ { get; set; }
                /// <summary>
                /// 描述分击败同类店铺百分比
                /// </summary>
                [JsonProperty ("desc_pct")]
                public double? DescPct { get; set; }
                /// <summary>
                /// 物流分击败同类店铺百分比
                /// </summary>
                [JsonProperty ("lgst_pct")]
                public double? LgstPct { get; set; }
                /// <summary>
                /// 服务分击败同类店铺百分比
                /// </summary>
                [JsonProperty ("serv_pct")]
                public double? ServPct { get; set; }

            }

        }

    }

}