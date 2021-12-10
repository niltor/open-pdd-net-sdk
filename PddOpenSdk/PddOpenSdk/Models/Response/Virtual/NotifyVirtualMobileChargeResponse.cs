namespace PddOpenSdk.Models.Response.Virtual;
public partial class NotifyVirtualMobileChargeResponse : PddResponseModel
{

    /// <summary>
    /// 虚拟充值回调通知响应对象
    /// </summary>
    [JsonPropertyName("mobile_charge_notify_response")]
    public MobileChargeNotifyResponseResponse MobileChargeNotifyResponse { get; set; }
    public partial class MobileChargeNotifyResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 回调通知结果，true-成功，false-失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

