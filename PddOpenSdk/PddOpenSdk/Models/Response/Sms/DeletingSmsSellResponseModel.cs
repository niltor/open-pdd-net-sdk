using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsSellDeletingResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class DeletingSmsSellResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("sms_sell_deleting_response")]
        public SmsSellDeletingResponse SmsSellDeletingResponse { get; set; }
    }


}
