namespace PddOpenSdk.Models.Request.Goods;
public partial class CommitGoodsEditGoods
{

    /// <summary>
    /// 是否自动补充标品属性
    /// </summary>
    [JsonPropertyName("auto_fill_spu_property")]
    public bool? AutoFillSpuProperty { get; set; }

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
    /// 商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB
    /// </summary>
    [JsonPropertyName("carousel_gallery")]
    public List<string> CarouselGallery { get; set; }

    /// <summary>
    /// 商品视频
    /// </summary>
    [JsonPropertyName("carousel_video")]
    public List<CarouselVideoModel> CarouselVideo { get; set; }

    /// <summary>
    /// 轮播视频
    /// </summary>
    [JsonPropertyName("carousel_video_url")]
    public string CarouselVideoUrl { get; set; }

    /// <summary>
    /// 叶子类目ID
    /// </summary>
    [JsonPropertyName("cat_id")]
    public long CatId { get; set; }

    /// <summary>
    /// 物流运费模板ID，可使用pdd.logistics.template.get获取
    /// </summary>
    [JsonPropertyName("cost_template_id")]
    public long? CostTemplateId { get; set; }

    /// <summary>
    /// 地区/国家ID，0-中国，暂时只传0（普通商品）
    /// </summary>
    [JsonPropertyName("country_id")]
    public int? CountryId { get; set; }

    /// <summary>
    /// 团购人数
    /// </summary>
    [JsonPropertyName("customer_num")]
    public long? CustomerNum { get; set; }

    /// <summary>
    /// 海关名称，只在goods_type为直供商品时有效（现阶段暂不支持）
    /// </summary>
    [JsonPropertyName("customs")]
    public string Customs { get; set; }

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
    /// 商品详情图：; a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间; b. 大小1M以内; c. 数量限制在20张之间; d. 图片格式仅支持JPG,PNG格式; e. 点击上传时，支持批量上传详情图
    /// </summary>
    [JsonPropertyName("detail_gallery")]
    public List<string> DetailGallery { get; set; }

    /// <summary>
    /// 卡券类商品属性
    /// </summary>
    [JsonPropertyName("elec_goods_attributes")]
    public ElecGoodsAttributesModel ElecGoodsAttributes { get; set; }

    /// <summary>
    /// 商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
    /// </summary>
    [JsonPropertyName("goods_desc")]
    public string GoodsDesc { get; set; }

    /// <summary>
    /// 商品标题，例如，新疆特产 红满疆枣夹核桃500g
    /// </summary>
    [JsonPropertyName("goods_name")]
    public string GoodsName { get; set; }

    /// <summary>
    /// 商品属性列表
    /// </summary>
    [JsonPropertyName("goods_properties")]
    public List<GoodsPropertiesModel> GoodsProperties { get; set; }

    /// <summary>
    /// 日历商品交易相关信息
    /// </summary>
    [JsonPropertyName("goods_trade_attr")]
    public GoodsTradeAttrModel GoodsTradeAttr { get; set; }

    /// <summary>
    /// 商品出行信息
    /// </summary>
    [JsonPropertyName("goods_travel_attr")]
    public GoodsTravelAttrModel GoodsTravelAttr { get; set; }

    /// <summary>
    /// 1-国内普通商品，2-一般贸易，3-保税仓BBC直供，4-海外BC直邮 ,5-流量 ,6-话费 ,7-优惠券 ,8-QQ充值 ,9-加油卡，15-商家卡券，18-海外CC行邮 19-平台卡券
    /// </summary>
    [JsonPropertyName("goods_type")]
    public int? GoodsType { get; set; }

    /// <summary>
    /// 商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动; a. 尺寸750 x 352px; b. 大小100k以内; c. 图片格式仅支持JPG,PNG格式; d. 图片背景应以纯白为主, 商品图案居中显示; e. 图片不可以添加任何品牌相关文字或logo
    /// </summary>
    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// 是否支持正品发票；0-不支持、1-支持
    /// </summary>
    [JsonPropertyName("invoice_status")]
    public int? InvoiceStatus { get; set; }

    /// <summary>
    /// 是否需要上报海关，现阶段入参默认false，入参true会失败
    /// </summary>
    [JsonPropertyName("is_customs")]
    public bool? IsCustoms { get; set; }

    /// <summary>
    /// 是否支持假一赔十，false-不支持，true-支持
    /// </summary>
    [JsonPropertyName("is_folt")]
    public bool? IsFolt { get; set; }

    /// <summary>
    /// 是否成团预售。0：不是；1:是。
    /// </summary>
    [JsonPropertyName("is_group_pre_sale")]
    public int? IsGroupPreSale { get; set; }

    /// <summary>
    /// 是否预售,true-预售商品，false-非预售商品
    /// </summary>
    [JsonPropertyName("is_pre_sale")]
    public bool? IsPreSale { get; set; }

    /// <summary>
    /// 是否7天无理由退换货，true-支持，false-不支持
    /// </summary>
    [JsonPropertyName("is_refundable")]
    public bool? IsRefundable { get; set; }

