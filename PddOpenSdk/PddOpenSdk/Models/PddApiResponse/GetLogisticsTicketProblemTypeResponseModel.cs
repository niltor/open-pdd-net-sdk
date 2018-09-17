using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetLogisticsTicketProblemTypeResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("logistics_problem_type_get_response")]
        public object LogisticsProblemTypeGetResponse { get; set; }

        public partial class LogisticsProblemTypeGetResponseResponseModel : PddResponseModel
        {

        }

    }
}
