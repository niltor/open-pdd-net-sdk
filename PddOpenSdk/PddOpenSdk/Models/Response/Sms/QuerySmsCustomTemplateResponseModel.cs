using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class QuerySmsCustomTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_custom_template_list_query_response")]
        public SmsCustomTemplateListQueryResponseResponseModel SmsCustomTemplateListQueryResponse { get; set; }
        public partial class SmsCustomTemplateListQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 总数量
            /// </summary>
            [JsonProperty("total")]
            public int Total { get; set; }
            /// <summary>
            /// 结果
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 模板id
                /// </summary>
                [JsonProperty("id")]
                public long Id { get; set; }
                /// <summary>
                /// 店铺id
                /// </summary>
                [JsonProperty("mall_id")]
                public long MallId { get; set; }
                /// <summary>
                /// 模板名称
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; set; }
                /// <summary>
                /// 更新时间
                /// </summary>
                [JsonProperty("updated_time")]
                public long UpdatedTime { get; set; }
                /// <summary>
                /// 内容
                /// </summary>
                [JsonProperty("content")]
                public List<ContentResponseModel> Content { get; set; }
                /// <summary>
                /// 状态
                /// </summary>
                [JsonProperty("status")]
                public int Status { get; set; }
                /// <summary>
                /// 原因
                /// </summary>
                [JsonProperty("reason")]
                public string Reason { get; set; }
                public partial class ContentResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 类型
                    /// </summary>
                    [JsonProperty("type")]
                    public int Type { get; set; }
                    /// <summary>
                    /// 属性值
                    /// </summary>
                    [JsonProperty("value")]
                    public string Value { get; set; }
                    /// <summary>
                    /// id
                    /// </summary>
                    [JsonProperty("id")]
                    public int Id { get; set; }

                }

            }

        }

    }

}
