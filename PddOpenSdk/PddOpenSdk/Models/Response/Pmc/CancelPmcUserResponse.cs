namespace PddOpenSdk.Models.Response.Pmc;
public partial class CancelPmcUserResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("tmc_user_cancel_response")]
    public TmcUserCancelResponseResponse TmcUserCancelResponse { get; set; }
    public partial class TmcUserCancelResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

