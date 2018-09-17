using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsSendRecordListResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_send_record_list_query_response")]
        public object SmsSendRecordListQueryResponse { get; set; }

        public partial class SmsSendRecordListQueryResponseResponseModel : PddResponseModel
        {

        }

    }
}
