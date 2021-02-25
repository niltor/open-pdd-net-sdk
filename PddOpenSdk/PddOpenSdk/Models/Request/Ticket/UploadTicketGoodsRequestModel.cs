using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ticket
{
    public partial class UploadTicketGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB。先通过pdd.goods.image.upload上传图片
        /// </summary>
        [JsonProperty("carousel_gallery")]
        public List<string> CarouselGallery { get; set; }
        /// <summary>
        /// 轮播视频。需要先上传到pdd.goods.filespace.image.upload
        /// </summary>
        [JsonProperty("carousel_video")]
        public List<CarouselVideoRequestModel> CarouselVideo { get; set; }
        /// <summary>
        /// 类目id，国内门票（含港澳台）传9088，国外门票传20042。发布成功后不能修改。新增商品时必填。
        /// </summary>
        [JsonProperty("cat_id")]
        public long? CatId { get; set; }
        /// <summary>
        /// 电子票发码方式，0=手动电子票；1=实时电子票，自动发货。新增商品时必填。
        /// </summary>
        [JsonProperty("code_mode")]
        public int? CodeMode { get; set; }
        /// <summary>
        /// 商品详情图： a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间 b. 大小1M以内 c. 数量限制在20张之间 d. 图片格式仅支持JPG,PNG格式 。先通过pdd.goods.image.upload上传图片，新增商品时必填。
        /// </summary>
        [JsonProperty("detail_gallery")]
        public List<string> DetailGallery { get; set; }
        /// <summary>
        /// 草稿id，编辑草稿时必传。
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public long? GoodsCommitId { get; set; }
        /// <summary>
        /// 商品描述，字数限制：20~500。新增商品时必填。
        /// </summary>
        [JsonProperty("goods_desc")]
        public string GoodsDesc { get; set; }
        /// <summary>
        /// 商品id，编辑商品时必传。
        /// </summary>
        [JsonProperty("goods_id")]
        public long? GoodsId { get; set; }
        /// <summary>
        /// 商品标题，新增商品时必填。
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品属性，先调pdd.goods.cat.template.get，根据cat_id获取，新增商品时必填。
        /// </summary>
        [JsonProperty("goods_properties")]
        public List<GoodsPropertiesRequestModel> GoodsProperties { get; set; }
        /// <summary>
        /// 是否提交本次编辑，0=不提交，表示仅保存草稿，不进行提交，不会进行校验；1=提交，表示提交本次编辑内容，会进行校验；不传时默认为提交
        /// </summary>
        [JsonProperty("is_submit")]
        public int? IsSubmit { get; set; }
        /// <summary>
        /// 商品市场价，单位为分，必须高于最高的sku单买价。新增商品时必填。
        /// </summary>
        [JsonProperty("market_price")]
        public long? MarketPrice { get; set; }
        /// <summary>
        /// 商品goods外部编码，同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商品维度的商家编码。
        /// </summary>
        [JsonProperty("out_goods_sn")]
        public string OutGoodsSn { get; set; }
        /// <summary>
        /// 预定时间限制，格式：1_20_00，含义：需要提前1天，且在20:00分之前才可预定那天的门票。若不传则表示不限制预定时间。0_24_00表示在当前的24点前预定都可以，等效于不限制预定时间。
        /// </summary>
        [JsonProperty("reserve_limit_rule")]
        public string ReserveLimitRule { get; set; }
        /// <summary>
        /// sku列表。新增商品时必填。整个sku_list会作为整体更新。
        /// </summary>
        [JsonProperty("sku_list")]
        public List<SkuListRequestModel> SkuList { get; set; }
        /// <summary>
        /// 销售方式，0=普通库存，1=日历库存。对于普通库存入参sku维度的价格库存，对于日历库存需要在pdd.goods.child.sku.edit入参child_sku维度的价格库存后再提交。编辑商品时不允许修改。
        /// </summary>
        [JsonProperty("sku_type")]
        public int? SkuType { get; set; }
        /// <summary>
        /// 提交后上下架状态，0=上架；1=保持原样。表示编辑商品并提交后商品的上下架状态，不传时默认为0，上架。
        /// </summary>
        [JsonProperty("sync_goods_operate")]
        public int? SyncGoodsOperate { get; set; }
        public partial class CarouselVideoRequestModel : PddRequestModel
        {
            /// <summary>
            /// 轮播视频id
            /// </summary>
            [JsonProperty("file_id")]
            public long FileId { get; set; }
            /// <summary>
            /// 轮播视频url
            /// </summary>
            [JsonProperty("video_url")]
            public string VideoUrl { get; set; }

        }
        public partial class GoodsPropertiesRequestModel : PddRequestModel
        {
            /// <summary>
            /// 父规格id，仅对于销售属性入参
            /// </summary>
            [JsonProperty("parent_spec_id")]
            public long? ParentSpecId { get; set; }
            /// <summary>
            /// 引用属性id
            /// </summary>
            [JsonProperty("ref_pid")]
            public long RefPid { get; set; }
            /// <summary>
            /// 规格id，仅对于销售属性入参，和sku中的spec对应
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
        public partial class SkuListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 仅当sku_type为日历库存时入参。若父sku多于10个，需要通过pdd.goods.child.sku.edit接口分批维护。
            /// </summary>
            [JsonProperty("child_skus")]
            public List<ChildSkusRequestModel> ChildSkus { get; set; }
            /// <summary>
            /// 拼团价，单位为分。仅当sku_type为普通库存时入参
            /// </summary>
            [JsonProperty("group_price")]
            public long? GroupPrice { get; set; }
            /// <summary>
            /// 上架状态。0=已下架，1=已上架。新建sku时不传时表示上架。
            /// </summary>
            [JsonProperty("is_onsale")]
            public int IsOnsale { get; set; }
            /// <summary>
            /// sku外部编码，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
            /// </summary>
            [JsonProperty("out_sku_sn")]
            public string OutSkuSn { get; set; }
            /// <summary>
            /// 库存增减。仅当sku_type为普通库存时入参。比如传-10表示将对应的sku库存减10。
            /// </summary>
            [JsonProperty("quantity_delta")]
            public long? QuantityDelta { get; set; }
            /// <summary>
            /// 调pdd.scenic.sku.rule.get得到的规则id。在发布成功后不可修改。
            /// </summary>
            [JsonProperty("rule_id")]
            public string RuleId { get; set; }
            /// <summary>
            /// 单买价，单位为分。仅当sku_type为普通库存时入参。
            /// </summary>
            [JsonProperty("single_price")]
            public long? SinglePrice { get; set; }
            /// <summary>
            /// 如果传值，则在原sku基础上进行编辑，如果传空，则新增sku
            /// </summary>
            [JsonProperty("sku_id")]
            public long? SkuId { get; set; }
            /// <summary>
            /// 商品规格列表，从pdd.goods.cat.template.get中获取销售属性规格id后，再在pdd.goods.spec.id.get获取spec_id。spec_id需要和goods_properties中的对应。对于多种规格，需要传每个规格的spec_id的值，如[20,5]。在发布后不可修改。
            /// </summary>
            [JsonProperty("spec_id_list")]
            public List<long> SpecIdList { get; set; }
            /// <summary>
            /// SKU预览图。图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB。先通过pdd.goods.image.upload上传图片
            /// </summary>
            [JsonProperty("thumb_url")]
            public string ThumbUrl { get; set; }
            public partial class ChildSkusRequestModel : PddRequestModel
            {
                /// <summary>
                /// 日期。格式：2020-06-01。每个sku最多支持180天。
                /// </summary>
                [JsonProperty("date")]
                public string Date { get; set; }
                /// <summary>
                /// 拼团价，单位为分。
                /// </summary>
                [JsonProperty("group_price")]
                public long GroupPrice { get; set; }
                /// <summary>
                /// 库存增减。比如传-10表示将对应的sku库存减10。
                /// </summary>
                [JsonProperty("quantity_delta")]
                public long QuantityDelta { get; set; }
                /// <summary>
                /// 单买价，单位为分。
                /// </summary>
                [JsonProperty("single_price")]
                public long SinglePrice { get; set; }

            }

        }

    }

}
