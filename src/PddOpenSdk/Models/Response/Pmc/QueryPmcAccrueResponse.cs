namespace PddOpenSdk.Models.Response.Pmc;
public partial class QueryPmcAccrueResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pmc_user_get_response")]
    public PmcUserGetResponseResponse PmcUserGetResponse { get; set; }
    public partial class PmcUserGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 消息积压数量
        /// </summary>
        [JsonPropertyName("number")]
        public long? Number { get; set; }

    }

}

