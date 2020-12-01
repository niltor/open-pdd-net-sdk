using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public partial class AddVoucherVirtualCardBatchResponseModel : PddResponseModel
    {
        /// <summary>
        /// 响应体
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 状态码
            /// </summary>
            [JsonProperty("code")]
            public int? Code { get; set; }
            /// <summary>
            /// 错误信息
            /// </summary>
            [JsonProperty("message")]
            public string Message { get; set; }
            /// <summary>
            /// 响应信息
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 卡密批次Id
                /// </summary>
                [JsonProperty("batchId")]
                public long? BatchId { get; set; }
                /// <summary>
                /// 充值地址
                /// </summary>
                [JsonProperty("chargeAddress")]
                public string ChargeAddress { get; set; }
                /// <summary>
                /// 店铺Id
                /// </summary>
                [JsonProperty("mallId")]
                public long? MallId { get; set; }
                /// <summary>
                /// 批次添加的卡密数量
                /// </summary>
                [JsonProperty("totalNum")]
                public int? TotalNum { get; set; }

            }

        }

    }

}
