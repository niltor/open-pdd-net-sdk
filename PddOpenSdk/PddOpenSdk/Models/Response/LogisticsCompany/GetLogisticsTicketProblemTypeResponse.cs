namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class GetLogisticsTicketProblemTypeResponse : PddResponseModel
{

    /// <summary>
    /// 返回response
    /// </summary>
    [JsonPropertyName("logistics_problem_type_get_response")]
    public LogisticsProblemTypeGetResponseResponse LogisticsProblemTypeGetResponse { get; set; }
    public partial class LogisticsProblemTypeGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 问题类型list
        /// </summary>
        [JsonPropertyName("logistics_problem_type_list")]
        public List<LogisticsProblemTypeListResponse> LogisticsProblemTypeList { get; set; }
        public partial class LogisticsProblemTypeListResponse : PddResponseModel
        {

            /// <summary>
            /// 问题类型id
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 问题类型描述
            /// </summary>
            [JsonPropertyName("type_desc")]
            public string TypeDesc { get; set; }

        }

    }

}

