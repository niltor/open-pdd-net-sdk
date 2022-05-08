namespace PddOpenSdk.Models.Response.SmsVendor;
public partial class PushSmsDetailbillResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("sms_detailbill_push_resposne")]
    public SmsDetailbillPushResposneResponse SmsDetailbillPushResposne { get; set; }
    public partial class SmsDetailbillPushResposneResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

