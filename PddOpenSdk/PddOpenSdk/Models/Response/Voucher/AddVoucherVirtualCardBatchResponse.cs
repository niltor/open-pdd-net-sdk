namespace PddOpenSdk.Models.Response.Voucher;
public partial class AddVoucherVirtualCardBatchResponse : PddResponseModel
{

    /// <summary>
    /// 响应体
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 状态码
        /// </summary>
        [JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 响应信息
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 卡密批次Id
            /// </summary>
            [JsonPropertyName("batchId")]
            public long? BatchId { get; set; }

            /// <summary>
            /// 充值地址
            /// </summary>
            [JsonPropertyName("chargeAddress")]
            public string ChargeAddress { get; set; }

            /// <summary>
            /// 店铺Id
            /// </summary>
            [JsonPropertyName("mallId")]
            public long? MallId { get; set; }

            /// <summary>
            /// 批次添加的卡密数量
            /// </summary>
            [JsonPropertyName("totalNum")]
            public int? TotalNum { get; set; }

        }

    }

}

