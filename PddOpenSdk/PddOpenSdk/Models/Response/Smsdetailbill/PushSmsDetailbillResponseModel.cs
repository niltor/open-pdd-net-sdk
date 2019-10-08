using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Smsdetailbill
{
    public partial class PushSmsDetailbillResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_detailbill_push_resposne")]
        public SmsDetailbillPushResposneResponseModel SmsDetailbillPushResposne { get; set; }
        public partial class SmsDetailbillPushResposneResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }

        }

    }

}
