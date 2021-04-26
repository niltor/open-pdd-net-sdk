using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsAdvicePriceResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_advice_price_get_response")]
        public GoodsAdvicePriceGetResponseResponseModel GoodsAdvicePriceGetResponse { get; set; }
        public partial class GoodsAdvicePriceGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品建议价列表
            /// </summary>
            [JsonProperty("advice_price_list")]
            public List<AdvicePriceListResponseModel> AdvicePriceList { get; set; }
            /// <summary>
            /// 商品建议价数据总数
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            public partial class AdvicePriceListResponseModel : PddResponseModel
            {
                /// <summary>
                /// sku建议价，单位为分
                /// </summary>
                [JsonProperty("advice_price")]
                public long? AdvicePrice { get; set; }
                /// <summary>
                /// 商品ID
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 商品标题
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// sku拼单价，单位为分
                /// </summary>
                [JsonProperty("group_price")]
                public long? GroupPrice { get; set; }
                /// <summary>
                /// skuID
                /// </summary>
                [JsonProperty("sku_id")]
                public long? SkuId { get; set; }
                /// <summary>
                /// sku名
                /// </summary>
                [JsonProperty("sku_name")]
                public string SkuName { get; set; }

            }

        }

    }

}
