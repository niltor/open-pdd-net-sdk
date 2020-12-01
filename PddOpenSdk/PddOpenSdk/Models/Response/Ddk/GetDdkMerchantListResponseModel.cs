using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GetDdkMerchantListResponseModel : PddResponseModel
    {
        /// <summary>
        /// result
        /// </summary>
        [JsonProperty("merchant_list_response")]
        public MerchantListResponseResponseModel MerchantListResponse { get; set; }
        public partial class MerchantListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 店铺列表
            /// </summary>
            [JsonProperty("mall_search_info_vo_list")]
            public List<MallSearchInfoVoListResponseModel> MallSearchInfoVoList { get; set; }
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            public partial class MallSearchInfoVoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商品类目列表
                /// </summary>
                [JsonProperty("cat_id_list")]
                public List<int?> CatIdList { get; set; }
                /// <summary>
                /// 店铺收藏券ID
                /// </summary>
                [JsonProperty("clt_cpn_batch_sn")]
                public string CltCpnBatchSn { get; set; }
                /// <summary>
                /// 店铺收藏券券面额
                /// </summary>
                [JsonProperty("clt_cpn_discount")]
                public long? CltCpnDiscount { get; set; }
                /// <summary>
                /// 店铺收藏券失效时间
                /// </summary>
                [JsonProperty("clt_cpn_end_time")]
                public long? CltCpnEndTime { get; set; }
                /// <summary>
                /// 店铺收藏券使用门槛
                /// </summary>
                [JsonProperty("clt_cpn_min_amt")]
                public long? CltCpnMinAmt { get; set; }
                /// <summary>
                /// 店铺收藏券总量
                /// </summary>
                [JsonProperty("clt_cpn_quantity")]
                public long? CltCpnQuantity { get; set; }
                /// <summary>
                /// 店铺收藏券剩余量
                /// </summary>
                [JsonProperty("clt_cpn_remain_quantity")]
                public long? CltCpnRemainQuantity { get; set; }
                /// <summary>
                /// 店铺收藏券生效时间
                /// </summary>
                [JsonProperty("clt_cpn_start_time")]
                public long? CltCpnStartTime { get; set; }
                /// <summary>
                /// 描述评分
                /// </summary>
                [JsonProperty("desc_txt")]
                public string DescTxt { get; set; }
                /// <summary>
                /// 商品信息列表
                /// </summary>
                [JsonProperty("goods_detail_vo_list")]
                public List<GoodsDetailVoListResponseModel> GoodsDetailVoList { get; set; }
                /// <summary>
                /// 商品数
                /// </summary>
                [JsonProperty("goods_num")]
                public int? GoodsNum { get; set; }
                /// <summary>
                /// 店铺logo
                /// </summary>
                [JsonProperty("img_url")]
                public string ImgUrl { get; set; }
                /// <summary>
                /// 物流评分
                /// </summary>
                [JsonProperty("lgst_txt")]
                public string LgstTxt { get; set; }
                /// <summary>
                /// 店铺券列表
                /// </summary>
                [JsonProperty("mall_coupon_info_list")]
                public List<MallCouponInfoListResponseModel> MallCouponInfoList { get; set; }
                /// <summary>
                /// 店铺id
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 店铺名称
                /// </summary>
                [JsonProperty("mall_name")]
                public string MallName { get; set; }
                /// <summary>
                /// 全店推广佣金
                /// </summary>
                [JsonProperty("mall_rate")]
                public int? MallRate { get; set; }
                /// <summary>
                /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
                /// </summary>
                [JsonProperty("merchant_type")]
                public int? MerchantType { get; set; }
                /// <summary>
                /// 销量
                /// </summary>
                [JsonProperty("sales_tip")]
                public string SalesTip { get; set; }
                /// <summary>
                /// 服务评分
                /// </summary>
                [JsonProperty("serv_txt")]
                public string ServTxt { get; set; }
                public partial class GoodsDetailVoListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 活动类型
                    /// </summary>
                    [JsonProperty("activity_type")]
                    public int? ActivityType { get; set; }
                    /// <summary>
                    /// 商品标签，与optId一样，兼容老版本
                    /// </summary>
                    [JsonProperty("category_id")]
                    public long? CategoryId { get; set; }
                    /// <summary>
                    /// 商品标签名，与optName一样，兼容老版本
                    /// </summary>
                    [JsonProperty("category_name")]
                    public string CategoryName { get; set; }
                    /// <summary>
                    /// 未赋值，无用字段，兼容老版本
                    /// </summary>
                    [JsonProperty("cat_id")]
                    public long? CatId { get; set; }
                    /// <summary>
                    /// 商品标签列表，与optIds一样，兼容老版本
                    /// </summary>
                    [JsonProperty("cat_ids")]
                    public List<int?> CatIds { get; set; }
                    /// <summary>
                    /// 店铺收藏券ID
                    /// </summary>
                    [JsonProperty("clt_cpn_batch_sn")]
                    public string CltCpnBatchSn { get; set; }
                    /// <summary>
                    /// 店铺收藏券折扣
                    /// </summary>
                    [JsonProperty("clt_cpn_discount")]
                    public long? CltCpnDiscount { get; set; }
                    /// <summary>
                    /// 店铺收藏券截止时间
                    /// </summary>
                    [JsonProperty("clt_cpn_end_time")]
                    public long? CltCpnEndTime { get; set; }
                    /// <summary>
                    /// 店铺收藏券使用门槛
                    /// </summary>
                    [JsonProperty("clt_cpn_min_amt")]
                    public long? CltCpnMinAmt { get; set; }
                    /// <summary>
                    /// 店铺收藏券总量
                    /// </summary>
                    [JsonProperty("clt_cpn_quantity")]
                    public long? CltCpnQuantity { get; set; }
                    /// <summary>
                    /// 店铺收藏券剩余量
                    /// </summary>
                    [JsonProperty("clt_cpn_remain_quantity")]
                    public long? CltCpnRemainQuantity { get; set; }
                    /// <summary>
                    /// 店铺收藏券起始时间
                    /// </summary>
                    [JsonProperty("clt_cpn_start_time")]
                    public long? CltCpnStartTime { get; set; }
                    /// <summary>
                    /// 单品优惠券面额（单位为分）
                    /// </summary>
                    [JsonProperty("coupon_discount")]
                    public long? CouponDiscount { get; set; }
                    /// <summary>
                    /// 单品优惠券结束时间
                    /// </summary>
                    [JsonProperty("coupon_end_time")]
                    public long? CouponEndTime { get; set; }
                    /// <summary>
                    /// 使用单品优惠券的门槛金额（单位为分）
                    /// </summary>
                    [JsonProperty("coupon_min_order_amount")]
                    public long? CouponMinOrderAmount { get; set; }
                    /// <summary>
                    /// 单品优惠券剩余数量
                    /// </summary>
                    [JsonProperty("coupon_remain_quantity")]
                    public long? CouponRemainQuantity { get; set; }
                    /// <summary>
                    /// 单品优惠券开始时间
                    /// </summary>
                    [JsonProperty("coupon_start_time")]
                    public long? CouponStartTime { get; set; }
                    /// <summary>
                    /// 单品优惠券总数量
                    /// </summary>
                    [JsonProperty("coupon_total_quantity")]
                    public long? CouponTotalQuantity { get; set; }
                    /// <summary>
                    /// cpsSign
                    /// </summary>
                    [JsonProperty("cps_sign")]
                    public string CpsSign { get; set; }
                    /// <summary>
                    /// 创建时间
                    /// </summary>
                    [JsonProperty("create_at")]
                    public long? CreateAt { get; set; }
                    /// <summary>
                    /// 店铺近30天申请售后率
                    /// </summary>
                    [JsonProperty("crt_rf_ordr_rto1m")]
                    public double? CrtRfOrdrRto1m { get; set; }
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
                    /// 商品详情图
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
                    /// 是否有单品券
                    /// </summary>
                    [JsonProperty("has_coupon")]
                    public bool? HasCoupon { get; set; }
                    /// <summary>
                    /// 是否有店铺券
                    /// </summary>
                    [JsonProperty("has_mall_coupon")]
                    public bool? HasMallCoupon { get; set; }
                    /// <summary>
                    /// 物流评分
                    /// </summary>
                    [JsonProperty("lgst_txt")]
                    public string LgstTxt { get; set; }
                    /// <summary>
                    /// 店铺折扣券折扣
                    /// </summary>
                    [JsonProperty("mall_coupon_discount_pct")]
                    public int? MallCouponDiscountPct { get; set; }
                    /// <summary>
                    /// 店铺折扣券失效时间
                    /// </summary>
                    [JsonProperty("mall_coupon_end_time")]
                    public long? MallCouponEndTime { get; set; }
                    /// <summary>
                    /// 店铺券减免上限金额（单位为分）
                    /// </summary>
                    [JsonProperty("mall_coupon_max_discount_amount")]
                    public int? MallCouponMaxDiscountAmount { get; set; }
                    /// <summary>
                    /// 店铺折扣券使用门槛（单位为分）
                    /// </summary>
                    [JsonProperty("mall_coupon_min_order_amount")]
                    public int? MallCouponMinOrderAmount { get; set; }
                    /// <summary>
                    /// 店铺折扣券余量
                    /// </summary>
                    [JsonProperty("mall_coupon_remain_quantity")]
                    public long? MallCouponRemainQuantity { get; set; }
                    /// <summary>
                    /// 店铺折扣券生效时间
                    /// </summary>
                    [JsonProperty("mall_coupon_start_time")]
                    public long? MallCouponStartTime { get; set; }
                    /// <summary>
                    /// 店铺折扣券总量
                    /// </summary>
                    [JsonProperty("mall_coupon_total_quantity")]
                    public long? MallCouponTotalQuantity { get; set; }
                    /// <summary>
                    /// 商品所在店铺是否开通全店推广 0：否，1：是
                    /// </summary>
                    [JsonProperty("mall_cps")]
                    public int? MallCps { get; set; }
                    /// <summary>
                    /// 店铺id
                    /// </summary>
                    [JsonProperty("mall_id")]
                    public long? MallId { get; set; }
                    /// <summary>
                    /// 店铺名称
                    /// </summary>
                    [JsonProperty("mall_name")]
                    public string MallName { get; set; }
                    /// <summary>
                    /// 全店推广佣金比例
                    /// </summary>
                    [JsonProperty("mall_rate")]
                    public int? MallRate { get; set; }
                    /// <summary>
                    /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
                    /// </summary>
                    [JsonProperty("merchant_type")]
                    public int? MerchantType { get; set; }
                    /// <summary>
                    /// 商品最小成团价（单位为分）
                    /// </summary>
                    [JsonProperty("min_group_price")]
                    public long? MinGroupPrice { get; set; }
                    /// <summary>
                    /// 商品单买价（单位为分）
                    /// </summary>
                    [JsonProperty("min_normal_price")]
                    public long? MinNormalPrice { get; set; }
                    /// <summary>
                    /// 商品标签
                    /// </summary>
                    [JsonProperty("opt_id")]
                    public long? OptId { get; set; }
                    /// <summary>
                    /// 商品标签列表
                    /// </summary>
                    [JsonProperty("opt_ids")]
                    public List<int?> OptIds { get; set; }
                    /// <summary>
                    /// 商品标签名
                    /// </summary>
                    [JsonProperty("opt_name")]
                    public string OptName { get; set; }
                    /// <summary>
                    /// 单品推广佣金
                    /// </summary>
                    [JsonProperty("promotion_rate")]
                    public long? PromotionRate { get; set; }
                    /// <summary>
                    /// 销量
                    /// </summary>
                    [JsonProperty("sales_tip")]
                    public string SalesTip { get; set; }
                    /// <summary>
                    /// 服务类型
                    /// </summary>
                    [JsonProperty("service_tags")]
                    public List<int?> ServiceTags { get; set; }
                    /// <summary>
                    /// 服务评分
                    /// </summary>
                    [JsonProperty("serv_txt")]
                    public string ServTxt { get; set; }
                    /// <summary>
                    /// 比价行为预判定佣金，需要用户备案
                    /// </summary>
                    [JsonProperty("predict_promotion_rate")]
                    public long? PredictPromotionRate { get; set; }

                }
                public partial class MallCouponInfoListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 店铺券失效时间
                    /// </summary>
                    [JsonProperty("coupon_end_time")]
                    public long? CouponEndTime { get; set; }
                    /// <summary>
                    /// 店铺券总量
                    /// </summary>
                    [JsonProperty("coupon_quantity")]
                    public long? CouponQuantity { get; set; }
                    /// <summary>
                    /// 店铺券剩余量
                    /// </summary>
                    [JsonProperty("coupon_remain_quantity")]
                    public long? CouponRemainQuantity { get; set; }
                    /// <summary>
                    /// 店铺券生效时间
                    /// </summary>
                    [JsonProperty("coupon_start_time")]
                    public long? CouponStartTime { get; set; }
                    /// <summary>
                    /// 店铺折扣券类型
                    /// </summary>
                    [JsonProperty("coupon_type")]
                    public int? CouponType { get; set; }
                    /// <summary>
                    /// 店铺折扣券折扣
                    /// </summary>
                    [JsonProperty("discount")]
                    public int? Discount { get; set; }
                    /// <summary>
                    /// 店铺id
                    /// </summary>
                    [JsonProperty("mall_id")]
                    public long? MallId { get; set; }
                    /// <summary>
                    /// 店铺券减免上限金额（单位为分）
                    /// </summary>
                    [JsonProperty("max_discount_amount")]
                    public int? MaxDiscountAmount { get; set; }
                    /// <summary>
                    /// 店铺折扣券使用门槛（单位为分）
                    /// </summary>
                    [JsonProperty("min_order_amount")]
                    public int? MinOrderAmount { get; set; }

                }

            }

        }

    }

}
