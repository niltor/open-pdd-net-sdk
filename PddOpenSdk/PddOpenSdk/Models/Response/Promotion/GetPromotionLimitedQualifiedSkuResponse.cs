namespace PddOpenSdk.Models.Response.Promotion;
public partial class GetPromotionLimitedQualifiedSkuResponse : PddResponseModel
{

    /// <summary>
    /// 不可选sku列表
    /// </summary>
    [JsonPropertyName("in_valid_sku_List")]
    public List<InValidSkuListResponse> InValidSkuList { get; set; }

    /// <summary>
    /// 可选sku列表
    /// </summary>
    [JsonPropertyName("valid_sku_list")]
    public List<ValidSkuListResponse> ValidSkuList { get; set; }
    public partial class InValidSkuListResponse : PddResponseModel
    {

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 不可选原因
        /// </summary>
        [JsonPropertyName("invalid_reason")]
        public string InvalidReason { get; set; }

        /// <summary>
        /// skuid
        /// </summary>
        [JsonPropertyName("sku_id")]
        public long? SkuId { get; set; }

        /// <summary>
        /// sku是否可以设置营销工具活动价。0-sku有效，1-sku需上架，2-sku库存需≥3，3-sku参考价不符合规则
        /// </summary>
        [JsonPropertyName("valid_status")]
        public int? ValidStatus { get; set; }

    }
    public partial class ValidSkuListResponse : PddResponseModel
    {

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 不可选原因
        /// </summary>
        [JsonPropertyName("invalid_reason")]
        public string InvalidReason { get; set; }

        /// <summary>
        /// skuid
        /// </summary>
        [JsonPropertyName("sku_id")]
        public long? SkuId { get; set; }

        /// <summary>
        /// sku是否可以设置营销工具活动价。0-sku有效，1-sku需上架，2-sku库存需≥3，3-sku参考价不符合规则
        /// </summary>
        [JsonPropertyName("valid_status")]
        public int? ValidStatus { get; set; }

    }

}

