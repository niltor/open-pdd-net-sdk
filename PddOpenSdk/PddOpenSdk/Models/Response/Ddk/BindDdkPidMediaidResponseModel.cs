using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class BindDdkPidMediaidResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("p_id_bind_response")]
        public PIdBindResponseResponseModel PIdBindResponse { get; set; }
        public partial class PIdBindResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 绑定结果
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 绑定结果文本提示
                /// </summary>
                [JsonProperty("msg")]
                public string Msg { get; set; }
                /// <summary>
                /// 绑定结果
                /// </summary>
                [JsonProperty("result")]
                public bool? Result { get; set; }

            }

        }

    }

}
