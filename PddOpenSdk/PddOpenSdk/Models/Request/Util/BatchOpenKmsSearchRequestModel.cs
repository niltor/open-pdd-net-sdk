using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Util
{
    public partial class BatchOpenKmsSearchRequestModel : PddRequestModel
    {
        /// <summary>
        /// 数据列表, 列表大小不超过100
        /// </summary>
        [JsonProperty("input_list")]
        public List<InputListRequestModel> InputList { get; set; }
        public partial class InputListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 搜索内容
            /// </summary>
            [JsonProperty("input")]
            public string Input { get; set; }
            /// <summary>
            /// 敏感信息类型. id: 身份证号, phone: 手机号码, simple: 昵称, 地址等
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; }

        }

    }

}
