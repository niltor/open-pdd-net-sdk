using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Logistics
{
    public partial class GetLogisticsOrdertraceResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("logistics_ordertrace_get_resposne")]
        public LogisticsOrdertraceGetResposneResponseModel LogisticsOrdertraceGetResposne { get; set; }
        public partial class LogisticsOrdertraceGetResposneResponseModel : PddResponseModel
        {
            /// <summary>
            /// 返回列表
            /// </summary>
            [JsonProperty("trace_list")]
            public List<TraceListResponseModel> TraceList { get; set; }
            public partial class TraceListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 状态发生的时间
                /// </summary>
                [JsonProperty("status_time")]
                public string StatusTime { get; set; }
                /// <summary>
                /// 状态描述
                /// </summary>
                [JsonProperty("status_desc")]
                public string StatusDesc { get; set; }
                /// <summary>
                /// 节点说明 ，指明当前节点揽收、派送，签收。
                /// </summary>
                [JsonProperty("action")]
                public string Action { get; set; }
                /// <summary>
                /// 地址地一
                /// </summary>
                [JsonProperty("node_description")]
                public string NodeDescription { get; set; }
                /// <summary>
                /// 时间。。
                /// </summary>
                [JsonProperty("time")]
                public string Time { get; set; }
                /// <summary>
                /// 描述
                /// </summary>
                [JsonProperty("desc")]
                public string Desc { get; set; }

            }

        }

    }

}
