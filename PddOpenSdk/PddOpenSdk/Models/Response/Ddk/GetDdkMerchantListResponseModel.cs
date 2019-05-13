using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GetDdkMerchantListResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("merchant_list_response")]
        public MerchantListResponseResponseModel MerchantListResponse { get; set; }
        public partial class MerchantListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// total
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            /// <summary>
            /// 店铺信息列表
            /// </summary>
            [JsonProperty("mall_search_info_vo_list")]
            public List<MallSearchInfoVoListResponseModel> MallSearchInfoVoList { get; set; }
            public partial class MallSearchInfoVoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 店铺描述评分
                /// </summary>
                [JsonProperty("avg_desc")]
                public double AvgDesc { set; get; }

                /// <summary>
                /// 店铺服务评分
                /// </summary>
                [JsonProperty("avg_serv")]
                public double AvgServ { set; get; }

                /// <summary>
                /// 店铺物流评分
                /// </summary>
                [JsonProperty("avg_lgst")]
                public double AvgLgst { set; get; }

                /// <summary>
                /// 服务评分击败同类店铺百分比
                /// </summary>
                [JsonProperty("serv_pct")]
                public double ServPct { set; get; }

                /// <summary>
                /// 销售数量
                /// </summary>
                [JsonProperty("sold_quantity")]
                public long SoldQuantity { set; get; }

                /// <summary>
                /// 店铺分类列表
                /// </summary>
                [JsonProperty("cat_id_list")]
                public List<int> CatIdList { set; get; }

                /// <summary>
                /// 物流评分击败同类店铺百分比
                /// </summary>
                [JsonProperty("lgst_pct")]
                public double LgstPct { set; get; }

                /// <summary>
                /// 店铺图片
                /// </summary>
                [JsonProperty("img_url")]
                public string ImgUrl { set; get; }
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
                /// 商品数量
                /// </summary>
                [JsonProperty("goods_num")]
                public long? GoodsNum { set; get; }

                /// <summary>
                /// 店铺佣金率
                /// </summary>
                [JsonProperty("mall_rate")]
                public int MallRate { set; get; }

                /// <summary>
                /// 描述评分击败同类店铺百分比
                /// </summary>
                [JsonProperty("desc_pct")]
                public double? DescPct { set; get; }

                /// <summary>
                /// 店铺类型 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
                /// </summary>
                [JsonProperty("merchant_type")]
                public int MerchantType { set; get; }
                /// <summary>
                /// 商品详情列表
                /// </summary>
                [JsonProperty("goods_detail_vo_list")]
                public List<GoodsDetailVoListResponseModel> GoodsDetailVoList { get; set; }
                /// <summary>
                /// 店铺券列表
                /// </summary>
                [JsonProperty("mall_coupon_info_list")]
                public List<MallCouponInfoListResponseModel> MallCouponInfoList { set; get; }

                public partial class GoodsDetailVoListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 创建时间
                    /// </summary>
                    [JsonProperty("create_at")]
                    public long? CreateAt { get; set; }
                    /// <summary>
                    /// 商品id
                    /// </summary>
                    [JsonProperty("goods_id")]
                    public long? GoodsId { get; set; }
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
                    public List<string> GoodsGalleryUrls { get; set; }
                    /// <summary>
                    /// 商品售卖件数
                    /// </summary>
                    [JsonProperty("sold_quantity")]
                    public long? SoldQuantity { get; set; }
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
                    /// 店铺名称
                    /// </summary>
                    [JsonProperty("mall_name")]
                    public string MallName { get; set; }
                    /// <summary>
                    /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店
                    /// </summary>
                    [JsonProperty("merchant_type")]
                    public int? MerchantType { get; set; }
                    /// <summary>
                    /// 商品类目
                    /// </summary>
                    [JsonProperty("category_id")]
                    public long? CategoryId { get; set; }
                    /// <summary>
                    /// 商品类目名
                    /// </summary>
                    [JsonProperty("category_name")]
                    public string CategoryName { get; set; }
                    /// <summary>
                    /// 商品标签
                    /// </summary>
                    [JsonProperty("opt_id")]
                    public long? OptId { get; set; }
                    /// <summary>
                    /// 商品标签名
                    /// </summary>
                    [JsonProperty("opt_name")]
                    public string OptName { get; set; }
                    /// <summary>
                    /// 商品标签列表
                    /// </summary>
                    [JsonProperty("opt_ids")]
                    public List<int> OptIds { get; set; }
                    /// <summary>
                    /// 商品类目列表
                    /// </summary>
                    [JsonProperty("cat_ids")]
                    public List<int> CatIds { get; set; }
                    /// <summary>
                    /// 商品所在店铺是否开通全店推广 0：否，1：是
                    /// </summary>
                    [JsonProperty("mall_cps")]
                    public int? MallCps { get; set; }
                    /// <summary>
                    /// 商品是否有优惠券（指单品券）
                    /// </summary>
                    [JsonProperty("has_coupon")]
                    public bool? HasCoupon { get; set; }
                    /// <summary>
                    /// 使用优惠券的门槛金额（单位为分）
                    /// </summary>
                    [JsonProperty("coupon_min_order_amount")]
                    public long? CouponMinOrderAmount { get; set; }
                    /// <summary>
                    /// 优惠券面额（单位为分）
                    /// </summary>
                    [JsonProperty("coupon_discount")]
                    public long? CouponDiscount { get; set; }
                    /// <summary>
                    /// 优惠券总数量
                    /// </summary>
                    [JsonProperty("coupon_total_quantity")]
                    public long? CouponTotalQuantity { get; set; }
                    /// <summary>
                    /// 优惠券剩余数量
                    /// </summary>
                    [JsonProperty("coupon_remain_quantity")]
                    public long? CouponRemainQuantity { get; set; }
                    /// <summary>
                    /// 优惠券开始时间
                    /// </summary>
                    [JsonProperty("coupon_start_time")]
                    public long? CouponStartTime { get; set; }
                    /// <summary>
                    /// 优惠券结束时间
                    /// </summary>
                    [JsonProperty("coupon_end_time")]
                    public long? CouponEndTime { get; set; }
                    /// <summary>
                    /// 佣金比（单位为分）
                    /// </summary>
                    [JsonProperty("promotion_rate")]
                    public long? PromotionRate { get; set; }
                    /// <summary>
                    /// 商品评分
                    /// </summary>
                    [JsonProperty("goods_eval_score")]
                    public double? GoodsEvalScore { get; set; }
                    /// <summary>
                    /// 商品评价数
                    /// </summary>
                    [JsonProperty("goods_eval_count")]
                    public long? GoodsEvalCount { get; set; }
                    /// <summary>
                    /// 类目id
                    /// </summary>
                    [JsonProperty("cat_id")]
                    public long? CatId { get; set; }
                    /// <summary>
                    /// 商品描述评分
                    /// </summary>
                    [JsonProperty("avg_desc")]
                    public long? AvgDesc { get; set; }
                    /// <summary>
                    /// 商品物流评分
                    /// </summary>
                    [JsonProperty("avg_lgst")]
                    public long? AvgLgst { get; set; }
                    /// <summary>
                    /// 商品服务评分
                    /// </summary>
                    [JsonProperty("avg_serv")]
                    public long? AvgServ { get; set; }
                    /// <summary>
                    /// 描述评分击败同类店铺百分比
                    /// </summary>
                    [JsonProperty("desc_pct")]
                    public double? DescPct { get; set; }
                    /// <summary>
                    /// 物流评分击败同类店铺百分比
                    /// </summary>
                    [JsonProperty("lgst_pct")]
                    public double? LgstPct { get; set; }
                    /// <summary>
                    /// 服务评分击败同类店铺百分比
                    /// </summary>
                    [JsonProperty("serv_pct")]
                    public double? ServPct { get; set; }

                    /// <summary>
                    /// 店铺优惠券结束时间
                    /// </summary>
                    [JsonProperty("mall_coupon_end_time")]
                    public long? MallCouponEndTime { set; get; }

                    /// <summary>
                    /// 是否有店铺优惠券
                    /// </summary>
                    [JsonProperty("has_mall_coupon")]
                    public bool HasMallCoupon { set; get; }

                    /// <summary>
                    /// 店铺优惠券剩余数量
                    /// </summary>
                    [JsonProperty("mall_coupon_remain_quantity")]
                    public long? MallCouponRemainQuantity { set; get; }

                    /// <summary>
                    /// CPS签名
                    /// </summary>
                    [JsonProperty("cps_sign")]
                    public string CpsSign { set; get; }

                    /// <summary>
                    /// 店铺优惠券折扣百分比
                    /// </summary>
                    [JsonProperty("mall_coupon_discount_pct")]
                    public string MallCouponDiscountPct { set; get; }

                    /// <summary>
                    /// 店铺优惠券最小门槛金额（单位为分）
                    /// </summary>
                    [JsonProperty("mall_coupon_min_order_amount")]
                    public long? MallCouponMinOrderAmount { set; get; }

                    /// <summary>
                    /// 售卖建议
                    /// </summary>
                    [JsonProperty("sales_tip")]
                    public string SalesTip { set; get; }

                    /// <summary>
                    /// 店铺优惠券Id
                    /// </summary>
                    [JsonProperty("mall_coupon_id")]
                    public long? MallCouponId { set; get; }

                    /// <summary>
                    /// 店铺优惠券开始时间
                    /// </summary>
                    [JsonProperty("mall_coupon_start_time")]
                    public long? MallCouponStartTime { set; get; }

                    /// <summary>
                    /// 店铺佣金率
                    /// </summary>
                    [JsonProperty("mall_rate")]
                    public int MallRate { set; get; }

                    /// <summary>
                    /// 店铺优惠券总数量
                    /// </summary>
                    [JsonProperty("mall_coupon_total_quantity")]
                    public long? MallCouponTotalQuantity { set; get; }

                    /// <summary>
                    /// 店铺优惠券最大使用门槛金额
                    /// </summary>
                    [JsonProperty("mall_coupon_max_discount_amount")]
                    public long? MallCouponMacDiscountAmount { set; get; }

                }

                public partial class MallCouponInfoListResponseModel
                {
                    /// <summary>
                    /// 优惠券数量
                    /// </summary>
                    [JsonProperty("coupon_quantity")]
                    public long CouponQuantity { set; get; }

                    /// <summary>
                    /// 使用优惠券的门槛金额（单位为分）
                    /// </summary>
                    [JsonProperty("min_order_amount")]
                    public long MinOrderAmount { set; get; }

                    /// <summary>
                    /// 优惠券Id
                    /// </summary>
                    [JsonProperty("coupon_id")]
                    public long CouponId { set; get; }

                    /// <summary>
                    /// 优惠券剩余数量
                    /// </summary>
                    [JsonProperty("coupon_remain_quantity")]
                    public long CouponRemainQuantity { set; get; }

                    /// <summary>
                    /// 店铺id
                    /// </summary>
                    [JsonProperty("mall_id")]
                    public long? MallId { get; set; }

                    /// <summary>
                    /// 折扣率 3.1 折 = 31
                    /// </summary>
                    [JsonProperty("discount")]
                    public long DisCount { get; set; }

                    /// <summary>
                    /// 优惠券开始时间
                    /// </summary>
                    [JsonProperty("coupon_start_time")]
                    public long CouponStartTime { get; set; }

                    /// <summary>
                    /// 优惠券类型
                    /// </summary>
                    [JsonProperty("coupon_type")]
                    public int CouponType { get; set; }

                    /// <summary>
                    /// 最大折扣金额
                    /// </summary>
                    [JsonProperty("max_discount_amount")]
                    public long CouponDiscountAmount { get; set; }

                    /// <summary>
                    /// 优惠券结束时间
                    /// </summary>
                    [JsonProperty("coupon_end_time")]
                    public long CouponEndTime { get; set; }
                }

            }

        }

    }

}
