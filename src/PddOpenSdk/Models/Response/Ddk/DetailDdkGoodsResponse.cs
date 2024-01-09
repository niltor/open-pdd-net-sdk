namespace PddOpenSdk.Models.Response.Ddk;
public partial class DetailDdkGoodsResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_detail_response")]
    public GoodsDetailResponseResponse GoodsDetailResponse { get; set; }
    public partial class GoodsDetailResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 多多进宝商品对象列表
        /// </summary>
        [JsonPropertyName("goods_details")]
        public List<GoodsDetailsResponse> GoodsDetails { get; set; }
        public partial class GoodsDetailsResponse : PddResponseModel
        {

            /// <summary>
            /// 活动佣金比例，千分比（特定活动期间的佣金比例）
            /// </summary>
            [JsonPropertyName("activity_promotion_rate")]
            public long? ActivityPromotionRate { get; set; }

            /// <summary>
            /// 商品活动标记数组，例：[4,7]，4-秒杀 7-百亿补贴等
            /// </summary>
            [JsonPropertyName("activity_tags")]
            public List<int?> ActivityTags { get; set; }

            /// <summary>
            /// 商品品牌词信息，如“苹果”、“阿迪达斯”、“李宁”等
            /// </summary>
            [JsonPropertyName("brand_name")]
            public string BrandName { get; set; }

            /// <summary>
            /// 全局礼金金额，单位分
            /// </summary>
            [JsonPropertyName("cash_gift_amount")]
            public long? CashGiftAmount { get; set; }

            /// <summary>
            /// 商品类目ID，使用pdd.goods.cats.get接口获取
            /// </summary>
            [JsonPropertyName("cat_id")]
            public long? CatId { get; set; }

            /// <summary>
            /// 商品一~四级类目ID列表
            /// </summary>
            [JsonPropertyName("cat_ids")]
            public List<int?> CatIds { get; set; }

            /// <summary>
            /// 店铺收藏券id
            /// </summary>
            [JsonPropertyName("clt_cpn_batch_sn")]
            public string CltCpnBatchSn { get; set; }

            /// <summary>
            /// 店铺收藏券面额,单位为分
            /// </summary>
            [JsonPropertyName("clt_cpn_discount")]
            public long? CltCpnDiscount { get; set; }

            /// <summary>
            /// 店铺收藏券截止时间
            /// </summary>
            [JsonPropertyName("clt_cpn_end_time")]
            public long? CltCpnEndTime { get; set; }

            /// <summary>
            /// 店铺收藏券使用门槛价格,单位为分
            /// </summary>
            [JsonPropertyName("clt_cpn_min_amt")]
            public long? CltCpnMinAmt { get; set; }

            /// <summary>
            /// 店铺收藏券总量
            /// </summary>
            [JsonPropertyName("clt_cpn_quantity")]
            public long? CltCpnQuantity { get; set; }

            /// <summary>
            /// 店铺收藏券剩余量
            /// </summary>
            [JsonPropertyName("clt_cpn_remain_quantity")]
            public long? CltCpnRemainQuantity { get; set; }

            /// <summary>
            /// 店铺收藏券起始时间
            /// </summary>
            [JsonPropertyName("clt_cpn_start_time")]
            public long? CltCpnStartTime { get; set; }

            /// <summary>
            /// 优惠券面额，单位为分
            /// </summary>
            [JsonPropertyName("coupon_discount")]
            public long? CouponDiscount { get; set; }

            /// <summary>
            /// 优惠券失效时间，UNIX时间戳
            /// </summary>
            [JsonPropertyName("coupon_end_time")]
            public long? CouponEndTime { get; set; }

            /// <summary>
            /// 优惠券门槛金额，单位为分
            /// </summary>
            [JsonPropertyName("coupon_min_order_amount")]
            public long? CouponMinOrderAmount { get; set; }

            /// <summary>
            /// 优惠券剩余数量
            /// </summary>
            [JsonPropertyName("coupon_remain_quantity")]
            public long? CouponRemainQuantity { get; set; }

            /// <summary>
            /// 优惠券生效时间，UNIX时间戳
            /// </summary>
            [JsonPropertyName("coupon_start_time")]
            public long? CouponStartTime { get; set; }

            /// <summary>
            /// 优惠券总数量
            /// </summary>
            [JsonPropertyName("coupon_total_quantity")]
            public long? CouponTotalQuantity { get; set; }

            /// <summary>
            /// 创建时间（unix时间戳）
            /// </summary>
            [JsonPropertyName("create_at")]
            public long? CreateAt { get; set; }

            /// <summary>
            /// 描述分
            /// </summary>
            [JsonPropertyName("desc_txt")]
            public string DescTxt { get; set; }

            /// <summary>
            /// 额外优惠券
            /// </summary>
            [JsonPropertyName("extra_coupon_amount")]
            public long? ExtraCouponAmount { get; set; }

            /// <summary>
            /// 参与多多进宝的商品描述
            /// </summary>
            [JsonPropertyName("goods_desc")]
            public string GoodsDesc { get; set; }

            /// <summary>
            /// 商品轮播图
            /// </summary>
            [JsonPropertyName("goods_gallery_urls")]
            public List<string> GoodsGalleryUrls { get; set; }

            /// <summary>
            /// 多多进宝商品主图
            /// </summary>
            [JsonPropertyName("goods_image_url")]
            public string GoodsImageUrl { get; set; }

            /// <summary>
            /// 参与多多进宝的商品标题
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品goodsSign，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
            /// </summary>
            [JsonPropertyName("goods_sign")]
            public string GoodsSign { get; set; }

            /// <summary>
            /// 商品缩略图
            /// </summary>
            [JsonPropertyName("goods_thumbnail_url")]
            public string GoodsThumbnailUrl { get; set; }

            /// <summary>
            /// 商品是否有优惠券 true-有，false-没有
            /// </summary>
            [JsonPropertyName("has_coupon")]
            public bool? HasCoupon { get; set; }

            /// <summary>
            /// 是否有店铺券
            /// </summary>
            [JsonPropertyName("has_mall_coupon")]
            public bool? HasMallCoupon { get; set; }

            /// <summary>
            /// 物流分
            /// </summary>
            [JsonPropertyName("lgst_txt")]
            public string LgstTxt { get; set; }

            /// <summary>
            /// 店铺折扣
            /// </summary>
            [JsonPropertyName("mall_coupon_discount_pct")]
            public int? MallCouponDiscountPct { get; set; }

            /// <summary>
            /// 店铺券使用结束时间
            /// </summary>
            [JsonPropertyName("mall_coupon_end_time")]
            public long? MallCouponEndTime { get; set; }

            /// <summary>
            /// 最大使用金额
            /// </summary>
            [JsonPropertyName("mall_coupon_max_discount_amount")]
            public int? MallCouponMaxDiscountAmount { get; set; }

            /// <summary>
            /// 最小使用金额
            /// </summary>
            [JsonPropertyName("mall_coupon_min_order_amount")]
            public int? MallCouponMinOrderAmount { get; set; }

            /// <summary>
            /// 店铺券余量
            /// </summary>
            [JsonPropertyName("mall_coupon_remain_quantity")]
            public long? MallCouponRemainQuantity { get; set; }

            /// <summary>
            /// 店铺券使用开始时间
            /// </summary>
            [JsonPropertyName("mall_coupon_start_time")]
            public long? MallCouponStartTime { get; set; }

            /// <summary>
            /// 店铺券总量
            /// </summary>
            [JsonPropertyName("mall_coupon_total_quantity")]
            public long? MallCouponTotalQuantity { get; set; }

            /// <summary>
            /// 该商品所在店铺是否参与全店推广，0：否，1：是
            /// </summary>
            [JsonPropertyName("mall_cps")]
            public int? MallCps { get; set; }

            /// <summary>
            /// 商家id
            /// </summary>
            [JsonPropertyName("mall_id")]
            public long? MallId { get; set; }

            /// <summary>
            /// 店铺logo图
            /// </summary>
            [JsonPropertyName("mall_img_url")]
            public string MallImgUrl { get; set; }

            /// <summary>
            /// 店铺名称
            /// </summary>
            [JsonPropertyName("mall_name")]
            public string MallName { get; set; }

            /// <summary>
            /// 商品素材列表
            /// </summary>
            [JsonPropertyName("material_list")]
            public List<MaterialListResponse> MaterialList { get; set; }

            /// <summary>
            /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店（未传为全部）
            /// </summary>
            [JsonPropertyName("merchant_type")]
            public int? MerchantType { get; set; }

            /// <summary>
            /// 最低价sku的拼团价，单位为分
            /// </summary>
            [JsonPropertyName("min_group_price")]
            public long? MinGroupPrice { get; set; }

            /// <summary>
            /// 最低价sku的单买价，单位为分
            /// </summary>
            [JsonPropertyName("min_normal_price")]
            public long? MinNormalPrice { get; set; }

            /// <summary>
            /// 快手专享
            /// </summary>
            [JsonPropertyName("only_scene_auth")]
            public bool? OnlySceneAuth { get; set; }

            /// <summary>
            /// 商品标签ID，使用pdd.goods.opt.get接口获取
            /// </summary>
            [JsonPropertyName("opt_id")]
            public long? OptId { get; set; }

            /// <summary>
            /// 商品标签ID
            /// </summary>
            [JsonPropertyName("opt_ids")]
            public List<int?> OptIds { get; set; }

            /// <summary>
            /// 商品标签名称
            /// </summary>
            [JsonPropertyName("opt_name")]
            public string OptName { get; set; }

            /// <summary>
            /// 推广计划类型: 1-全店推广 2-单品推广 3-定向推广 4-招商推广 5-分销推广
            /// </summary>
            [JsonPropertyName("plan_type")]
            public int? PlanType { get; set; }

            /// <summary>
            /// 比价行为预判定佣金，需要用户备案
            /// </summary>
            [JsonPropertyName("predict_promotion_rate")]
            public long? PredictPromotionRate { get; set; }

            /// <summary>
            /// 佣金比例，千分比
            /// </summary>
            [JsonPropertyName("promotion_rate")]
            public long? PromotionRate { get; set; }

            /// <summary>
            /// 已售卖件数
            /// </summary>
            [JsonPropertyName("sales_tip")]
            public string SalesTip { get; set; }

            /// <summary>
            /// 服务分
            /// </summary>
            [JsonPropertyName("serv_txt")]
            public string ServTxt { get; set; }

            /// <summary>
            /// 服务标签: 1-全场包邮,2-七天退换,3-退货包运费,4-送货入户并安装,5-送货入户,6-电子发票,7-诚信发货,8-缺重包赔,9-坏果包赔,10-果重保证,11-闪电退款,12-24小时发货,13-48小时发货,14-免税费,15-假一罚十,16-贴心服务,17-顺丰包邮,18-只换不修,19-全国联保,20-分期付款,21-纸质发票,22-上门安装,23-爱心助农,24-极速退款,25-品质保障,26-缺重包退,27-当日发货,28-可定制化,29-预约配送,30-商品进口,31-电器城,1000001-正品发票,1000002-送货入户并安装,2000001-价格保护
            /// </summary>
            [JsonPropertyName("service_tags")]
            public List<int?> ServiceTags { get; set; }

            /// <summary>
            /// 招商分成服务费比例，千分比
            /// </summary>
            [JsonPropertyName("share_rate")]
            public int? ShareRate { get; set; }

            /// <summary>
            /// sku列表
            /// </summary>
            [JsonPropertyName("sku_list")]
            public List<SkuListResponse> SkuList { get; set; }

            /// <summary>
            /// 优势渠道专属商品补贴金额，单位为分。针对优质渠道的补贴活动，指定优势渠道可通过推广该商品获取相应补贴。补贴活动入口：[进宝网站-官方活动]
            /// </summary>
            [JsonPropertyName("subsidy_amount")]
            public int? SubsidyAmount { get; set; }

            /// <summary>
            /// 官方活动给渠道的收入补贴金额，不允许直接给下级代理展示，单位为分
            /// </summary>
            [JsonPropertyName("subsidy_duo_amount_ten_million")]
            public int? SubsidyDuoAmountTenMillion { get; set; }

            /// <summary>
            /// 优惠标签列表，包括："X元券","比全网低X元","服务费","精选素材","近30天低价","同款低价","同款好评","同款热销","旗舰店","一降到底","招商优选","商家优选","好价再降X元","全站销量XX","实时热销榜第X名","实时好评榜第X名","额外补X元"等
            /// </summary>
            [JsonPropertyName("unified_tags")]
            public List<string> UnifiedTags { get; set; }

            /// <summary>
            /// 商品视频url
            /// </summary>
            [JsonPropertyName("video_urls")]
            public List<string> VideoUrls { get; set; }

            /// <summary>
            /// 招商团长id
            /// </summary>
            [JsonPropertyName("zs_duo_id")]
            public long? ZsDuoId { get; set; }

            /// <summary>
            /// 补贴活动类型：0-无补贴，1-千万补贴，4-千万神券，6-佣金翻倍
            /// </summary>
            [JsonPropertyName("subsidy_goods_type")]
            public int? SubsidyGoodsType { get; set; }
            public partial class MaterialListResponse : PddResponseModel
            {

                /// <summary>
                /// 素材ID
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; }

                /// <summary>
                /// 图片列表
                /// </summary>
                [JsonPropertyName("image_list")]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// 文字列表
                /// </summary>
                [JsonPropertyName("text_list")]
                public List<string> TextList { get; set; }

                /// <summary>
                /// 视频缩略图
                /// </summary>
                [JsonPropertyName("thumbnail_url")]
                public string ThumbnailUrl { get; set; }

                /// <summary>
                /// 素材类型，1-图文，2-视频
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// 视频url
                /// </summary>
                [JsonPropertyName("video_url")]
                public string VideoUrl { get; set; }

            }
            public partial class SkuListResponse : PddResponseModel
            {

                /// <summary>
                /// 上下架状态: 1-上架, 0-下架
                /// </summary>
                [JsonPropertyName("is_onsale")]
                public int? IsOnsale { get; set; }

                /// <summary>
                /// 进宝算价结果，单位分
                /// </summary>
                [JsonPropertyName("jinbao_goods_price")]
                public long? JinbaoGoodsPrice { get; set; }

                /// <summary>
                /// 最小成团价，单位分
                /// </summary>
                [JsonPropertyName("min_group_price")]
                public long? MinGroupPrice { get; set; }

                /// <summary>
                /// sku预览图
                /// </summary>
                [JsonPropertyName("sku_thumb_url")]
                public string SkuThumbUrl { get; set; }

                /// <summary>
                /// 商品规格列表
                /// </summary>
                [JsonPropertyName("spec_list")]
                public List<SpecListResponse> SpecList { get; set; }
                public partial class SpecListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 规格备注
                    /// </summary>
                    [JsonPropertyName("note")]
                    public string Note { get; set; }

                    /// <summary>
                    /// 父规格id
                    /// </summary>
                    [JsonPropertyName("parent_spec_id")]
                    public long? ParentSpecId { get; set; }

                    /// <summary>
                    /// 父规格名称。例如："型号"为父规格名称，"xx款"为该父规格下的子规格名称。
                    /// </summary>
                    [JsonPropertyName("parent_spec_value")]
                    public string ParentSpecValue { get; set; }

                    /// <summary>
                    /// 规格id
                    /// </summary>
                    [JsonPropertyName("spec_id")]
                    public long? SpecId { get; set; }

                    /// <summary>
                    /// 规格名称。例如："xx款"为规格名称, "型号"为该规格的父规格名称。
                    /// </summary>
                    [JsonPropertyName("spec_value")]
                    public string SpecValue { get; set; }

                }

            }

        }

    }

}

