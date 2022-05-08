namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsCommitDetailResponse : PddResponseModel
{

    /// <summary>
    /// 返回response
    /// </summary>
    [JsonPropertyName("goods_commit_detail_response")]
    public GoodsCommitDetailResponseResponse GoodsCommitDetailResponse { get; set; }
    public partial class GoodsCommitDetailResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 坏果包赔
        /// </summary>
        [JsonPropertyName("bad_fruit_claim")]
        public int? BadFruitClaim { get; set; }

        /// <summary>
        /// 限购次数
        /// </summary>
        [JsonPropertyName("buy_limit")]
        public long? BuyLimit { get; set; }

        /// <summary>
        /// 商品轮播图列表
        /// </summary>
        [JsonPropertyName("carousel_gallery_list")]
        public List<string> CarouselGalleryList { get; set; }

        /// <summary>
        /// 商品视频
        /// </summary>
        [JsonPropertyName("carousel_video")]
        public List<CarouselVideoResponse> CarouselVideo { get; set; }

        /// <summary>
        /// 轮播视频
        /// </summary>
        [JsonPropertyName("carousel_video_url")]
        public int? CarouselVideoUrl { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("cat_id")]
        public long? CatId { get; set; }

        /// <summary>
        /// 驳回原因，仅在status=2时返回，其余状态返回空值
        /// </summary>
        [JsonPropertyName("commit_message")]
        public string CommitMessage { get; set; }

        /// <summary>
        /// 运费模版id
        /// </summary>
        [JsonPropertyName("cost_template_id")]
        public long? CostTemplateId { get; set; }

        /// <summary>
        /// 地区/国家id
        /// </summary>
        [JsonPropertyName("country_id")]
        public long? CountryId { get; set; }

        /// <summary>
        /// 团购人数
        /// </summary>
        [JsonPropertyName("customer_num")]
        public long? CustomerNum { get; set; }

        /// <summary>
        /// 海关名称
        /// </summary>
        [JsonPropertyName("customs")]
        public string Customs { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [JsonPropertyName("deleted")]
        public int? Deleted { get; set; }

        /// <summary>
        /// 是否当日发货,0 否，1 是
        /// </summary>
        [JsonPropertyName("delivery_one_day")]
        public int? DeliveryOneDay { get; set; }

        /// <summary>
        /// 发货方式。0：无物流发货；1：有物流发货。
        /// </summary>
        [JsonPropertyName("delivery_type")]
        public int? DeliveryType { get; set; }

        /// <summary>
        /// 商品详情图
        /// </summary>
        [JsonPropertyName("detail_gallery_list")]
        public List<string> DetailGalleryList { get; set; }

        /// <summary>
        /// 卡券类商品属性
        /// </summary>
        [JsonPropertyName("elec_goods_attributes")]
        public ElecGoodsAttributesResponse ElecGoodsAttributes { get; set; }

        /// <summary>
        /// 提交申请的序列ID
        /// </summary>
        [JsonPropertyName("goods_commit_id")]
        public long? GoodsCommitId { get; set; }

        /// <summary>
        /// 商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
        /// </summary>
        [JsonPropertyName("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        [JsonPropertyName("goods_property_list")]
        public List<GoodsPropertyListResponse> GoodsPropertyList { get; set; }

        /// <summary>
        /// 商品状态，枚举：0-编辑中，1-待审核，2-审核通过，3-审核驳回
        /// </summary>
        [JsonPropertyName("goods_status")]
        public int? GoodsStatus { get; set; }

        /// <summary>
        /// 日历商品交易相关信息
        /// </summary>
        [JsonPropertyName("goods_trade_attr")]
        public GoodsTradeAttrResponse GoodsTradeAttr { get; set; }

        /// <summary>
        /// 商品出行信息
        /// </summary>
        [JsonPropertyName("goods_travel_attr")]
        public GoodsTravelAttrResponse GoodsTravelAttr { get; set; }

        /// <summary>
        /// 商品类型：1-国内普通商品，2-一般贸易，3-保税仓BBC直供，4-海外BC直邮 ,5-流量 ,6-话费 ,7-优惠券 ,8-QQ充值 ,9-加油卡，15-商家卡券，18-海外CC行邮 19-平台卡券
        /// </summary>
        [JsonPropertyName("goods_type")]
        public int? GoodsType { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 是否支持正品发票；0-不支持、1-支持
        /// </summary>
        [JsonPropertyName("invoice_status")]
        public int? InvoiceStatus { get; set; }

        /// <summary>
        /// 是否需要上报海关 0:否 1:是
        /// </summary>
        [JsonPropertyName("is_customs")]
        public int? IsCustoms { get; set; }

        /// <summary>
        /// 是否支持假一赔十，0-不支持，1-支持
        /// </summary>
        [JsonPropertyName("is_folt")]
        public int? IsFolt { get; set; }

        /// <summary>
        /// 是否成团预售。0：不是；1:是。
        /// </summary>
        [JsonPropertyName("is_group_pre_sale")]
        public int? IsGroupPreSale { get; set; }

        /// <summary>
        /// 是否预售,true-预售商品，false-非预售商品
        /// </summary>
        [JsonPropertyName("is_pre_sale")]
        public int? IsPreSale { get; set; }

        /// <summary>
        /// 是否7天无理由退换货，1-支持，0-不支持
        /// </summary>
        [JsonPropertyName("is_refundable")]
        public int? IsRefundable { get; set; }

        /// <summary>
        /// 是否sku预售，0：否，1：是
        /// </summary>
        [JsonPropertyName("is_sku_pre_sale")]
        public int? IsSkuPreSale { get; set; }

        /// <summary>
        /// 缺重包退
        /// </summary>
        [JsonPropertyName("lack_of_weight_claim")]
        public int? LackOfWeightClaim { get; set; }

        /// <summary>
        /// 买家自提模版id
        /// </summary>
        [JsonPropertyName("mai_jia_zi_ti")]
        public string MaiJiaZiTi { get; set; }

        /// <summary>
        /// 参考价格，单位为分
        /// </summary>
        [JsonPropertyName("market_price")]
        public long? MarketPrice { get; set; }

        /// <summary>
        /// 单次限量
        /// </summary>
        [JsonPropertyName("order_limit")]
        public long? OrderLimit { get; set; }

        /// <summary>
        /// 原产地id，是指海淘商品的生产地址
        /// </summary>
        [JsonPropertyName("origin_country_id")]
        public int? OriginCountryId { get; set; }

        /// <summary>
        /// 第三方商品Id
        /// </summary>
        [JsonPropertyName("out_source_goods_id")]
        public string OutSourceGoodsId { get; set; }

        /// <summary>
        /// 第三方商品来源
        /// </summary>
        [JsonPropertyName("out_source_type")]
        public int? OutSourceType { get; set; }

        /// <summary>
        /// 商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）
        /// </summary>
        [JsonPropertyName("outer_goods_id")]
        public string OuterGoodsId { get; set; }

        /// <summary>
        /// oversea_goods
        /// </summary>
        [JsonPropertyName("oversea_goods")]
        public OverseaGoodsResponse OverseaGoods { get; set; }

        /// <summary>
        /// oversea_type
        /// </summary>
        [JsonPropertyName("oversea_type")]
        public int? OverseaType { get; set; }

        /// <summary>
        /// 预售时间
        /// </summary>
        [JsonPropertyName("pre_sale_time")]
        public long? PreSaleTime { get; set; }

        /// <summary>
        /// 0：不支持全国联保；1：支持全国联保
        /// </summary>
        [JsonPropertyName("quan_guo_lian_bao")]
        public int? QuanGuoLianBao { get; set; }

        /// <summary>
        /// 是否二手
        /// </summary>
        [JsonPropertyName("second_hand")]
        public int? SecondHand { get; set; }

        /// <summary>
        /// 上门安装模版id
        /// </summary>
        [JsonPropertyName("shang_men_an_zhuang")]
        public string ShangMenAnZhuang { get; set; }

        /// <summary>
        /// 承诺发货时间（ 秒）
        /// </summary>
        [JsonPropertyName("shipment_limit_second")]
        public long? ShipmentLimitSecond { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [JsonPropertyName("sku_list")]
        public List<SkuListResponse> SkuList { get; set; }

        /// <summary>
        /// 日历商品库存方式（0：普通型，1：日历型）
        /// </summary>
        [JsonPropertyName("sku_type")]
        public int? SkuType { get; set; }

        /// <summary>
        /// 送货入户并安装模版id
        /// </summary>
        [JsonPropertyName("song_huo_an_zhuang")]
        public string SongHuoAnZhuang { get; set; }

        /// <summary>
        /// 送货入户模版id
        /// </summary>
        [JsonPropertyName("song_huo_ru_hu")]
        public string SongHuoRuHu { get; set; }

        /// <summary>
        /// 新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
        /// </summary>
        [JsonPropertyName("tiny_name")]
        public string TinyName { get; set; }

        /// <summary>
        /// 满2件折扣，可选范围0-100, 0表示取消，95表示95折，设置需先查询规则接口获取实际可填范围
        /// </summary>
        [JsonPropertyName("two_pieces_discount")]
        public int? TwoPiecesDiscount { get; set; }

        /// <summary>
        /// 保税仓
        /// </summary>
        [JsonPropertyName("warehouse")]
        public string Warehouse { get; set; }

        /// <summary>
        /// 水果类目温馨提示
        /// </summary>
        [JsonPropertyName("warm_tips")]
        public string WarmTips { get; set; }

        /// <summary>
        /// 只换不修的天数，目前只支持0和365
        /// </summary>
        [JsonPropertyName("zhi_huan_bu_xiu")]
        public int? ZhiHuanBuXiu { get; set; }
        public partial class CarouselVideoResponse : PddResponseModel
        {

            /// <summary>
            /// 商品视频id
            /// </summary>
            [JsonPropertyName("file_id")]
            public long? FileId { get; set; }

            /// <summary>
            /// 商品视频url
            /// </summary>
            [JsonPropertyName("video_url")]
            public string VideoUrl { get; set; }

        }
        public partial class ElecGoodsAttributesResponse : PddResponseModel
        {

            /// <summary>
            /// 开始时间（timeType=1时必填表示核销的开始时间）（精确到毫秒）
            /// </summary>
            [JsonPropertyName("begin_time")]
            public long? BeginTime { get; set; }

            /// <summary>
            /// 天数内有效（timeType=3必填，表示发货后几天内核销）
            /// </summary>
            [JsonPropertyName("days_time")]
            public int? DaysTime { get; set; }

            /// <summary>
            /// 截止时间（timeType=1,2时必填，表示发货后核销的截止时间）（精确到毫秒）
            /// </summary>
            [JsonPropertyName("end_time")]
            public long? EndTime { get; set; }

            /// <summary>
            /// 卡券核销类型（1：起始时间内有效，2：发货后后至截止时间内有效，3：发货后多少天内有效）
            /// </summary>
            [JsonPropertyName("time_type")]
            public int? TimeType { get; set; }

        }
        public partial class GoodsPropertyListResponse : PddResponseModel
        {

            /// <summary>
            /// 属性单位
            /// </summary>
            [JsonPropertyName("punit")]
            public string Punit { get; set; }

            /// <summary>
            /// 引用属性id
            /// </summary>
            [JsonPropertyName("ref_pid")]
            public long? RefPid { get; set; }

            /// <summary>
            /// 模板属性Id
            /// </summary>
            [JsonPropertyName("template_pid")]
            public long? TemplatePid { get; set; }

            /// <summary>
            /// 基础属性值Id
            /// </summary>
            [JsonPropertyName("vid")]
            public long? Vid { get; set; }

            /// <summary>
            /// 基础属性值
            /// </summary>
            [JsonPropertyName("vvalue")]
            public string Vvalue { get; set; }

        }
        public partial class GoodsTradeAttrResponse : PddResponseModel
        {

            /// <summary>
            /// 提前预定天数
            /// </summary>
            [JsonPropertyName("advances_days")]
            public int? AdvancesDays { get; set; }

            /// <summary>
            /// 卡券有效期，日历日期后多少天可用。默认值为0表示仅限日历日当天使用.
            /// </summary>
            [JsonPropertyName("life_span")]
            public int? LifeSpan { get; set; }

        }
        public partial class GoodsTravelAttrResponse : PddResponseModel
        {

            /// <summary>
            /// 是否需要出行人信息
            /// </summary>
            [JsonPropertyName("need_tourist")]
            public bool? NeedTourist { get; set; }

            /// <summary>
            /// 1:旅行类,2:住宿类,3:票务类
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

        }
        public partial class OverseaGoodsResponse : PddResponseModel
        {

            /// <summary>
            /// 保税仓唯一标识
            /// </summary>
            [JsonPropertyName("bonded_warehouse_key")]
            public string BondedWarehouseKey { get; set; }

            /// <summary>
            /// 消费税率
            /// </summary>
            [JsonPropertyName("consumption_tax_rate")]
            public int? ConsumptionTaxRate { get; set; }

            /// <summary>
            /// 清关服务商
            /// </summary>
            [JsonPropertyName("customs_broker")]
            public string CustomsBroker { get; set; }

            /// <summary>
            /// 海关编号
            /// </summary>
            [JsonPropertyName("hs_code")]
            public string HsCode { get; set; }

            /// <summary>
            /// 增值税率
            /// </summary>
            [JsonPropertyName("value_added_tax_rate")]
            public int? ValueAddedTaxRate { get; set; }

        }
        public partial class SkuListResponse : PddResponseModel
        {

            /// <summary>
            /// 上下架状态 1：上架 0 ：下架
            /// </summary>
            [JsonPropertyName("is_onsale")]
            public int? IsOnsale { get; set; }

            /// <summary>
            /// sku送装参数：长度
            /// </summary>
            [JsonPropertyName("lengtj")]
            public long? Lengtj { get; set; }

            /// <summary>
            /// sku购买限制
            /// </summary>
            [JsonPropertyName("limit_quantity")]
            public long? LimitQuantity { get; set; }

            /// <summary>
            /// 商品团购价格 单位分
            /// </summary>
            [JsonPropertyName("multi_price")]
            public long? MultiPrice { get; set; }

            /// <summary>
            /// 商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）
            /// </summary>
            [JsonPropertyName("out_sku_sn")]
            public string OutSkuSn { get; set; }

            /// <summary>
            /// 第三方sku Id
            /// </summary>
            [JsonPropertyName("out_source_sku_id")]
            public string OutSourceSkuId { get; set; }

            /// <summary>
            /// oversea_sku
            /// </summary>
            [JsonPropertyName("oversea_sku")]
            public OverseaSkuResponse OverseaSku { get; set; }

            /// <summary>
            /// 商品单买价格 单位分
            /// </summary>
            [JsonPropertyName("price")]
            public long? Price { get; set; }

            /// <summary>
            /// 库存
            /// </summary>
            [JsonPropertyName("quantity")]
            public long? Quantity { get; set; }

            /// <summary>
            /// sku编码
            /// </summary>
            [JsonPropertyName("sku_id")]
            public long? SkuId { get; set; }

            /// <summary>
            /// sku预售时间，单位秒
            /// </summary>
            [JsonPropertyName("sku_pre_sale_time")]
            public int? SkuPreSaleTime { get; set; }

            /// <summary>
            /// sku属性
            /// </summary>
            [JsonPropertyName("sku_property_list")]
            public List<SkuPropertyListResponse> SkuPropertyList { get; set; }

            /// <summary>
            /// 商品规格列表
            /// </summary>
            [JsonPropertyName("spec")]
            public List<SpecResponse> Spec { get; set; }

            /// <summary>
            /// sku预览图
            /// </summary>
            [JsonPropertyName("thumb_url")]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// 重量，单位为g
            /// </summary>
            [JsonPropertyName("weight")]
            public long? Weight { get; set; }
            public partial class OverseaSkuResponse : PddResponseModel
            {

                /// <summary>
                /// 计量单位编码，从接口pdd.gooods.sku.measurement.list获取desc
                /// </summary>
                [JsonPropertyName("measurement_code")]
                public string MeasurementCode { get; set; }

                /// <summary>
                /// 规格
                /// </summary>
                [JsonPropertyName("specifications")]
                public string Specifications { get; set; }

                /// <summary>
                /// 税费
                /// </summary>
                [JsonPropertyName("taxation")]
                public int? Taxation { get; set; }

            }
            public partial class SkuPropertyListResponse : PddResponseModel
            {

                /// <summary>
                /// 属性单位
                /// </summary>
                [JsonPropertyName("punit")]
                public string Punit { get; set; }

                /// <summary>
                /// 属性id
                /// </summary>
                [JsonPropertyName("ref_pid")]
                public long? RefPid { get; set; }

                /// <summary>
                /// 属性值
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; }

                /// <summary>
                /// 属性值id
                /// </summary>
                [JsonPropertyName("vid")]
                public long? Vid { get; set; }

            }
            public partial class SpecResponse : PddResponseModel
            {

                /// <summary>
                /// 商品规格对应的ID
                /// </summary>
                [JsonPropertyName("parent_id")]
                public long? ParentId { get; set; }

                /// <summary>
                /// 商品规格ID对应的规格名称
                /// </summary>
                [JsonPropertyName("parent_name")]
                public string ParentName { get; set; }

                /// <summary>
                /// 生成的自定义规格ID
                /// </summary>
                [JsonPropertyName("spec_id")]
                public long? SpecId { get; set; }

                /// <summary>
                /// 商家编辑的规格值，如颜色规格下设置白色属性
                /// </summary>
                [JsonPropertyName("spec_name")]
                public string SpecName { get; set; }

            }

        }

    }

}

