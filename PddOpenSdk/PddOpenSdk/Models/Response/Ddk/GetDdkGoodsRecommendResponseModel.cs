using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GetDdkGoodsRecommendResponseModel : PddResponseModel
    {
        /// <summary>
        /// goods_basic_detail_response
        /// </summary>
        [JsonProperty("goods_basic_detail_response")]
        public GoodsBasicDetailResponseResponseModel GoodsBasicDetailResponse { get; set; }
        public partial class GoodsBasicDetailResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// total
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            /// <summary>
            /// 列表
            /// </summary>
            [JsonProperty("list")]
            public List<ListResponseModel> List { get; set; }
            public partial class ListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 二维码主图
                /// </summary>
                [JsonProperty("qr_code_image_url")]
                public string QrCodeImageUrl { get; set; }
                /// <summary>
                /// 分享描述
                /// </summary>
                [JsonProperty("share_desc")]
                public string ShareDesc { get; set; }
                /// <summary>
                /// 商品类目id
                /// </summary>
                [JsonProperty("cat_id")]
                public string CatId { get; set; }
                /// <summary>
                /// 商品评价数量
                /// </summary>
                [JsonProperty("goods_eval_count")]
                public long? GoodsEvalCount { get; set; }
                /// <summary>
                /// 市场服务费
                /// </summary>
                [JsonProperty("market_fee")]
                public long? MarketFee { get; set; }
                /// <summary>
                /// 商品等级
                /// </summary>
                [JsonProperty("goods_rate")]
                public long? GoodsRate { get; set; }
                /// <summary>
                /// 优惠券金额
                /// </summary>
                [JsonProperty("coupon_price")]
                public long? CouponPrice { get; set; }
                /// <summary>
                /// 佣金比例,千分比
                /// </summary>
                [JsonProperty("promotion_rate")]
                public long? PromotionRate { get; set; }
                /// <summary>
                /// 优惠券失效时间,UNIX时间戳
                /// </summary>
                [JsonProperty("coupon_end_time")]
                public long? CouponEndTime { get; set; }
                /// <summary>
                /// 优惠券生效时间,UNIX时间戳
                /// </summary>
                [JsonProperty("coupon_start_time")]
                public long? CouponStartTime { get; set; }
                /// <summary>
                /// 优惠券剩余数量
                /// </summary>
                [JsonProperty("coupon_remain_quantity")]
                public long? CouponRemainQuantity { get; set; }
                /// <summary>
                /// 优惠券总数量
                /// </summary>
                [JsonProperty("coupon_total_quantity")]
                public long? CouponTotalQuantity { get; set; }
                /// <summary>
                /// 优惠券面额,单位为分
                /// </summary>
                [JsonProperty("coupon_discount")]
                public long? CouponDiscount { get; set; }
                /// <summary>
                /// 优惠券门槛价格,单位为分
                /// </summary>
                [JsonProperty("coupon_min_order_amount")]
                public long? CouponMinOrderAmount { get; set; }
                /// <summary>
                /// 优惠券id
                /// </summary>
                [JsonProperty("coupon_id")]
                public long? CouponId { get; set; }
                /// <summary>
                /// 商品是否带券,true-带券,false-不带券
                /// </summary>
                [JsonProperty("has_coupon")]
                public bool? HasCoupon { get; set; }
                /// <summary>
                /// 商品类型
                /// </summary>
                [JsonProperty("goods_type")]
                public int? GoodsType { get; set; }
                /// <summary>
                /// 商品一~四级类目ID列表
                /// </summary>
                [JsonProperty("cat_ids")]
                public List<long?> CatIds { get; set; }
                /// <summary>
                /// 商品一~四级标签类目ID列表
                /// </summary>
                [JsonProperty("opt_ids")]
                public List<long?> OptIds { get; set; }
                /// <summary>
                /// 商品标签名
                /// </summary>
                [JsonProperty("opt_name")]
                public string OptName { get; set; }
                /// <summary>
                /// 商品标签类目ID,使用pdd.goods.opt.get获取
                /// </summary>
                [JsonProperty("opt_id")]
                public string OptId { get; set; }
                /// <summary>
                /// 分类名称
                /// </summary>
                [JsonProperty("category_name")]
                public string CategoryName { get; set; }
                /// <summary>
                /// 类目id
                /// </summary>
                [JsonProperty("category_id")]
                public string CategoryId { get; set; }
                /// <summary>
                /// 商家类型
                /// </summary>
                [JsonProperty("merchant_type")]
                public string MerchantType { get; set; }
                /// <summary>
                /// 店铺名称
                /// </summary>
                [JsonProperty("mall_name")]
                public string MallName { get; set; }
                /// <summary>
                /// 商家id
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 最小单买价格，单位分
                /// </summary>
                [JsonProperty("min_normal_price")]
                public long? MinNormalPrice { get; set; }
                /// <summary>
                /// 最小成团价格，单位分
                /// </summary>
                [JsonProperty("min_group_price")]
                public long? MinGroupPrice { get; set; }
                /// <summary>
                /// 商品实际价格
                /// </summary>
                [JsonProperty("goods_fact_price")]
                public long? GoodsFactPrice { get; set; }
                /// <summary>
                /// 商品标准价格
                /// </summary>
                [JsonProperty("goods_mark_price")]
                public long? GoodsMarkPrice { get; set; }
                /// <summary>
                /// 商品详情图列表
                /// </summary>
                [JsonProperty("goods_gallery_urls")]
                public string GoodsGalleryUrls { get; set; }
                /// <summary>
                /// 商品主图
                /// </summary>
                [JsonProperty("goods_image_url")]
                public string GoodsImageUrl { get; set; }
                /// <summary>
                /// 商品缩略图
                /// </summary>
                [JsonProperty("goods_thumbnail_url")]
                public string GoodsThumbnailUrl { get; set; }
                /// <summary>
                /// 商品描述
                /// </summary>
                [JsonProperty("goods_desc")]
                public string GoodsDesc { get; set; }
                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 创建时间
                /// </summary>
                [JsonProperty("create_at")]
                public long? CreateAt { get; set; }
                /// <summary>
                /// 销售量
                /// </summary>
                [JsonProperty("sales_tip")]
                public string SalesTip { get; set; }
                /// <summary>
                /// 描述分
                /// </summary>
                [JsonProperty("desc_txt")]
                public string DescTxt { get; set; }
                /// <summary>
                /// 服务分
                /// </summary>
                [JsonProperty("serv_txt")]
                public string ServTxt { get; set; }
                /// <summary>
                /// 物流分
                /// </summary>
                [JsonProperty("lgst_txt")]
                public string LgstTxt { get; set; }

            }

        }

    }

}
