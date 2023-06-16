namespace PddOpenSdk.Models.Response.MallShop;
public partial class BatchOpenKmsEncryptResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("open_kms_encrypt_batch_response")]
    public OpenKmsEncryptBatchResponseResponse OpenKmsEncryptBatchResponse { get; set; }
    public partial class OpenKmsEncryptBatchResponseResponse : PddResponseModel
    {

        /// <summary>
        /// list
        /// </summary>
        [JsonPropertyName("data_encrypt_list")]
        public List<DataEncryptListResponse> DataEncryptList { get; set; }
        public partial class DataEncryptListResponse : PddResponseModel
        {

            /// <summary>
            /// 明文数据
            /// </summary>
            [JsonPropertyName("data")]
            public string Data { get; set; }

            /// <summary>
            /// 加密结果
            /// </summary>
            [JsonPropertyName("data_encrypt")]
            public string DataEncrypt { get; set; }

            /// <summary>
            /// 是否支持搜索
            /// </summary>
            [JsonPropertyName("search")]
            public bool? Search { get; set; }

            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonPropertyName("success")]
            public bool? Success { get; set; }

            /// <summary>
            /// 敏感信息类型. id: 身份证号, phone: 手机号码, simple: 昵称, 地址等
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; }

        }

    }

}

