namespace PddOpenSdk.Models.Response.Util;
public partial class BatchOpenDecryptResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("open_decrypt_batch_response")]
    public OpenDecryptBatchResponseResponse OpenDecryptBatchResponse { get; set; }
    public partial class OpenDecryptBatchResponseResponse : PddResponseModel
    {

        /// <summary>
        /// list
        /// </summary>
        [JsonPropertyName("data_decrypt_list")]
        public List<DataDecryptListResponse> DataDecryptList { get; set; }
        public partial class DataDecryptListResponse : PddResponseModel
        {

            /// <summary>
            /// 解密tag，对于订单数据是订单号
            /// </summary>
            [JsonPropertyName("data_tag")]
            public string DataTag { get; set; }

            /// <summary>
            /// 1、虚拟卡密;2、虚拟卡号;3、支付申报订单号;4、支付单号;5、收件人;6、收件人手机号;7、收件人完整地址;8、收件人详细地址;9、快递单号;10、身份证号;11、身份证姓名
            /// </summary>
            [JsonPropertyName("data_type")]
            public int? DataType { get; set; }

            /// <summary>
            /// 解密结果
            /// </summary>
            [JsonPropertyName("decrypted_data")]
            public string DecryptedData { get; set; }

            /// <summary>
            /// 加密数据
            /// </summary>
            [JsonPropertyName("encrypted_data")]
            public string EncryptedData { get; set; }

            /// <summary>
            /// 错误码, 0:成功
            /// </summary>
            [JsonPropertyName("error_code")]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// 错误信息
            /// </summary>
            [JsonPropertyName("error_msg")]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// 虚拟号类型：0-非虚拟号 1-虚拟号
            /// </summary>
            [JsonPropertyName("virtual_number_type")]
            public int? VirtualNumberType { get; set; }

            /// <summary>
            /// 虚拟号分机号
            /// </summary>
            [JsonPropertyName("virtual_identify_number")]
            public string VirtualIdentifyNumber { get; set; }

        }

    }

}

