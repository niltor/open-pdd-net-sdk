using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsSkusResponseModel : PddResponseModel
    {
        /// <summary>
        /// sku信息
        /// </summary>
        [JsonProperty("goods_sku_get_response")]
        public GoodsSkuGetResponseResponseModel GoodsSkuGetResponse { get; set; }
        public partial class GoodsSkuGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 该sku所在的商品ID
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }
            /// <summary>
            /// 上下架状态，1=上架，0=下架
            /// </summary>
            [JsonProperty("is_onsale")]
            public int? IsOnsale { get; set; }
            /// <summary>
            /// 团购价，单位分
            /// </summary>
            [JsonProperty("multi_price")]
            public long? MultiPrice { get; set; }
            /// <summary>
            /// SKU维度商家外部编码
            /// </summary>
            [JsonProperty("out_sku_sn")]
            public string OutSkuSn { get; set; }
            /// <summary>
            /// 库存
            /// </summary>
            [JsonProperty("quantity")]
            public long? Quantity { get; set; }
            /// <summary>
            /// 预扣库存
            /// </summary>
            [JsonProperty("reserve_quantity")]
            public long? ReserveQuantity { get; set; }
            /// <summary>
            /// 单买价，单位分
            /// </summary>
            [JsonProperty("single_price")]
            public long? SinglePrice { get; set; }
            /// <summary>
            /// skuId
            /// </summary>
            [JsonProperty("sku_id")]
            public long? SkuId { get; set; }
            /// <summary>
            /// 规格列表
            /// </summary>
            [JsonProperty("spec")]
            public List<SpecResponseModel> Spec { get; set; }
            public partial class SpecResponseModel : PddResponseModel
            {
                /// <summary>
                /// 规格项ID
                /// </summary>
                [JsonProperty("parent_spec_id")]
                public long? ParentSpecId { get; set; }
                /// <summary>
                /// 规格项
                /// </summary>
                [JsonProperty("parent_spec_name")]
                public string ParentSpecName { get; set; }
                /// <summary>
                /// 规格ID
                /// </summary>
                [JsonProperty("spec_id")]
                public long? SpecId { get; set; }
                /// <summary>
                /// 规格值
                /// </summary>
                [JsonProperty("spec_name")]
                public string SpecName { get; set; }

            }

        }

    }

}
