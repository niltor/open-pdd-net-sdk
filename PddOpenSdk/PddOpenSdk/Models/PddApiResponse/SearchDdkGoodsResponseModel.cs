using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SearchDdkGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回商品总数
        /// </summary>
        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
        /// <summary>
        /// 多多进宝商品对象列表
        /// </summary>
        [JsonProperty("duoduojinbao_goods_list")]
        public DuoduojinbaoGoodsListResponseModel DuoduojinbaoGoodsList { get; set; }
        /// <summary>
        /// 该商品所在店铺是否参与全店推广，0：否，1：是
        /// </summary>
        [JsonProperty("mall_cps")]
        public int MallCps { get; set; }

        public partial class DuoduojinbaoGoodsListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 服务评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("serv_pct")]
            public object ServPct { get; set; }
            /// <summary>
            /// 物流评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("lgst_pct")]
            public object LgstPct { get; set; }
            /// <summary>
            /// 描述评分击败同类店铺百分比
            /// </summary>
            [JsonProperty("desc_pct")]
            public object DescPct { get; set; }
            /// <summary>
            /// 商品标签ID
            /// </summary>
            [JsonProperty("opt_ids")]
            public object[] OptIds { get; set; }
            /// <summary>
            /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
            /// </summary>
            [JsonProperty("merchant_type")]
            public int MerchantType { get; set; }
            /// <summary>
            /// 服务评分
            /// </summary>
            [JsonProperty("avg_serv")]
            public object AvgServ { get; set; }
            /// <summary>
            /// 物流评分
            /// </summary>
            [JsonProperty("avg_lgst")]
            public object AvgLgst { get; set; }
            /// <summary>
            /// 描述评分
            /// </summary>
            [JsonProperty("avg_desc")]
            public object AvgDesc { get; set; }
            /// <summary>
            /// 商品详情图列表
            /// </summary>
            [JsonProperty("goods_gallery_urls")]
            public string GoodsGalleryUrls { get; set; }
            /// <summary>
            /// 商品标签名
            /// </summary>
            [JsonProperty("opt_name")]
            public string OptName { get; set; }
            /// <summary>
            /// 商品标签ID，格式为：[一级标签ID，二级标签ID，三级标签ID...]使用pdd.goods.opt.get获取
            /// </summary>
            [JsonProperty("opt_id")]
            public int OptId { get; set; }
            /// <summary>
            /// 商品类目ID，使用pdd.goods.cats.get接口获取
            /// </summary>
            [JsonProperty("cat_ids")]
            public int CatIds { get; set; }
            /// <summary>
            /// 商品评价数量
            /// </summary>
            [JsonProperty("goods_eval_count")]
            public string GoodsEvalCount { get; set; }
            /// <summary>
            /// 商品评价分
            /// </summary>
            [JsonProperty("goods_eval_score")]
            public string GoodsEvalScore { get; set; }
            /// <summary>
            /// 佣金比例，千分比
            /// </summary>
            [JsonProperty("promotion_rate")]
            public string PromotionRate { get; set; }
            /// <summary>
            /// 优惠券失效时间，UNIX时间戳
            /// </summary>
            [JsonProperty("coupon_end_time")]
            public string CouponEndTime { get; set; }
            /// <summary>
            /// 优惠券生效时间，UNIX时间戳
            /// </summary>
            [JsonProperty("coupon_start_time")]
            public string CouponStartTime { get; set; }
            /// <summary>
            /// 优惠券剩余数量
            /// </summary>
            [JsonProperty("coupon_remain_quantity")]
            public int CouponRemainQuantity { get; set; }
            /// <summary>
            /// 优惠券总数量
            /// </summary>
            [JsonProperty("coupon_total_quantity")]
            public int CouponTotalQuantity { get; set; }
            /// <summary>
            /// 优惠券面额，单位为分
            /// </summary>
            [JsonProperty("coupon_discount")]
            public int CouponDiscount { get; set; }
            /// <summary>
            /// 优惠券门槛价格，单位为分
            /// </summary>
            [JsonProperty("coupon_min_order_amount")]
            public int CouponMinOrderAmount { get; set; }
            /// <summary>
            /// 店铺名称
            /// </summary>
            [JsonProperty("mall_name")]
            public string MallName { get; set; }
            /// <summary>
            /// 最小单买价格，单位为分
            /// </summary>
            [JsonProperty("min_normal_price")]
            public int MinNormalPrice { get; set; }
            /// <summary>
            /// 最小拼团价格，单位为分
            /// </summary>
            [JsonProperty("min_group_price")]
            public int MinGroupPrice { get; set; }
            /// <summary>
            /// 已售卖件数
            /// </summary>
            [JsonProperty("sold_quantity")]
            public int SoldQuantity { get; set; }
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
            /// 商品标题
            /// </summary>
            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }
            /// <summary>
            /// 参与多多进宝的商品ID
            /// </summary>
            [JsonProperty("goods_id")]
            public string GoodsId { get; set; }

        }

    }
}
