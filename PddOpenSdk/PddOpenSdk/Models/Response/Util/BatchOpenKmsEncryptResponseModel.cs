using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Util
{
    public partial class BatchOpenKmsEncryptResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("open_kms_encrypt_batch_response")]
        public OpenKmsEncryptBatchResponseResponseModel OpenKmsEncryptBatchResponse { get; set; }
        public partial class OpenKmsEncryptBatchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("data_encrypt_list")]
            public List<DataEncryptListResponseModel> DataEncryptList { get; set; }
            public partial class DataEncryptListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 明文数据
                /// </summary>
                [JsonProperty("data")]
                public string Data { get; set; }
                /// <summary>
                /// 加密结果
                /// </summary>
                [JsonProperty("data_encrypt")]
                public string DataEncrypt { get; set; }
                /// <summary>
                /// 是否支持搜索
                /// </summary>
                [JsonProperty("search")]
                public bool? Search { get; set; }
                /// <summary>
                /// 是否成功
                /// </summary>
                [JsonProperty("success")]
                public bool? Success { get; set; }
                /// <summary>
                /// 敏感信息类型. id: 身份证号, phone: 手机号码, simple: 昵称, 地址等
                /// </summary>
                [JsonProperty("type")]
                public string Type { get; set; }

            }

        }

    }

}
