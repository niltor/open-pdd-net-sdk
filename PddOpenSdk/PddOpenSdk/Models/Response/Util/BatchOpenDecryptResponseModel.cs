using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Util
{
    public partial class BatchOpenDecryptResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("open_decrypt_batch_response")]
        public OpenDecryptBatchResponseResponseModel OpenDecryptBatchResponse { get; set; }
        public partial class OpenDecryptBatchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("data_decrypt_list")]
            public List<DataDecryptListResponseModel> DataDecryptList { get; set; }
            public partial class DataDecryptListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 解密tag，对于订单数据是订单号
                /// </summary>
                [JsonProperty("data_tag")]
                public string DataTag { get; set; }
                /// <summary>
                /// 1、虚拟卡密;2、虚拟卡号;3、支付商品编码;4、支付单号;5、收件人;6、收件人手机号;7、收件人完整地址;8、收件人详细地址;9、快递单号;10、身份证号;11、身份证姓名
                /// </summary>
                [JsonProperty("data_type")]
                public int? DataType { get; set; }
                /// <summary>
                /// 解密结果
                /// </summary>
                [JsonProperty("decrypted_data")]
                public string DecryptedData { get; set; }
                /// <summary>
                /// 加密数据
                /// </summary>
                [JsonProperty("encrypted_data")]
                public string EncryptedData { get; set; }
                /// <summary>
                /// 错误码, 0:成功
                /// </summary>
                [JsonProperty("error_code")]
                public int? ErrorCode { get; set; }
                /// <summary>
                /// 错误信息
                /// </summary>
                [JsonProperty("error_msg")]
                public string ErrorMsg { get; set; }

            }

        }

    }

}
