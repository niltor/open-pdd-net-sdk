namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoGroupUpdateResponse : PddResponseModel
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
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

    }

}

