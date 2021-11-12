namespace PddOpenSdk.Models.Response.Oversea;
public partial class SignOverseaCustomsClearanceGetResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 加签结果
        /// </summary>
        [JsonPropertyName("data_signature")]
        public string DataSignature { get; set; }

    }

}

