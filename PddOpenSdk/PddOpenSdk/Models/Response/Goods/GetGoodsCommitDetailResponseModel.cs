using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsCommitDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("goods_commit_detail_response")]
        public GoodsCommitDetailResponseResponseModel GoodsCommitDetailResponse { get; set; }
        public partial class GoodsCommitDetailResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 坏果包赔
            /// </summary>
            [JsonProperty("bad_fruit_claim")]
            public int? BadFruitClaim { get; set; }
            /// <summary>
            /// 限购次数
            /// </summary>
            [JsonProperty("buy_limit")]
            public long? BuyLimit { get; set; }
            /// <summary>
            /// 商品轮播图列表
            /// </summary>
            [JsonProperty("carousel_gallery_list")]
            public List<string> CarouselGalleryList { get; set; }
            /// <summary>
            /// 商品视频
            /// </summary>
            [JsonProperty("carousel_video")]
            public List<CarouselVideoResponseModel> CarouselVideo { get; set; }
            /// <summary>
            /// 轮播视频
            /// </summary>
            [JsonProperty("carousel_video_url")]
            public int? CarouselVideoUrl { get; set; }
            /// <summary>
            /// 类目id
            /// </summary>
            [JsonProperty("cat_id")]
            public long? CatId { get; set; }
            /// <summary>
            /// 驳回原因，仅在status=2时返回，其余状态返回空值
            /// </summary>
            [JsonProperty("commit_message")]
            public string CommitMessage { get; set; }
            /// <summary>
            /// 运费模版id
            /// </summary>
            [JsonProperty("cost_template_id")]
            public long? CostTemplateId { get; set; }
            /// <summary>
            /// 地区/国家id
            /// </summary>
            [JsonProperty("country_id")]
            public long? CountryId { get; set; }
            /// <summary>
            /// 团购人数
            /// </summary>
            [JsonProperty("customer_num")]
            public long? CustomerNum { get; set; }
            /// <summary>
            /// 海关名称
            /// </summary>
            [JsonProperty("customs")]
            public string Customs { get; set; }
            /// <summary>
            /// 是否删除
            /// </summary>
            [JsonProperty("deleted")]
            public int? Deleted { get; set; }
            /// <summary>
            /// 是否当日发货,0 否，1 是
            /// </summary>
            [JsonProperty("delivery_one_day")]
            public int? DeliveryOneDay { get; set; }
            /// <summary>
            /// 商品详情图
            /// </summary>
            [JsonProperty("detail_gallery_list")]
            public List<string> DetailGalleryList { get; set; }
            /// <summary>
            /// 卡券类商品属性
            /// </summary>
            [JsonProperty("elec_goods_attributes")]
            public ElecGoodsAttributesResponseModel ElecGoodsAttributes { get; set; }
            /// <summary>
            /// 提交申请的序列ID
            /// </summary>
            [JsonProperty("goods_commit_id")]
            public long? GoodsCommitId { get; set; }
            /// <summary>
            /// 商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
            /// </summary>
            [JsonProperty("goods_desc")]
            public string GoodsDesc { get; set; }
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
            /// 商品属性列表
            /// </summary>
            [JsonProperty("goods_property_list")]
            public List<GoodsPropertyListResponseModel> GoodsPropertyList { get; set; }
            /// <summary>
            /// 商品状态，枚举：0-编辑中，1-待审核，2-审核通过，3-审核驳回
            /// </summary>
            [JsonProperty("goods_status")]
            public int? GoodsStatus { get; set; }
            /// <summary>
            /// 日历商品交易相关信息
            /// </summary>
            [JsonProperty("goods_trade_attr")]
            public GoodsTradeAttrResponseModel GoodsTradeAttr { get; set; }
            /// <summary>
            /// 商品出行信息
            /// </summary>
            [JsonProperty("goods_travel_attr")]
            public GoodsTravelAttrResponseModel GoodsTravelAttr { get; set; }
            /// <summary>
            /// 商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架
            /// </summary>
            [JsonProperty("goods_type")]
            public int? GoodsType { get; set; }
            /// <summary>
            /// 商品主图
            /// </summary>
            [JsonProperty("image_url")]
            public string ImageUrl { get; set; }
            /// <summary>
            /// 是否支持正品发票；0-不支持、1-支持
            /// </summary>
            [JsonProperty("invoice_status")]
            public int? InvoiceStatus { get; set; }
            /// <summary>
            /// 是否需要上报海关 0:否 1:是
            /// </summary>
            [JsonProperty("is_customs")]
            public int? IsCustoms { get; set; }
            /// <summary>
            /// 是否支持假一赔十，0-不支持，1-支持
            /// </summary>
            [JsonProperty("is_folt")]
            public int? IsFolt { get; set; }
            /// <summary>
            /// 是否预售,true-预售商品，false-非预售商品
            /// </summary>
            [JsonProperty("is_pre_sale")]
            public int? IsPreSale { get; set; }
            /// <summary>
            /// 是否7天无理由退换货，1-支持，0-不支持
            /// </summary>
            [JsonProperty("is_refundable")]
            public int? IsRefundable { get; set; }
            /// <summary>
            /// 缺重包退
            /// </summary>
            [JsonProperty("lack_of_weight_claim")]
            public int? LackOfWeightClaim { get; set; }
            /// <summary>
            /// 买家自提模版id
            /// </summary>
            [JsonProperty("mai_jia_zi_ti")]
            public string MaiJiaZiTi { get; set; }
            /// <summary>
            /// 参考价格，单位为分
            /// </summary>
            [JsonProperty("market_price")]
            public long? MarketPrice { get; set; }
            /// <summary>
            /// 单次限量
            /// </summary>
            [JsonProperty("order_limit")]
            public long? OrderLimit { get; set; }
            /// <summary>
            /// 原产地id，是指海淘商品的生产地址
            /// </summary>
            [JsonProperty("origin_country_id")]
            public int? OriginCountryId { get; set; }
            /// <summary>
            /// 商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）
            /// </summary>
            [JsonProperty("outer_goods_id")]
            public string OuterGoodsId { get; set; }
            /// <summary>
            /// 第三方商品Id
            /// </summary>
            [JsonProperty("out_source_goods_id")]
            public string OutSourceGoodsId { get; set; }
            /// <summary>
            /// 第三方商品来源
            /// </summary>
            [JsonProperty("out_source_type")]
            public int? OutSourceType { get; set; }
            /// <summary>
            /// oversea_goods
            /// </summary>
            [JsonProperty("oversea_goods")]
            public OverseaGoodsResponseModel OverseaGoods { get; set; }
            /// <summary>
            /// oversea_type
            /// </summary>
            [JsonProperty("oversea_type")]
            public int? OverseaType { get; set; }
            /// <summary>
            /// 预售时间
            /// </summary>
            [JsonProperty("pre_sale_time")]
            public long? PreSaleTime { get; set; }
            /// <summary>
            /// 0：不支持全国联保；1：支持全国联保
            /// </summary>
            [JsonProperty("quan_guo_lian_bao")]
            public int? QuanGuoLianBao { get; set; }
            /// <summary>
            /// 是否二手
            /// </summary>
            [JsonProperty("second_hand")]
            public int? SecondHand { get; set; }
            /// <summary>
            /// 上门安装模版id
            /// </summary>
            [JsonProperty("shang_men_an_zhuang")]
            public string ShangMenAnZhuang { get; set; }
            /// <summary>
            /// 承诺发货时间（ 秒）
            /// </summary>
            [JsonProperty("shipment_limit_second")]
            public long? ShipmentLimitSecond { get; set; }
            /// <summary>
            /// sku列表
            /// </summary>
            [JsonProperty("sku_list")]
            public List<SkuListResponseModel> SkuList { get; set; }
            /// <summary>
            /// 日历商品库存方式（0：普通型，1：日历型）
            /// </summary>
            [JsonProperty("sku_type")]
            public int? SkuType { get; set; }
            /// <summary>
            /// 送货入户并安装模版id
            /// </summary>
            [JsonProperty("song_huo_an_zhuang")]
            public string SongHuoAnZhuang { get; set; }
            /// <summary>
            /// 送货入户模版id
            /// </summary>
            [JsonProperty("song_huo_ru_hu")]
            public string SongHuoRuHu { get; set; }
            /// <summary>
            /// 新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
            /// </summary>
            [JsonProperty("tiny_name")]
            public string TinyName { get; set; }
            /// <summary>
            /// 保税仓
            /// </summary>
            [JsonProperty("warehouse")]
            public string Warehouse { get; set; }
            /// <summary>
            /// 水果类目温馨提示
            /// </summary>
            [JsonProperty("warm_tips")]
            public string WarmTips { get; set; }
            /// <summary>
            /// 只换不修的天数，目前只支持0和365
            /// </summary>
            [JsonProperty("zhi_huan_bu_xiu")]
            public int? ZhiHuanBuXiu { get; set; }
            /// <summary>
            /// 发货方式。0：无物流发货；1：有物流发货。
            /// </summary>
            [JsonProperty("delivery_type")]
            public int? DeliveryType { get; set; }
            /// <summary>
            /// 是否成团预售。0：不是；1:是。
            /// </summary>
            [JsonProperty("is_group_pre_sale")]
            public int? IsGroupPreSale { get; set; }
            /// <summary>
            /// 是否sku预售，0：否，1：是
            /// </summary>
            [JsonProperty("is_sku_pre_sale")]
            public int? IsSkuPreSale { get; set; }
            public partial class CarouselVideoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商品视频id
                /// </summary>
                [JsonProperty("file_id")]
                public long? FileId { get; set; }
                /// <summary>
                /// 商品视频url
                /// </summary>
                [JsonProperty("video_url")]
                public string VideoUrl { get; set; }

            }
            public partial class ElecGoodsAttributesResponseModel : PddResponseModel
            {
                /// <summary>
                /// 开始时间（timeType=1时必填表示核销的开始时间）（精确到毫秒）
                /// </summary>
                [JsonProperty("begin_time")]
                public long? BeginTime { get; set; }
                /// <summary>
                /// 天数内有效（timeType=3必填，表示发货后几天内核销）
                /// </summary>
                [JsonProperty("days_time")]
                public int? DaysTime { get; set; }
                /// <summary>
                /// 截止时间（timeType=1,2时必填，表示发货后核销的截止时间）（精确到毫秒）
                /// </summary>
                [JsonProperty("end_time")]
                public long? EndTime { get; set; }
                /// <summary>
                /// 卡券核销类型（1：起始时间内有效，2：发货后后至截止时间内有效，3：发货后多少天内有效）
                /// </summary>
                [JsonProperty("time_type")]
                public int? TimeType { get; set; }

            }
            public partial class GoodsPropertyListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 属性单位
                /// </summary>
                [JsonProperty("punit")]
                public string Punit { get; set; }
                /// <summary>
                /// 引用属性id
                /// </summary>
                [JsonProperty("ref_pid")]
                public long? RefPid { get; set; }
                /// <summary>
                /// 模板属性Id
                /// </summary>
                [JsonProperty("template_pid")]
                public long? TemplatePid { get; set; }
                /// <summary>
                /// 基础属性值Id
                /// </summary>
                [JsonProperty("vid")]
                public long? Vid { get; set; }
                /// <summary>
                /// 基础属性值
                /// </summary>
                [JsonProperty("vvalue")]
                public string Vvalue { get; set; }

            }
            public partial class GoodsTradeAttrResponseModel : PddResponseModel
            {
                /// <summary>
                /// 提前预定天数
                /// </summary>
                [JsonProperty("advances_days")]
                public int? AdvancesDays { get; set; }
                /// <summary>
                /// 卡券有效期，日历日期后多少天可用。默认值为0表示仅限日历日当天使用.
                /// </summary>
                [JsonProperty("life_span")]
                public int? LifeSpan { get; set; }

            }
            public partial class GoodsTravelAttrResponseModel : PddResponseModel
            {
                /// <summary>
                /// 是否需要出行人信息
                /// </summary>
                [JsonProperty("need_tourist")]
                public bool? NeedTourist { get; set; }
                /// <summary>
                /// 1:旅行类,2:住宿类,3:票务类
                /// </summary>
                [JsonProperty("type")]
                public int? Type { get; set; }

            }
            public partial class OverseaGoodsResponseModel : PddResponseModel
            {
                /// <summary>
                /// 保税仓唯一标识
                /// </summary>
                [JsonProperty("bonded_warehouse_key")]
                public string BondedWarehouseKey { get; set; }
                /// <summary>
                /// 消费税率
                /// </summary>
                [JsonProperty("consumption_tax_rate")]
                public int? ConsumptionTaxRate { get; set; }
                /// <summary>
                /// 清关服务商
                /// </summary>
                [JsonProperty("customs_broker")]
                public string CustomsBroker { get; set; }
                /// <summary>
                /// 海关编号
                /// </summary>
                [JsonProperty("hs_code")]
                public string HsCode { get; set; }
                /// <summary>
                /// 增值税率
                /// </summary>
                [JsonProperty("value_added_tax_rate")]
                public int? ValueAddedTaxRate { get; set; }

            }
            public partial class SkuListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 上下架状态 1：上架 0 ：下架
                /// </summary>
                [JsonProperty("is_onsale")]
                public int? IsOnsale { get; set; }
                /// <summary>
                /// sku送装参数：长度
                /// </summary>
                [JsonProperty("lengtj")]
                public long? Lengtj { get; set; }
                /// <summary>
                /// sku购买限制
                /// </summary>
                [JsonProperty("limit_quantity")]
                public long? LimitQuantity { get; set; }
                /// <summary>
                /// 商品团购价格 单位分
                /// </summary>
                [JsonProperty("multi_price")]
                public long? MultiPrice { get; set; }
                /// <summary>
                /// 商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）
                /// </summary>
                [JsonProperty("out_sku_sn")]
                public string OutSkuSn { get; set; }
                /// <summary>
                /// 第三方sku Id
                /// </summary>
                [JsonProperty("out_source_sku_id")]
                public string OutSourceSkuId { get; set; }
                /// <summary>
                /// oversea_sku
                /// </summary>
                [JsonProperty("oversea_sku")]
                public OverseaSkuResponseModel OverseaSku { get; set; }
                /// <summary>
                /// 商品单买价格 单位分
                /// </summary>
                [JsonProperty("price")]
                public long? Price { get; set; }
                /// <summary>
                /// 库存
                /// </summary>
                [JsonProperty("quantity")]
                public long? Quantity { get; set; }
                /// <summary>
                /// sku编码
                /// </summary>
                [JsonProperty("sku_id")]
                public long? SkuId { get; set; }
                /// <summary>
                /// 商品规格列表
                /// </summary>
                [JsonProperty("spec")]
                public List<SpecResponseModel> Spec { get; set; }
                /// <summary>
                /// sku预览图
                /// </summary>
                [JsonProperty("thumb_url")]
                public string ThumbUrl { get; set; }
                /// <summary>
                /// 重量，单位为g
                /// </summary>
                [JsonProperty("weight")]
                public long? Weight { get; set; }
                /// <summary>
                /// sku属性
                /// </summary>
                [JsonProperty("sku_property_list")]
                public List<SkuPropertyListResponseModel> SkuPropertyList { get; set; }
                /// <summary>
                /// sku预售时间，单位秒
                /// </summary>
                [JsonProperty("sku_pre_sale_time")]
                public int? SkuPreSaleTime { get; set; }
                public partial class OverseaSkuResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 计量单位编码，从接口pdd.gooods.sku.measurement.list获取desc
                    /// </summary>
                    [JsonProperty("measurement_code")]
                    public string MeasurementCode { get; set; }
                    /// <summary>
                    /// 规格
                    /// </summary>
                    [JsonProperty("specifications")]
                    public string Specifications { get; set; }
                    /// <summary>
                    /// 税费
                    /// </summary>
                    [JsonProperty("taxation")]
                    public int? Taxation { get; set; }

                }
                public partial class SpecResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 商品规格对应的ID
                    /// </summary>
                    [JsonProperty("parent_id")]
                    public long? ParentId { get; set; }
                    /// <summary>
                    /// 商品规格ID对应的规格名称
                    /// </summary>
                    [JsonProperty("parent_name")]
                    public string ParentName { get; set; }
                    /// <summary>
                    /// 生成的自定义规格ID
                    /// </summary>
                    [JsonProperty("spec_id")]
                    public long? SpecId { get; set; }
                    /// <summary>
                    /// 商家编辑的规格值，如颜色规格下设置白色属性
                    /// </summary>
                    [JsonProperty("spec_name")]
                    public string SpecName { get; set; }

                }
                public partial class SkuPropertyListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 属性单位
                    /// </summary>
                    [JsonProperty("punit")]
                    public string Punit { get; set; }
                    /// <summary>
                    /// 属性id
                    /// </summary>
                    [JsonProperty("ref_pid")]
                    public long? RefPid { get; set; }
                    /// <summary>
                    /// 属性值
                    /// </summary>
                    [JsonProperty("value")]
                    public string Value { get; set; }
                    /// <summary>
                    /// 属性值id
                    /// </summary>
                    [JsonProperty("vid")]
                    public long? Vid { get; set; }

                }

            }

        }

    }

}
