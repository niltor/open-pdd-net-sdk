using System.Collections.Generic;
using Newtonsoft.Json;
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
            /// 是否支持正品发票；0-不支持、1-支持
            /// </summary>
            [JsonProperty("invoice_status")]
            public int InvoiceStatus { get; set; }
            /// <summary>
            /// 商品属性列表
            /// </summary>
            [JsonProperty("goods_property_list")]
            public List<GoodsPropertyListResponseModel> GoodsPropertyList { get; set; }
            /// <summary>
            /// 只换不修的天数，目前只支持0和365
            /// </summary>
            [JsonProperty("zhi_huan_bu_xiu")]
            public int ZhiHuanBuXiu { get; set; }
            /// <summary>
            /// 0：不支持全国联保；1：支持全国联保
            /// </summary>
            [JsonProperty("quan_guo_lian_bao")]
            public int QuanGuoLianBao { get; set; }
            /// <summary>
            /// 提交申请的序列ID
            /// </summary>
            [JsonProperty("goods_commit_id")]
            public long GoodsCommitId { get; set; }
            /// <summary>
            /// 商品状态，枚举：0-编辑中，1-待审核，2-审核通过，3-审核驳回
            /// </summary>
            [JsonProperty("goods_status")]
            public int GoodsStatus { get; set; }
            /// <summary>
            /// 驳回原因，仅在status=2时返回，其余状态返回空值
            /// </summary>
            [JsonProperty("commit_message")]
            public string CommitMessage { get; set; }
            /// <summary>
            /// 是否删除
            /// </summary>
            [JsonProperty("deleted")]
            public int Deleted { get; set; }
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long GoodsId { get; set; }
            /// <summary>
            /// 购买数量限制
            /// </summary>
            [JsonProperty("buy_limit")]
            public long BuyLimit { get; set; }
            /// <summary>
            /// 商品轮播图列表
            /// </summary>
            [JsonProperty("carousel_gallery_list")]
            public List<string> CarouselGalleryList { get; set; }
            /// <summary>
            /// 类目id
            /// </summary>
            [JsonProperty("cat_id")]
            public long CatId { get; set; }
            /// <summary>
            /// 运费模版id
            /// </summary>
            [JsonProperty("cost_template_id")]
            public long CostTemplateId { get; set; }
            /// <summary>
            /// 国家id
            /// </summary>
            [JsonProperty("country_id")]
            public long CountryId { get; set; }
            /// <summary>
            /// 团购人数
            /// </summary>
            [JsonProperty("customer_num")]
            public long CustomerNum { get; set; }
            /// <summary>
            /// 商品类型：1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架
            /// </summary>
            [JsonProperty("goods_type")]
            public int GoodsType { get; set; }
            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }
            /// <summary>
            /// 商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
            /// </summary>
            [JsonProperty("goods_desc")]
            public string GoodsDesc { get; set; }
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
            /// 是否需要上报海关 0:否 1:是
            /// </summary>
            [JsonProperty("is_customs")]
            public int IsCustoms { get; set; }
            /// <summary>
            /// 海关名称
            /// </summary>
            [JsonProperty("customs")]
            public string Customs { get; set; }
            /// <summary>
            /// 市场价格，单位为分
            /// </summary>
            [JsonProperty("market_price")]
            public long MarketPrice { get; set; }
            /// <summary>
            /// 是否预售,true-预售商品，false-非预售商品
            /// </summary>
            [JsonProperty("is_pre_sale")]
            public int IsPreSale { get; set; }
            /// <summary>
            /// 预售时间
            /// </summary>
            [JsonProperty("pre_sale_time")]
            public long PreSaleTime { get; set; }
            /// <summary>
            /// 承诺发货时间（ 秒）
            /// </summary>
            [JsonProperty("shipment_limit_second")]
            public long ShipmentLimitSecond { get; set; }
            /// <summary>
            /// 限购次数
            /// </summary>
            [JsonProperty("order_limit")]
            public long OrderLimit { get; set; }
            /// <summary>
            /// 是否7天无理由退换货，1-支持，0-不支持
            /// </summary>
            [JsonProperty("is_refundable")]
            public int IsRefundable { get; set; }
            /// <summary>
            /// 是否支持假一赔十，0-不支持，1-支持
            /// </summary>
            [JsonProperty("is_folt")]
            public int IsFolt { get; set; }
            /// <summary>
            /// 面料id
            /// </summary>
            [JsonProperty("fabric_id")]
            public int FabricId { get; set; }
            /// <summary>
            /// 服饰成分id
            /// </summary>
            [JsonProperty("fabric_content_id")]
            public int FabricContentId { get; set; }
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
            /// 普通缩略图，上传轮播图首图，尺寸200*200，图片格式仅支持JPG,PNG格式
            /// </summary>
            [JsonProperty("thumb_url")]
            public string ThumbUrl { get; set; }
            /// <summary>
            /// 普通缩略图
            /// </summary>
            [JsonProperty("hd_thumb_url")]
            public string HdThumbUrl { get; set; }
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
            /// 商家编码（商品维度），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）
            /// </summary>
            [JsonProperty("outer_goods_id")]
            public string OuterGoodsId { get; set; }
            /// <summary>
            /// 保质期
            /// </summary>
            [JsonProperty("shelf_life")]
            public long ShelfLife { get; set; }
            /// <summary>
            /// 生产日期起始时间
            /// </summary>
            [JsonProperty("start_production_date")]
            public string StartProductionDate { get; set; }
            /// <summary>
            /// 生产日期结束时间
            /// </summary>
            [JsonProperty("end_production_date")]
            public string EndProductionDate { get; set; }
            /// <summary>
            /// 产品标准号 ，例如23453
            /// </summary>
            [JsonProperty("production_license")]
            public string ProductionLicense { get; set; }
            /// <summary>
            /// 产品标准号
            /// </summary>
            [JsonProperty("production_standard_number")]
            public string ProductionStandardNumber { get; set; }
            /// <summary>
            /// 是否二手
            /// </summary>
            [JsonProperty("second_hand")]
            public int SecondHand { get; set; }
            /// <summary>
            /// 仅在cat_id=983（卷筒纸）类目下入参，每包或者卷的净含量，计量单位是g，范围是1~999的整数
            /// </summary>
            [JsonProperty("paper_net_weight")]
            public long PaperNetWeight { get; set; }
            /// <summary>
            /// 仅在cat_id=983（卷筒纸）类目下入参，每段/节纸品的长度，单位是mm，范围是1~999的整数
            /// </summary>
            [JsonProperty("paper_length")]
            public long PaperLength { get; set; }
            /// <summary>
            /// 仅在cat_id=983（卷筒纸）类目下入参，每段/节的宽度，单位是mm，范围是1~999的整数
            /// </summary>
            [JsonProperty("paper_width")]
            public long PaperWidth { get; set; }
            /// <summary>
            /// 仅在cat_id=983（卷筒纸）类目下入参，纸张的层数，单位是层，范围是1~9的整数
            /// </summary>
            [JsonProperty("paper_plies_num")]
            public long PaperPliesNum { get; set; }
            public partial class GoodsPropertyListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 属性单位
                /// </summary>
                [JsonProperty("punit")]
                public string Punit { get; set; }
                /// <summary>
                /// 基础属性值Id
                /// </summary>
                [JsonProperty("vid")]
                public long Vid { get; set; }
                /// <summary>
                /// 基础属性值
                /// </summary>
                [JsonProperty("vvalue")]
                public string Vvalue { get; set; }
                /// <summary>
                /// 模板属性Id
                /// </summary>
                [JsonProperty("template_pid")]
                public long TemplatePid { get; set; }
                /// <summary>
                /// 引用属性id
                /// </summary>
                [JsonProperty("ref_pid")]
                public long RefPid { get; set; }

            }
            public partial class SkuListResponseModel : PddResponseModel
            {
                /// <summary>
                /// sku编码
                /// </summary>
                [JsonProperty("sku_id")]
                public long SkuId { get; set; }
                /// <summary>
                /// 上下架状态 1：上架 0 ：下架
                /// </summary>
                [JsonProperty("is_onsale")]
                public int IsOnsale { get; set; }
                /// <summary>
                /// sku购买限制
                /// </summary>
                [JsonProperty("limit_quantity")]
                public long LimitQuantity { get; set; }
                /// <summary>
                /// 商品团购价格 单位分
                /// </summary>
                [JsonProperty("multi_price")]
                public long MultiPrice { get; set; }
                /// <summary>
                /// 商品单买价格 单位分
                /// </summary>
                [JsonProperty("price")]
                public long Price { get; set; }
                /// <summary>
                /// 库存
                /// </summary>
                [JsonProperty("quantity")]
                public long Quantity { get; set; }
                /// <summary>
                /// 重量，单位为g
                /// </summary>
                [JsonProperty("weight")]
                public long Weight { get; set; }
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
                /// 商家编码（sku维度），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）
                /// </summary>
                [JsonProperty("out_sku_sn")]
                public string OutSkuSn { get; set; }
                public partial class SpecResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 商品规格对应的ID
                    /// </summary>
                    [JsonProperty("parent_id")]
                    public long ParentId { get; set; }
                    /// <summary>
                    /// 商品规格ID对应的规格名称
                    /// </summary>
                    [JsonProperty("parent_name")]
                    public string ParentName { get; set; }
                    /// <summary>
                    /// 生成的自定义规格ID
                    /// </summary>
                    [JsonProperty("spec_id")]
                    public long SpecId { get; set; }
                    /// <summary>
                    /// 商家编辑的规格值，如颜色规格下设置白色属性
                    /// </summary>
                    [JsonProperty("spec_name")]
                    public string SpecName { get; set; }

                }

            }

        }

    }

}
