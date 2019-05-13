using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class CancelSmsSellSettingRecordResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_sell_setting_record_cancel_response")]
        public SmsSellSettingRecordCancelResponseResponseModel SmsSellSettingRecordCancelResponse { get; set; }
        public partial class SmsSellSettingRecordCancelResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
