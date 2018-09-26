using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Virtual
{
    public class MobileChargeNotifyResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class NotifyVirtualMobileChargeResponseModel
    {

        /// <summary>
        /// Examples: {"success":true}
        /// </summary>
        [JsonProperty("mobile_charge_notify_response")]
        public MobileChargeNotifyResponse MobileChargeNotifyResponse { get; set; }
    }


}
