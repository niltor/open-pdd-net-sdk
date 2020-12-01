using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsSizespecClassResponseModel : PddResponseModel
    {
        /// <summary>
        /// 响应
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 错误码
            /// </summary>
            [JsonProperty("error_code")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 错误描述
            /// </summary>
            [JsonProperty("error_msg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 结果
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            /// <summary>
            /// 请求成功
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 尺码表叶分类（二级分类）
                /// </summary>
                [JsonProperty("children")]
                public List<ChildrenResponseModel> Children { get; set; }
                /// <summary>
                /// 尺码表分类id
                /// </summary>
                [JsonProperty("id")]
                public int? Id { get; set; }
                /// <summary>
                /// 尺码表分类名称
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; set; }
                public partial class ChildrenResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 尺码表分类id
                    /// </summary>
                    [JsonProperty("id")]
                    public int? Id { get; set; }
                    /// <summary>
                    /// 尺码表分类名称
                    /// </summary>
                    [JsonProperty("name")]
                    public string Name { get; set; }

                }

            }

        }

    }

}
