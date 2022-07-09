namespace PddOpenSdk.Models.Response.Util;
public partial class GetPopMallBindTicketResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// ticket
        /// </summary>
        [JsonPropertyName("ticket")]
        public string Ticket { get; set; }

    }

}

