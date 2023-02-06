namespace PddOpenSdk.Models.Response.Ad;
public partial class SuggestAdApiUnitTrListGoodsBidResponse : PddResponseModel
{

    /// <summary>
    /// 响应信息
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 错误代码
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误参数
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 建议出价方式 1-目标roi 2-成交出价
            /// </summary>
            [JsonPropertyName("defaultBidType")]
            public int? DefaultBidType { get; set; }

            /// <summary>
            /// 商品id
            /// </summary>
            [JsonPropertyName("goodsId")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 建议成交出价，是否有值取决于出价权限，若无权限，该值为0
            /// </summary>
            [JsonPropertyName("suggestOptimizationBid")]
            public long? SuggestOptimizationBid { get; set; }

            /// <summary>
            /// 建议目标roi，是否有值取决于出价权限，若无权限，该值为0
            /// </summary>
            [JsonPropertyName("suggestTargetRoi")]
            public long? SuggestTargetRoi { get; set; }

        }

    }

}

