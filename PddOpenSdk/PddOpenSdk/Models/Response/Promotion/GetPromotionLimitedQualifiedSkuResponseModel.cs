using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Promotion
{
    public partial class GetPromotionLimitedQualifiedSkuResponseModel : PddResponseModel
    {
        /// <summary>
        /// 不可选sku列表
        /// </summary>
        [JsonProperty("in_valid_sku_List")]
        public List<InValidSkuListResponseModel> InValidSkuList { get; set; }
        /// <summary>
        /// 可选sku列表
        /// </summary>
        [JsonProperty("valid_sku_list")]
        public List<ValidSkuListResponseModel> ValidSkuList { get; set; }
        public partial class InValidSkuListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }
            /// <summary>
            /// 不可选原因
            /// </summary>
            [JsonProperty("invalid_reason")]
            public string InvalidReason { get; set; }
            /// <summary>
            /// skuid
            /// </summary>
            [JsonProperty("sku_id")]
            public long? SkuId { get; set; }
            /// <summary>
            /// sku是否可以设置营销工具活动价。0-sku有效，1-sku需上架，2-sku库存需≥3，3-sku参考价不符合规则
            /// </summary>
            [JsonProperty("valid_status")]
            public int? ValidStatus { get; set; }

        }
        public partial class ValidSkuListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }
            /// <summary>
            /// 不可选原因
            /// </summary>
            [JsonProperty("invalid_reason")]
            public string InvalidReason { get; set; }
            /// <summary>
            /// skuid
            /// </summary>
            [JsonProperty("sku_id")]
            public long? SkuId { get; set; }
            /// <summary>
            /// sku是否可以设置营销工具活动价。0-sku有效，1-sku需上架，2-sku库存需≥3，3-sku参考价不符合规则
            /// </summary>
            [JsonProperty("valid_status")]
            public int? ValidStatus { get; set; }

        }

    }

}
