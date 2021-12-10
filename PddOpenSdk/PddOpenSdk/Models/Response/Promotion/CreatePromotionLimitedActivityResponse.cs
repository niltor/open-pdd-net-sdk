namespace PddOpenSdk.Models.Response.Promotion;
public partial class CreatePromotionLimitedActivityResponse : PddResponseModel
{

    /// <summary>
    /// 结果列表
    /// </summary>
    [JsonPropertyName("result_list")]
    public List<ResultListResponse> ResultList { get; set; }
    public partial class ResultListResponse : PddResponseModel
    {

        /// <summary>
        /// 创建失败时的失败原因
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品是否创建成功。0代表成功，非0代表失败
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

    }

}

