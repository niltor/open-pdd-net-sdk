using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.MallShop
{
    public partial class InfoTraceSourceUploadPlanResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("status")]
            public int? Status { get; set; }

        }

    }

}
