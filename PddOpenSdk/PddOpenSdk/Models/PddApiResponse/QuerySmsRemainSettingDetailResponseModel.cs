using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsRemainSettingDetailResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_remain_setting_detail_query_response")]
        public object SmsRemainSettingDetailQueryResponse { get; set; }

        public partial class SmsRemainSettingDetailQueryResponseResponseModel : PddResponseModel
        {

        }

    }
}
