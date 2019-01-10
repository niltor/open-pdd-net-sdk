using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Time
{
    public partial class GetTimeResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("time_get_response")]
        public TimeGetResponseResponseModel TimeGetResponse { get; set; }
        public partial class TimeGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 拼多多系统时间
            /// </summary>
            [JsonProperty("time")]
            public string Time { get; set; }

        }

    }

}
