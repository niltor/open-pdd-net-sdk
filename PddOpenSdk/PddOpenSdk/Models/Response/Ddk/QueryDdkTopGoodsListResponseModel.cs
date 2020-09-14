using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class QueryDdkTopGoodsListResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("top_goods_list_get_response")]
        public TopGoodsListGetResponseResponseModel TopGoodsListGetResponse { get; set; }
        public partial class TopGoodsListGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品列表
            /// </summary>
            [JsonProperty("list")]
            public List<ListResponseModel> List { get; set; }
            /// <summary>
            /// 翻页时建议填写前页返回的list_id值
            /// </summary>
            [JsonProperty("list_id")]
            public string ListId { get; set; }
            /// <summary>
            /// 搜索id，建议生成推广链接时候填写，提高收益
            /// </summary>
            [JsonProperty("search_id")]
            public string SearchId { get; set; }
            /// <summary>
            /// 返回商品总数
            /// </summary>
            [JsonProperty("total")]
            public long? Total { get; set; }
            public partial class ListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商品类目id
                /// </summary>
                [JsonProperty("cat_ids")]
                public List<long?> CatIds { get; set; }
                /// <summary>
                /// 优惠券面额，单位为分
                /// </summary>
                [JsonProperty("coupon_discount")]
                public long? CouponDiscount { get; set; }
                /// <summary>
                /// 优惠券失效时间，UNIX时间戳
                /// </summary>
                [JsonProperty("coupon_end_time")]
                public long? CouponEndTime { get; set; }
                /// <summary>
                /// 优惠券门槛价格，单位为分
                /// </summary>
                [JsonProperty("coupon_min_order_amount")]
                public long? CouponMinOrderAmount { get; set; }
                /// <summary>
                /// 优惠券剩余数量
                /// </summary>
                [JsonProperty("coupon_remain_quantity")]
                public long? CouponRemainQuantity { get; set; }
                /// <summary>
                /// 优惠券生效时间，UNIX时间戳
                /// </summary>
                [JsonProperty("coupon_start_time")]
                public long? CouponStartTime { get; set; }
                /// <summary>
                /// 优惠券总数量
                /// </summary>
                [JsonProperty("coupon_total_quantity")]
                public long? CouponTotalQuantity { get; set; }
                /// <summary>
                /// 描述评分
                /// </summary>
                [JsonProperty("desc_txt")]
                public string DescTxt { get; set; }
                /// <summary>
                /// 商品描述
                /// </summary>
                [JsonProperty("goods_desc")]
                public string GoodsDesc { get; set; }
                /// <summary>
                /// 商品轮播图
                /// </summary>
                [JsonProperty("goods_gallery_urls")]
                public List<string> GoodsGalleryUrls { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 商品主图
                /// </summary>
                [JsonProperty("goods_image_url")]
                public string GoodsImageUrl { get; set; }
                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品缩略图
                /// </summary>
                [JsonProperty("goods_thumbnail_url")]
                public string GoodsThumbnailUrl { get; set; }
                /// <summary>
                /// 服务评分
                /// </summary>
                [JsonProperty("lgst_txt")]
                public string LgstTxt { get; set; }
                /// <summary>
                /// 店铺id
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 店铺名字
                /// </summary>
                [JsonProperty("mall_name")]
                public string MallName { get; set; }
                /// <summary>
                /// 最小拼团价（单位为分）
                /// </summary>
                [JsonProperty("min_group_price")]
                public long? MinGroupPrice { get; set; }
                /// <summary>
                /// 最小单买价格（单位为分）
                /// </summary>
                [JsonProperty("min_normal_price")]
                public long? MinNormalPrice { get; set; }
                /// <summary>
                /// 商品标签ID，使用pdd.goods.opts.get接口获取
                /// </summary>
                [JsonProperty("opt_id")]
                public long? OptId { get; set; }
                /// <summary>
                /// 商品标签id
                /// </summary>
                [JsonProperty("opt_ids")]
                public List<long?> OptIds { get; set; }
                /// <summary>
                /// 商品标签名
                /// </summary>
                [JsonProperty("opt_name")]
                public string OptName { get; set; }
                /// <summary>
                /// 佣金比例，千分比
                /// </summary>
                [JsonProperty("promotion_rate")]
                public long? PromotionRate { get; set; }
                /// <summary>
                /// 已售卖件数
                /// </summary>
                [JsonProperty("sales_tip")]
                public string SalesTip { get; set; }
                /// <summary>
                /// 搜索id，建议生成推广链接时候填写，提高收益
                /// </summary>
                [JsonProperty("search_id")]
                public string SearchId { get; set; }
                /// <summary>
                /// 物流评分
                /// </summary>
                [JsonProperty("serv_txt")]
                public string ServTxt { get; set; }
                /// <summary>
                /// 比价行为预判定佣金，需要用户备案
                /// </summary>
                [JsonProperty("predict_promotion_rate")]
                public long? PredictPromotionRate { get; set; }

            }

        }

    }

}
