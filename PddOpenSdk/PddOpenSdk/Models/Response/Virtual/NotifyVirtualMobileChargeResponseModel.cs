using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Virtual
{
    public partial class NotifyVirtualMobileChargeResponseModel : PddResponseModel
    {
        /// <summary>
        /// 虚拟充值回调通知响应对象
        /// </summary>
        [JsonProperty("mobile_charge_notify_response")]
        public MobileChargeNotifyResponseResponseModel MobileChargeNotifyResponse { get; set; }
        public partial class MobileChargeNotifyResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 回调通知结果，true-成功，false-失败
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }

        }

    }

}
