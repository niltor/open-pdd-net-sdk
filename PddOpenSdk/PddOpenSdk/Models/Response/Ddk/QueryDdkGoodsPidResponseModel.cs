using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class QueryDdkGoodsPidResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("p_id_query_response")]
        public PIdQueryResponseResponseModel PIdQueryResponse { get; set; }
        public partial class PIdQueryResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 返回推广位总数
            /// </summary>
            [JsonProperty ("total_count")]
            public long? TotalCount { get; set; }
            /// <summary>
            /// 多多进宝推广位对象列表
            /// </summary>
            [JsonProperty ("p_id_list")]
            public List<PIdListResponseModel> PIdList { get; set; }
            public partial class PIdListResponseModel : PddResponseModel {
                /// <summary>
                /// 推广位生成时间
                /// </summary>
                [JsonProperty ("create_time")]
                public long? CreateTime { get; set; }
                /// <summary>
                /// 推广位ID
                /// </summary>
                [JsonProperty ("p_id")]
                public string PId { get; set; }
                /// <summary>
                /// 推广位名称
                /// </summary>
                [JsonProperty ("pid_name")]
                public string PidName { get; set; }

            }

        }

    }

}