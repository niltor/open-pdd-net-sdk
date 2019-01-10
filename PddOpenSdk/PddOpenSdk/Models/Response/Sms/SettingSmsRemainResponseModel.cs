using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class SettingSmsRemainResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_remain_setting_response")]
        public SmsRemainSettingResponseResponseModel SmsRemainSettingResponse { get; set; }
        public partial class SmsRemainSettingResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 结果
            /// </summary>
            [JsonProperty("result")]
            public long? Result { get; set; }

        }

    }

}
