using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Oversea
{
    public partial class NotifyOverseaDeclarationFailResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("notify_exceeded_response")]
        public NotifyExceededResponseResponseModel NotifyExceededResponse { get; set; }
        public partial class NotifyExceededResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// true=处理成功
            /// </summary>
            [JsonProperty("result")]
            public bool? Result { get; set; }

        }

    }

}
