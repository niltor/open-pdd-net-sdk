using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class QuerySmsTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_template_query_response")]
        public SmsTemplateQueryResponseResponseModel SmsTemplateQueryResponse { get; set; }
        public partial class SmsTemplateQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 列表
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 编号
                /// </summary>
                [JsonProperty("code")]
                public long? Code { get; set; }
                /// <summary>
                /// 描述
                /// </summary>
                [JsonProperty("desc")]
                public string Desc { get; set; }

            }

        }

    }

}
