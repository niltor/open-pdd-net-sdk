namespace PddOpenSdk.Models.Response.Ad;
public partial class PrivilegeAdApiUnitTrListGoodsBidResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 是否支持切换出价方式
            /// </summary>
            [JsonPropertyName("canChangeBidType")]
            public bool? CanChangeBidType { get; set; }

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

        }

    }

}

