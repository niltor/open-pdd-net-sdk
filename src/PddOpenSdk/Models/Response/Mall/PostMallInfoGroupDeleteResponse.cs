namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoGroupDeleteResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

    }

}