    /// <summary>
    /// 是否sku预售，1：是，0：否
    /// </summary>
    [JsonPropertyName("is_sku_pre_sale")]
    public int? IsSkuPreSale { get; set; }

    /// <summary>
    /// 缺重包退
    /// </summary>
    [JsonPropertyName("lack_of_weight_claim")]
    public int? LackOfWeightClaim { get; set; }

    /// <summary>
    /// 本地服务id
    /// </summary>
    [JsonPropertyName("local_service_id_list")]
    public List<int?> LocalServiceIdList { get; set; }

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
    /// 原产地id，是指海淘商品的生产地址，仅在goods type=3/4的时候必填，可以通过pdd.goods.country.get获取
    /// </summary>
    [JsonPropertyName("origin_country_id")]
    public int? OriginCountryId { get; set; }

    /// <summary>
    /// 商品goods外部编码
    /// </summary>
    [JsonPropertyName("out_goods_id")]
    public string OutGoodsId { get; set; }

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
    /// {; 	"consumption_tax_rate": 1,; 	"value_added_tax_rate": 9,; 	"hs_code": "2200",; 	"customs_broker": "sss",; 	"customs_declaration_method": 1,; 	"bonded_warehouse": "sss",; 	"bonded_warehouse_key": "pp"; }
    /// </summary>
    [JsonPropertyName("oversea_goods")]
    public OverseaGoodsModel OverseaGoods { get; set; }

    /// <summary>
    /// oversea_type
    /// </summary>
    [JsonPropertyName("oversea_type")]
    public int? OverseaType { get; set; }

    /// <summary>
    /// 预售时间，is_pre_sale为1时必传，UNIX时间戳
    /// </summary>
    [JsonPropertyName("pre_sale_time")]
    public long? PreSaleTime { get; set; }

    /// <summary>
    /// 0：不支持全国联保；1：支持全国联保
    /// </summary>
    [JsonPropertyName("quan_guo_lian_bao")]
    public int? QuanGuoLianBao { get; set; }

    /// <summary>
    /// 是否二手商品，true -二手商品 ，false-全新商品
    /// </summary>
    [JsonPropertyName("second_hand")]
    public bool? SecondHand { get; set; }

    /// <summary>
    /// 上门安装模版id
    /// </summary>
    [JsonPropertyName("shang_men_an_zhuang")]
    public string ShangMenAnZhuang { get; set; }

    /// <summary>
    /// 承诺发货时间（ 秒），48小时或24小时，is_pre_sale为1时不必传
    /// </summary>
    [JsonPropertyName("shipment_limit_second")]
    public long? ShipmentLimitSecond { get; set; }

    /// <summary>
    /// 门店组id
    /// </summary>
    [JsonPropertyName("shop_group_id")]
    public long? ShopGroupId { get; set; }

    /// <summary>
    /// 尺码表id
    /// </summary>
    [JsonPropertyName("size_spec_id")]
    public long? SizeSpecId { get; set; }

    /// <summary>
    /// sku对象列表,实例：[{; 	"is_onsale": 1,; 	"limit_quantity": 999,; 	"price": "2200",; 	"weight": 1000,; 	"multi_price": "1900",; 	"thumb_url": "http://t06img.yangkeduo.com/images/2018-04-15/ced035033b5d40b589140af882621c03.jpg",; 	"out_sku_sn": "L",; 	"quantity": 100,; 	"spec_id_list": "[25]",; 	"oversea_sku": {; 		"measurement_code": "计量单位编码",; 		"taxation": "税费",; 		"specifications": "规格"; 	}; }]
    /// </summary>
    [JsonPropertyName("sku_list")]
    public List<SkuListModel> SkuList { get; set; }

    /// <summary>
    /// 库存方式（0：普通型，1：日历型）
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
    /// 商品短标题（仅在部分活动中生效），字数限制为4-20字
    /// </summary>
    [JsonPropertyName("tiny_name")]
    public string TinyName { get; set; }

    /// <summary>
    /// 满2件折扣，可选范围0-100, 0表示取消，95表示95折，设置需先查询规则接口获取实际可填范围
    /// </summary>
    [JsonPropertyName("two_pieces_discount")]
    public int? TwoPiecesDiscount { get; set; }

    /// <summary>
    /// 保税仓，只在goods_type为直供商品时有效（现阶段暂不支持）
    /// </summary>
    [JsonPropertyName("warehouse")]
    public string Warehouse { get; set; }

    /// <summary>
    /// 水果类目温馨提示，只在水果类目商品才生效， 字数限制：商品描述goods_desc+温馨提示总计不超过500字。
    /// </summary>
    [JsonPropertyName("warm_tips")]
    public string WarmTips { get; set; }

