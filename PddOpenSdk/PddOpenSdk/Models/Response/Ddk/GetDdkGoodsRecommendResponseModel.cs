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
            /// 列表
            /// </summary>
            [JsonProperty("list")]
            public List<ListResponseModel> List { get; set; }
            /// <summary>
            /// 翻页时必填前页返回的list_id值
            /// </summary>
            [JsonProperty("list_id")]
            public string ListId { get; set; }
            /// <summary>
            /// 搜索id，建议生成推广链接时候填写，提高收益。
            /// </summary>
            [JsonProperty("search_id")]
            public string SearchId { get; set; }
            /// <summary>
            /// total
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            public partial class ListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商品活动标记数组，例：[4,7]，4-秒杀 7-百亿补贴等
                /// </summary>
                [JsonProperty("activity_tags")]
                public List<int?> ActivityTags { get; set; }
                /// <summary>
                /// 商品类目id
                /// </summary>
                [JsonProperty("cat_id")]
                public string CatId { get; set; }
                /// <summary>
                /// 商品一~四级类目ID列表
                /// </summary>
                [JsonProperty("cat_ids")]
                public List<long?> CatIds { get; set; }
                /// <summary>
                /// 优惠券面额,单位为分
                /// </summary>
                [JsonProperty("coupon_discount")]
                public long? CouponDiscount { get; set; }
                /// <summary>
                /// 优惠券失效时间,UNIX时间戳
                /// </summary>
                [JsonProperty("coupon_end_time")]
                public long? CouponEndTime { get; set; }
                /// <summary>
                /// 优惠券门槛价格,单位为分
                /// </summary>
                [JsonProperty("coupon_min_order_amount")]
                public long? CouponMinOrderAmount { get; set; }
                /// <summary>
                /// 优惠券金额
                /// </summary>
                [JsonProperty("coupon_price")]
                public long? CouponPrice { get; set; }
                /// <summary>
                /// 优惠券剩余数量
                /// </summary>
                [JsonProperty("coupon_remain_quantity")]
                public long? CouponRemainQuantity { get; set; }
                /// <summary>
                /// 优惠券生效时间,UNIX时间戳
                /// </summary>
                [JsonProperty("coupon_start_time")]
                public long? CouponStartTime { get; set; }
                /// <summary>
                /// 优惠券总数量
                /// </summary>
                [JsonProperty("coupon_total_quantity")]
                public long? CouponTotalQuantity { get; set; }
                /// <summary>
                /// 创建时间
                /// </summary>
                [JsonProperty("create_at")]
                public long? CreateAt { get; set; }
                /// <summary>
                /// 描述分
                /// </summary>
                [JsonProperty("desc_txt")]
                public string DescTxt { get; set; }
                /// <summary>
                /// 额外优惠券
                /// </summary>
                [JsonProperty("extra_coupon_amount")]
                public long? ExtraCouponAmount { get; set; }
                /// <summary>
                /// 商品描述
                /// </summary>
                [JsonProperty("goods_desc")]
                public string GoodsDesc { get; set; }
                /// <summary>
                /// 商品主图
                /// </summary>
                [JsonProperty("goods_image_url")]
                public string GoodsImageUrl { get; set; }
                /// <summary>
                /// 商品特殊标签列表。例: [1]，1-APP专享
                /// </summary>
                [JsonProperty("goods_labels")]
                public List<int?> GoodsLabels { get; set; }
                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品等级
                /// </summary>
                [JsonProperty("goods_rate")]
                public long? GoodsRate { get; set; }
                /// <summary>
                /// 商品goodsSign，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
                /// </summary>
                [JsonProperty("goods_sign")]
                public string GoodsSign { get; set; }
                /// <summary>
                /// 商品缩略图
                /// </summary>
                [JsonProperty("goods_thumbnail_url")]
                public string GoodsThumbnailUrl { get; set; }
                /// <summary>
                /// 商品类型
                /// </summary>
                [JsonProperty("goods_type")]
                public int? GoodsType { get; set; }
                /// <summary>
                /// 商品是否带券,true-带券,false-不带券
                /// </summary>
                [JsonProperty("has_coupon")]
                public bool? HasCoupon { get; set; }
                /// <summary>
                /// 物流分
                /// </summary>
                [JsonProperty("lgst_txt")]
                public string LgstTxt { get; set; }
                /// <summary>
                /// 商家id
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 店铺名称
                /// </summary>
                [JsonProperty("mall_name")]
                public string MallName { get; set; }
                /// <summary>
                /// 市场服务费
                /// </summary>
                [JsonProperty("market_fee")]
                public long? MarketFee { get; set; }
                /// <summary>
                /// 商家类型
                /// </summary>
                [JsonProperty("merchant_type")]
                public string MerchantType { get; set; }
                /// <summary>
                /// 最小成团价格，单位分
                /// </summary>
                [JsonProperty("min_group_price")]
                public long? MinGroupPrice { get; set; }
                /// <summary>
                /// 最小单买价格，单位分
                /// </summary>
                [JsonProperty("min_normal_price")]
                public long? MinNormalPrice { get; set; }
                /// <summary>
                /// 商品标签类目ID,使用pdd.goods.opt.get获取
                /// </summary>
                [JsonProperty("opt_id")]
                public string OptId { get; set; }
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
                /// 比价行为预判定佣金，需要用户备案
                /// </summary>
                [JsonProperty("predict_promotion_rate")]
                public long? PredictPromotionRate { get; set; }
                /// <summary>
                /// 佣金比例,千分比
                /// </summary>
                [JsonProperty("promotion_rate")]
                public long? PromotionRate { get; set; }
                /// <summary>
                /// 二维码主图
                /// </summary>
                [JsonProperty("qr_code_image_url")]
                public string QrCodeImageUrl { get; set; }
                /// <summary>
                /// 商品近1小时在多多进宝的实时销量（仅实时热销榜提供）
                /// </summary>
                [JsonProperty("realtime_sales_tip")]
                public string RealtimeSalesTip { get; set; }
                /// <summary>
                /// 销售量
                /// </summary>
                [JsonProperty("sales_tip")]
                public string SalesTip { get; set; }
                /// <summary>
                /// 搜索id，建议生成推广链接时候填写，提高收益。
                /// </summary>
                [JsonProperty("search_id")]
                public string SearchId { get; set; }
                /// <summary>
                /// 服务分
                /// </summary>
                [JsonProperty("serv_txt")]
                public string ServTxt { get; set; }
                /// <summary>
                /// 分享描述
                /// </summary>
                [JsonProperty("share_desc")]
                public string ShareDesc { get; set; }
                /// <summary>
                /// 招商分成服务费比例，千分比
                /// </summary>
                [JsonProperty("share_rate")]
                public int? ShareRate { get; set; }
                /// <summary>
                /// 优势渠道专属商品补贴金额。针对优质渠道的补贴活动，指定优势渠道可通过推广该商品获取相应补贴。补贴活动入口：[进宝网站-官方活动-千万补贴]，报名入口：https://jinbao.pinduoduo.com/ten-million-subsidy/entry
                /// </summary>
                [JsonProperty("subsidy_amount")]
                public int? SubsidyAmount { get; set; }
                /// <summary>
                /// 优惠标签列表，包括："X元券","比全网低X元","服务费","精选素材","近30天低价","同款低价","同款好评","同款热销","旗舰店","一降到底","招商优选","商家优选","好价再降X元","全站销量XX","实时热销榜第X名","实时好评榜第X名","额外补X元"等
                /// </summary>
                [JsonProperty("unified_tags")]
                public List<string> UnifiedTags { get; set; }

            }

        }

    }

}
