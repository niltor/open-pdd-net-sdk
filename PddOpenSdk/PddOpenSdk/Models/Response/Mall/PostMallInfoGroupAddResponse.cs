namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoGroupAddResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 门店组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

    }

}

