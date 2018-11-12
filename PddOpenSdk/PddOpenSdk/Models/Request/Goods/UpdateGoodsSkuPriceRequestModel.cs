using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class UpdateGoodsSkuPriceRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 待修改的sku价格
        /// </summary>
        [JsonProperty("sku_price_list")]
        public List<SkuPriceListRequestModel> SkuPriceList { get; set; }
        public partial class SkuPriceListRequestModel : PddRequestModel
        {
            /// <summary>
            /// sku上架状态，0-已下架，1-上架中
            /// </summary>
            [JsonProperty("is_onsale")]
            public int? IsOnsale { get; set; }
            /// <summary>
            /// 单独购买价格（单位分）
            /// </summary>
            [JsonProperty("single_price")]
            public long SinglePrice { get; set; }
            /// <summary>
            /// 拼团购买价格（单位分）
            /// </summary>
            [JsonProperty("group_price")]
            public long GroupPrice { get; set; }
            /// <summary>
            /// sku标识
            /// </summary>
            [JsonProperty("sku_id")]
            public long SkuId { get; set; }

        }

    }

}
