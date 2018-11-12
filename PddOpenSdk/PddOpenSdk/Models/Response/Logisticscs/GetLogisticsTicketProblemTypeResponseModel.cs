using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public partial class GetLogisticsTicketProblemTypeResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("logistics_problem_type_get_response")]
        public LogisticsProblemTypeGetResponseResponseModel LogisticsProblemTypeGetResponse { get; set; }
        public partial class LogisticsProblemTypeGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 问题类型list
            /// </summary>
            [JsonProperty("logistics_problem_type_list")]
            public List<LogisticsProblemTypeListResponseModel> LogisticsProblemTypeList { get; set; }
            public partial class LogisticsProblemTypeListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 问题类型描述
                /// </summary>
                [JsonProperty("type_desc")]
                public string TypeDesc { get; set; }
                /// <summary>
                /// 问题类型id
                /// </summary>
                [JsonProperty("id")]
                public long Id { get; set; }

            }

        }

    }

}
