namespace PddOpenSdk.Models.Response.MallShop;
public partial class InfoTraceSourceUploadPlanResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

    }

}

