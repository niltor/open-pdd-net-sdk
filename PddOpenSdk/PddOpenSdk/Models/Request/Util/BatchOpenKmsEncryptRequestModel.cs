using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Util
{
    public partial class BatchOpenKmsEncryptRequestModel : PddRequestModel
    {
        /// <summary>
        /// 要加密的数据列表, 列表大小不超过100
        /// </summary>
        [JsonProperty("data_list")]
        public List<DataListRequestModel> DataList { get; set; }
        public partial class DataListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 明文数据
            /// </summary>
            [JsonProperty("data")]
            public string Data { get; set; }
            /// <summary>
            /// 是否支持搜索
            /// </summary>
            [JsonProperty("search")]
            public bool Search { get; set; }
            /// <summary>
            /// 敏感信息类型. id: 身份证号, phone: 手机号码, simple: 昵称, 地址等
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; }

        }

    }

}
