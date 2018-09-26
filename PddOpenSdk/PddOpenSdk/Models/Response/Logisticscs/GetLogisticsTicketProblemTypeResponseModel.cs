using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public class LogisticsProblemTypeList
    {

        /// <summary>
        /// Examples: 301, 422
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: "核实是否丢件", "未签收求赔付"
        /// </summary>
        [JsonProperty("type_desc")]
        public string TypeDesc { get; set; }
    }

    public class LogisticsProblemTypeGetResponse
    {

        /// <summary>
        /// Examples: [{"id":301,"type_desc":"核实是否丢件"},{"id":422,"type_desc":"未签收求赔付"}]
        /// </summary>
        [JsonProperty("logistics_problem_type_list")]
        public IList<LogisticsProblemTypeList> LogisticsProblemTypeList { get; set; }
    }

    public class GetLogisticsTicketProblemTypeResponseModel
    {

        /// <summary>
        /// Examples: {"logistics_problem_type_list":[{"id":301,"type_desc":"核实是否丢件"},{"id":422,"type_desc":"未签收求赔付"}]}
        /// </summary>
        [JsonProperty("logistics_problem_type_get_response")]
        public LogisticsProblemTypeGetResponse LogisticsProblemTypeGetResponse { get; set; }
    }


}
