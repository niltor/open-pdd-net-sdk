using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsSellSettingRecordCancelResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class CancelSmsSellSettingRecordResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("sms_sell_setting_record_cancel_response")]
        public SmsSellSettingRecordCancelResponse SmsSellSettingRecordCancelResponse { get; set; }
    }


}
