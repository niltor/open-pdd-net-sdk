using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class EditGoodsChildSkuRequestModel : PddRequestModel
    {
        /// <summary>
        /// 草稿id（未填写则新建一条商品草稿）
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public long? GoodsCommitId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 日历库存型商品sku信息列表
        /// </summary>
        [JsonProperty("skus")]
        public List<SkusRequestModel> Skus { get; set; }
        /// <summary>
        /// 提交后上下架状态，0=上架；1=保持原样。表示编辑商品并提交后商品的上下架状态，不传时默认为0，上架。
        /// </summary>
        [JsonProperty("sync_goods_operate")]
        public int? SyncGoodsOperate { get; set; }
        public partial class SkusRequestModel : PddRequestModel
        {
            /// <summary>
            /// 日历库存商品子sku信息列表
            /// </summary>
            [JsonProperty("child_skus")]
            public List<ChildSkusRequestModel> ChildSkus { get; set; }
            /// <summary>
            /// 上架状态。0=已下架，1=已上架。不传表示不做修改
            /// </summary>
            [JsonProperty("is_onsale")]
            public int? IsOnsale { get; set; }
            /// <summary>
            /// 与sku_id必填其一，用于确定编辑的sku，当有多个sku的out_sku_sn一样时会编辑失败。
            /// </summary>
            [JsonProperty("out_sku_sn")]
            public string OutSkuSn { get; set; }
            /// <summary>
            /// 日历库存商品父skuId
            /// </summary>
            [JsonProperty("sku_id")]
            public long? SkuId { get; set; }
            public partial class ChildSkusRequestModel : PddRequestModel
            {
                /// <summary>
                /// 售卖日期（“yyyy-MM-dd”）
                /// </summary>
                [JsonProperty("date")]
                public string Date { get; set; }
                /// <summary>
                /// 团购价
                /// </summary>
                [JsonProperty("group_price")]
                public long GroupPrice { get; set; }
                /// <summary>
                /// 库存增减
                /// </summary>
                [JsonProperty("quantity_delta")]
                public long QuantityDelta { get; set; }
                /// <summary>
                /// 单买价
                /// </summary>
                [JsonProperty("single_price")]
                public long SinglePrice { get; set; }

            }

        }

    }

}
