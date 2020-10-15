using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Promotion
{
    public partial class GetPromotionLimitedQualifiedGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonProperty("goods_list")]
        public List<GoodsListResponseModel> GoodsList { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total")]
        public long? Total { get; set; }
        public partial class GoodsListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }

        }

    }

}