    /// <summary>
    /// 只换不修的天数，目前只支持0和365
    /// </summary>
    [JsonPropertyName("zhi_huan_bu_xiu")]
    public int? ZhiHuanBuXiu { get; set; }
    public partial class CarouselVideoModel
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
    public partial class ElecGoodsAttributesModel
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
        /// 截止时间（timeType=1,2时必填，表示发货后核销的截止时间）（精确到毫秒
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// 卡券核销类型（1：起始时间内有效，2：发货后后至截止时间内有效，3：发货后多少天内有效）
        /// </summary>
        [JsonPropertyName("time_type")]
        public int? TimeType { get; set; }

    }
    public partial class GoodsPropertiesModel
    {

        /// <summary>
        /// 组id，非销售属性不用传
        /// </summary>
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// 图片url，非销售属性不用传
        /// </summary>
        [JsonPropertyName("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 备注，非销售属性不用传
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// 父属性id，非销售属性不用传
        /// </summary>
        [JsonPropertyName("parent_spec_id")]
        public long? ParentSpecId { get; set; }

        /// <summary>
        /// 引用属性ID
        /// </summary>
        [JsonPropertyName("ref_pid")]
        public long? RefPid { get; set; }

        /// <summary>
        /// 属性id，非销售属性不用传
        /// </summary>
        [JsonPropertyName("spec_id")]
        public long? SpecId { get; set; }

        /// <summary>
        /// 模板属性id
        /// </summary>
        [JsonPropertyName("template_pid")]
        public long? TemplatePid { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// 属性单位
        /// </summary>
        [JsonPropertyName("value_unit")]
        public string ValueUnit { get; set; }

        /// <summary>
        /// 属性值id
        /// </summary>
        [JsonPropertyName("vid")]
        public long? Vid { get; set; }

    }
    public partial class GoodsTradeAttrModel
    {

        /// <summary>
        /// 提前预定天数，默认为0表示当天可预定
        /// </summary>
        [JsonPropertyName("advances_days")]
        public int? AdvancesDays { get; set; }

        /// <summary>
        /// 预订须知
        /// </summary>
        [JsonPropertyName("booking_notes")]
        public BookingNotesModel BookingNotes { get; set; }

        /// <summary>
        /// 卡券有效期，日历日期后多少天可用。默认值为0表示仅限日历日当天使用
        /// </summary>
        [JsonPropertyName("life_span")]
        public int? LifeSpan { get; set; }
        public partial class BookingNotesModel
        {

            /// <summary>
            /// 预定须知图片地址
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; }

        }

    }
    public partial class GoodsTravelAttrModel
    {

        /// <summary>
        /// 出行人是否必填（默认是）
        /// </summary>
        [JsonPropertyName("need_tourist")]
        public bool? NeedTourist { get; set; }

        /// <summary>
        /// 日历商品类型1:旅行类,2:住宿类,3:票务类
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

    }
    public partial class OverseaGoodsModel
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
    public partial class SkuListModel
    {

        /// <summary>
        /// sku上架状态，0-已下架，1-上架中
        /// </summary>
        [JsonPropertyName("is_onsale")]
        public int IsOnsale { get; set; }

        /// <summary>
        /// sku送装参数：长度
        /// </summary>
        [JsonPropertyName("length")]
        public long? Length { get; set; }

        /// <summary>
        /// sku购买限制，只入参999
        /// </summary>
        [JsonPropertyName("limit_quantity")]
        public long LimitQuantity { get; set; }

        /// <summary>
        /// 商品团购价格
        /// </summary>
        [JsonPropertyName("multi_price")]
        public long MultiPrice { get; set; }

        /// <summary>
        /// 商品sku外部编码
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
        public OverseaSkuModel OverseaSku { get; set; }

        /// <summary>
        /// 商品单买价格
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品sku库存初始数量，后续库存update只使用stocks.update接口进行调用
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku预售时间戳，单位秒；不更新传null，取消传0，更新传实际值
        /// </summary>
        [JsonPropertyName("sku_pre_sale_time")]
        public int? SkuPreSaleTime { get; set; }

        /// <summary>
        /// sku属性
        /// </summary>
        [JsonPropertyName("sku_properties")]
        public List<SkuPropertiesModel> SkuProperties { get; set; }

        /// <summary>
        /// 商品规格列表，根据pdd.goods.spec.id.get生成的规格属性id，例如：颜色规格下商家新增白色和黑色，大小规格下商家新增L和XL，则由4种spec组合，入参一种组合即可，在skulist中需要有4个spec组合的sku
        /// </summary>
        [JsonPropertyName("spec_id_list")]
        public string SpecIdList { get; set; }

        /// <summary>
        /// sku预览图，预览图尺寸：等宽高，且高度不低于480px，现已支持1M大小，越清晰越好卖，SKU预览图格式：仅支持JPG,PNG格式
        /// </summary>
        [JsonPropertyName("thumb_url")]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// 重量，单位为g
        /// </summary>
        [JsonPropertyName("weight")]
        public long Weight { get; set; }
        public partial class OverseaSkuModel
        {

            /// <summary>
            /// 计量单位编码，从接口pdd.gooods.sku.measurement.list获取code
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
            public int Taxation { get; set; }

        }
        public partial class SkuPropertiesModel
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
            public long RefPid { get; set; }

            /// <summary>
            /// 属性值
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; }

            /// <summary>
            /// 属性值id
            /// </summary>
            [JsonPropertyName("vid")]
            public long Vid { get; set; }

        }

    }

}

