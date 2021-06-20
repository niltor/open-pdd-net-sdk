using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ticket
{
    public partial class QueryTicketGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 草稿查询返回结果
        /// </summary>
        [JsonProperty("goods_detail_get_response")]
        public GoodsDetailGetResponseResponseModel GoodsDetailGetResponse { get; set; }
        public partial class GoodsDetailGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品轮播图
            /// </summary>
            [JsonProperty("carousel_gallery")]
            public List<string> CarouselGallery { get; set; }
            /// <summary>
            /// 轮播视频
            /// </summary>
            [JsonProperty("carousel_video")]
            public List<CarouselVideoResponseModel> CarouselVideo { get; set; }
            /// <summary>
            /// 类目id，国内门票（含港澳台）9088，国外门票20042。
            /// </summary>
            [JsonProperty("cat_id")]
            public int? CatId { get; set; }
            /// <summary>
            /// 电子票发码方式，0=手动电子票；1=实时电子票，自动发货。
            /// </summary>
            [JsonProperty("code_mode")]
            public int? CodeMode { get; set; }
            /// <summary>
            /// 商品草稿状态，查询草稿id时返回。0=编辑中，1=待审核，2=审核通过，3=审核驳回
            /// </summary>
            [JsonProperty("commit_status")]
            public int? CommitStatus { get; set; }
            /// <summary>
            /// 商品详情图
            /// </summary>
            [JsonProperty("detail_gallery")]
            public List<string> DetailGallery { get; set; }
            /// <summary>
            /// 商品描述
            /// </summary>
            [JsonProperty("goods_desc")]
            public string GoodsDesc { get; set; }
            /// <summary>
            /// 商品标题
            /// </summary>
            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }
            /// <summary>
            /// 商品属性
            /// </summary>
            [JsonProperty("goods_properties")]
            public List<GoodsPropertiesResponseModel> GoodsProperties { get; set; }
            /// <summary>
            /// 商品状态，查询商品id时返回。1=上架，2=下架，3=售罄，4=已删除
            /// </summary>
            [JsonProperty("goods_status")]
            public int? GoodsStatus { get; set; }
            /// <summary>
            /// 商品参考价，单位为分。
            /// </summary>
            [JsonProperty("market_price")]
            public long? MarketPrice { get; set; }
            /// <summary>
            /// 商品goods外部编码，同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商品维度的商家编码。
            /// </summary>
            [JsonProperty("out_goods_sn")]
            public string OutGoodsSn { get; set; }
            /// <summary>
            /// 预定时间限制，格式：1_20_00，含义：需要提前1天，且在20:00分之前才可预定那天的门票。若为空则表示不限制预定时间。0_24_00表示在当前的24点前预定都可以，等效于不限制预定时间。
            /// </summary>
            [JsonProperty("reserve_limit_rule")]
            public string ReserveLimitRule { get; set; }
            /// <summary>
            /// sku列表
            /// </summary>
            [JsonProperty("sku_list")]
            public List<SkuListResponseModel> SkuList { get; set; }
            /// <summary>
            /// 销售方式，0=普通库存，1=日历库存。
            /// </summary>
            [JsonProperty("sku_type")]
            public int? SkuType { get; set; }
            public partial class CarouselVideoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 轮播视频id
                /// </summary>
                [JsonProperty("file_id")]
                public long? FileId { get; set; }
                /// <summary>
                /// 轮播视频url
                /// </summary>
                [JsonProperty("video_url")]
                public string VideoUrl { get; set; }

            }
            public partial class GoodsPropertiesResponseModel : PddResponseModel
            {
                /// <summary>
                /// 父规格id，仅销售属性有
                /// </summary>
                [JsonProperty("parent_spec_id")]
                public long? ParentSpecId { get; set; }
                /// <summary>
                /// 引用属性id
                /// </summary>
                [JsonProperty("ref_pid")]
                public long? RefPid { get; set; }
                /// <summary>
                /// 规格id，仅销售属性有和sku中的spec对应
                /// </summary>
                [JsonProperty("spec_id")]
                public long? SpecId { get; set; }
                /// <summary>
                /// 属性值
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; }
                /// <summary>
                /// 属性值单位
                /// </summary>
                [JsonProperty("value_unit")]
                public string ValueUnit { get; set; }
                /// <summary>
                /// 属性值id
                /// </summary>
                [JsonProperty("vid")]
                public long? Vid { get; set; }

            }
            public partial class SkuListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 子sku列表，仅当sku_type为日历库存且父sku数小于等于10个时返回。若父sku多于10个，需要在pdd.goods.child.sku.detail.get接口中查询子sku信息。
                /// </summary>
                [JsonProperty("child_skus")]
                public List<ChildSkusResponseModel> ChildSkus { get; set; }
                /// <summary>
                /// 拼团价，单位为分。当sku_type为日历库存时是可预定日期的拼团价最低价。
                /// </summary>
                [JsonProperty("group_price")]
                public long? GroupPrice { get; set; }
                /// <summary>
                /// 上架状态。0=已下架，1=已上架。
                /// </summary>
                [JsonProperty("is_onsale")]
                public int? IsOnsale { get; set; }
                /// <summary>
                /// 商品sku外部编码，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
                /// </summary>
                [JsonProperty("out_sku_sn")]
                public string OutSkuSn { get; set; }
                /// <summary>
                /// 线上库存量
                /// </summary>
                [JsonProperty("quantity")]
                public long? Quantity { get; set; }
                /// <summary>
                /// 库存增减，当查草稿时返回。
                /// </summary>
                [JsonProperty("quantity_delta")]
                public long? QuantityDelta { get; set; }
                /// <summary>
                /// 线上预扣库存量
                /// </summary>
                [JsonProperty("reserve_quantity")]
                public long? ReserveQuantity { get; set; }
                /// <summary>
                /// 调pdd.scenic.sku.rule.get得到的规则id
                /// </summary>
                [JsonProperty("rule_id")]
                public string RuleId { get; set; }
                /// <summary>
                /// 单买价，单位为分。当sku_type为日历库存时是可预定日期的单买价最低价。
                /// </summary>
                [JsonProperty("single_price")]
                public long? SinglePrice { get; set; }
                /// <summary>
                /// skuId
                /// </summary>
                [JsonProperty("sku_id")]
                public string SkuId { get; set; }
                /// <summary>
                /// sku规格列表
                /// </summary>
                [JsonProperty("spec")]
                public List<SpecResponseModel> Spec { get; set; }
                /// <summary>
                /// SKU预览图
                /// </summary>
                [JsonProperty("thumb_url")]
                public string ThumbUrl { get; set; }
                public partial class ChildSkusResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 日期。格式：2020-06-01
                    /// </summary>
                    [JsonProperty("date")]
                    public string Date { get; set; }
                    /// <summary>
                    /// 拼团价，单位为分。
                    /// </summary>
                    [JsonProperty("group_price")]
                    public long? GroupPrice { get; set; }
                    /// <summary>
                    /// 线上库存
                    /// </summary>
                    [JsonProperty("quantity")]
                    public long? Quantity { get; set; }
                    /// <summary>
                    /// 库存增减，当查草稿时返回。
                    /// </summary>
                    [JsonProperty("quantity_delta")]
                    public long? QuantityDelta { get; set; }
                    /// <summary>
                    /// 线上预扣库存
                    /// </summary>
                    [JsonProperty("reserve_quantity")]
                    public long? ReserveQuantity { get; set; }
                    /// <summary>
                    /// 单买价，单位为分
                    /// </summary>
                    [JsonProperty("single_price")]
                    public long? SinglePrice { get; set; }
                    /// <summary>
                    /// skuId
                    /// </summary>
                    [JsonProperty("sku_id")]
                    public long? SkuId { get; set; }

                }
                public partial class SpecResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 父规格id
                    /// </summary>
                    [JsonProperty("parent_id")]
                    public long? ParentId { get; set; }
                    /// <summary>
                    /// 父规格名称
                    /// </summary>
                    [JsonProperty("parent_name")]
                    public string ParentName { get; set; }
                    /// <summary>
                    /// 规格id
                    /// </summary>
                    [JsonProperty("spec_id")]
                    public long? SpecId { get; set; }
                    /// <summary>
                    /// 规格名称
                    /// </summary>
                    [JsonProperty("spec_name")]
                    public string SpecName { get; set; }

                }

            }

        }

    }

}
