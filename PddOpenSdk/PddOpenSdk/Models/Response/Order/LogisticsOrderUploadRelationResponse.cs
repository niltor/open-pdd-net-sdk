namespace PddOpenSdk.Models.Response.Order;
public partial class LogisticsOrderUploadRelationResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("upload_extra_logistics_response")]
    public UploadExtraLogisticsResponseResponse UploadExtraLogisticsResponse { get; set; }
    public partial class UploadExtraLogisticsResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功，false-失败，true-成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

