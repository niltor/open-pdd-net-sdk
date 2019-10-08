using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商品详情response
        /// </summary>
        [JsonProperty("goods_detail_get_response")]
        public GoodsDetailGetResponseResponseModel GoodsDetailGetResponse { get; set; }
        public partial class GoodsDetailGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 送货入户模版id
            /// </summary>
            [JsonProperty("song_huo_ru_hu")]
            public string SongHuoRuHu { get; set; }
            /// <summary>
            /// 上门安装模版id
            /// </summary>
            [JsonProperty("shang_men_an_zhuang")]
            public string ShangMenAnZhuang { get; set; }
            /// <summary>
            /// 送货入户并安装模版id
            /// </summary>
            [JsonProperty("song_huo_an_zhuang")]
            public string SongHuoAnZhuang { get; set; }
            /// <summary>
            /// 买家自提模版id
            /// </summary>
            [JsonProperty("mai_jia_zi_ti")]
            public string MaiJiaZiTi { get; set; }
            /// <summary>
            /// 短标题，示例：新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
            /// </summary>
            [JsonProperty("tiny_name")]
            public string TinyName { get; set; }
            /// <summary>
            /// 是否支持正品发票；0-不支持、1-支持
            /// </summary>
            [JsonProperty("invoice_status")]
            public int? InvoiceStatus { get; set; }
            /// <summary>
            /// 商品属性列表
            /// </summary>
            [JsonProperty("goods_property_list")]
            public List<GoodsPropertyListResponseModel> GoodsPropertyList { get; set; }
            /// <summary>
            /// 只换不修的天数，目前只支持0和365
            /// </summary>
            [JsonProperty("zhi_huan_bu_xiu")]
            public int? ZhiHuanBuXiu { get; set; }
            /// <summary>
            /// 0：不支持全国联保；1：支持全国联保
            /// </summary>
            [JsonProperty("quan_guo_lian_bao")]
            public int? QuanGuoLianBao { get; set; }
            /// <summary>
            /// 商品状态 1:上架，2：下架，3：售罄 4：已删除
            /// </summary>
            [JsonProperty("status")]
            public int? Status { get; set; }
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }
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
            /// 叶子类目ID
            /// </summary>
            [JsonProperty("cat_id")]
            public long? CatId { get; set; }
            /// <summary>
            /// 运费模版id
            /// </summary>
            [JsonProperty("cost_template_id")]
            public long? CostTemplateId { get; set; }
            /// <summary>
            /// 国家id
            /// </summary>
            [JsonProperty("country_id")]
            public int? CountryId { get; set; }
            /// <summary>
            /// 团购人数
            /// </summary>
            [JsonProperty("customer_num")]
            public long? CustomerNum { get; set; }
            /// <summary>
            /// 商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架
            /// </summary>
            [JsonProperty("goods_type")]
            public int? GoodsType { get; set; }
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
            /// 保税仓
            /// </summary>
            [JsonProperty("warehouse")]
            public string Warehouse { get; set; }
            /// <summary>
            /// 是否需要上报海关 0:否 1:是
            /// </summary>
            [JsonProperty("is_customs")]
            public int? IsCustoms { get; set; }
            /// <summary>
            /// 海关名称
            /// </summary>
            [JsonProperty("customs")]
            public string Customs { get; set; }
            /// <summary>
            /// 市场价格，单位为分
            /// </summary>
            [JsonProperty("market_price")]
            public long? MarketPrice { get; set; }
            /// <summary>
            /// 是否预售,1-预售商品，0-非预售商品
            /// </summary>
            [JsonProperty("is_pre_sale")]
            public int? IsPreSale { get; set; }
            /// <summary>
            /// 预售时间
            /// </summary>
            [JsonProperty("pre_sale_time")]
            public long? PreSaleTime { get; set; }
            /// <summary>
            /// 承诺发货时间（ 秒）
            /// </summary>
            [JsonProperty("shipment_limit_second")]
            public long? ShipmentLimitSecond { get; set; }
            /// <summary>
            /// 单次限量
            /// </summary>
            [JsonProperty("order_limit")]
            public long? OrderLimit { get; set; }
            /// <summary>
            /// 是否7天无理由退换货，1-支持，0-不支持
            /// </summary>
            [JsonProperty("is_refundable")]
            public int? IsRefundable { get; set; }
            /// <summary>
            /// 是否支持假一赔十，0-不支持，1-支持
            /// </summary>
            [JsonProperty("is_folt")]
            public int? IsFolt { get; set; }
            /// <summary>
            /// 水果类目温馨提示
            /// </summary>
            [JsonProperty("warm_tips")]
            public string WarmTips { get; set; }
            /// <summary>
            /// sku列表
            /// </summary>
            [JsonProperty("sku_list")]
            public List<SkuListResponseModel> SkuList { get; set; }
            /// <summary>
            /// 商品主图
            /// </summary>
            [JsonProperty("image_url")]
            public string ImageUrl { get; set; }
            /// <summary>
            /// 商品详情图
            /// </summary>
            [JsonProperty("detail_gallery_list")]
            public List<string> DetailGalleryList { get; set; }
            /// <summary>
            /// 商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
            /// </summary>
            [JsonProperty("outer_goods_id")]
            public string OuterGoodsId { get; set; }
            /// <summary>
            /// 是否二手 1:是 0:否
            /// </summary>
            [JsonProperty("second_hand")]
            public int? SecondHand { get; set; }
            /// <summary>
            /// oversea_type
            /// </summary>
            [JsonProperty("oversea_type")]
            public int? OverseaType { get; set; }
            /// <summary>
            /// oversea_goods
            /// </summary>
            [JsonProperty("oversea_goods")]
            public OverseaGoodsResponseModel OverseaGoods { get; set; }
            /// <summary>
            /// 缺重包退
            /// </summary>
            [JsonProperty("lack_of_weight_claim")]
            public int? LackOfWeightClaim { get; set; }
            /// <summary>
            /// 坏果包赔
            /// </summary>
            [JsonProperty("bad_fruit_claim")]
            public int? BadFruitClaim { get; set; }
            /// <summary>
            /// 商品视频
            /// </summary>
            [JsonProperty("video_gallery")]
            public List<VideoGalleryResponseModel> VideoGallery { get; set; }
            public partial class GoodsPropertyListResponseModel : PddResponseModel
            {
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
                /// 基础属性值
                /// </summary>
                [JsonProperty("vvalue")]
                public string Vvalue { get; set; }
                /// <summary>
                /// 基础属性值Id
                /// </summary>
                [JsonProperty("vid")]
                public long? Vid { get; set; }
                /// <summary>
                /// 属性单位
                /// </summary>
                [JsonProperty("punit")]
                public string Punit { get; set; }

            }
            public partial class SkuListResponseModel : PddResponseModel
            {
                /// <summary>
                /// sku送装参数：长度
                /// </summary>
                [JsonProperty("length")]
                public long? Length { get; set; }
                /// <summary>
                /// sku编码
                /// </summary>
                [JsonProperty("sku_id")]
                public long? SkuId { get; set; }
                /// <summary>
                /// 上下架状态 1：上架 0 ：下架
                /// </summary>
                [JsonProperty("is_onsale")]
                public int? IsOnsale { get; set; }
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
                /// 重量，单位为g
                /// </summary>
                [JsonProperty("weight")]
                public long? Weight { get; set; }
                /// <summary>
                /// sku预览图
                /// </summary>
                [JsonProperty("thumb_url")]
                public string ThumbUrl { get; set; }
                /// <summary>
                /// 商品规格列表
                /// </summary>
                [JsonProperty("spec")]
                public List<SpecResponseModel> Spec { get; set; }
                /// <summary>
                /// 商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
                /// </summary>
                [JsonProperty("out_sku_sn")]
                public string OutSkuSn { get; set; }
                /// <summary>
                /// oversea_sku
                /// </summary>
                [JsonProperty("oversea_sku")]
                public OverseaSkuResponseModel OverseaSku { get; set; }
                public partial class SpecResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 自定义规格所属的规格ID
                    /// </summary>
                    [JsonProperty("parent_id")]
                    public long? ParentId { get; set; }
                    /// <summary>
                    /// 商品规格ID对应的规格名称
                    /// </summary>
                    [JsonProperty("parent_name")]
                    public string ParentName { get; set; }
                    /// <summary>
                    /// 自定义规格ID
                    /// </summary>
                    [JsonProperty("spec_id")]
                    public long? SpecId { get; set; }
                    /// <summary>
                    /// 自定义规格名称
                    /// </summary>
                    [JsonProperty("spec_name")]
                    public string SpecName { get; set; }

                }
                public partial class OverseaSkuResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 计量单位编码，从接口pdd.gooods.sku.measurement.list获取desc
                    /// </summary>
                    [JsonProperty("measurement_code")]
                    public string MeasurementCode { get; set; }
                    /// <summary>
                    /// 税费
                    /// </summary>
                    [JsonProperty("taxation")]
                    public int? Taxation { get; set; }
                    /// <summary>
                    /// 规格
                    /// </summary>
                    [JsonProperty("specifications")]
                    public string Specifications { get; set; }

                }

            }
            public partial class OverseaGoodsResponseModel : PddResponseModel
            {
                /// <summary>
                /// 消费税率
                /// </summary>
                [JsonProperty("consumption_tax_rate")]
                public int? ConsumptionTaxRate { get; set; }
                /// <summary>
                /// 增值税率
                /// </summary>
                [JsonProperty("value_added_tax_rate")]
                public int? ValueAddedTaxRate { get; set; }
                /// <summary>
                /// 海关编号
                /// </summary>
                [JsonProperty("hs_code")]
                public string HsCode { get; set; }
                /// <summary>
                /// 清关服务商
                /// </summary>
                [JsonProperty("customs_broker")]
                public string CustomsBroker { get; set; }
                /// <summary>
                /// 保税仓唯一标识
                /// </summary>
                [JsonProperty("bonded_warehouse_key")]
                public string BondedWarehouseKey { get; set; }

            }
            public partial class VideoGalleryResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商品视频id
                /// </summary>
                [JsonProperty("file_id")]
                public int? FileId { get; set; }
                /// <summary>
                /// 商品视频url
                /// </summary>
                [JsonProperty("video_url")]
                public string VideoUrl { get; set; }

            }

        }

    }

}
