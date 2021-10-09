namespace PddOpenSdk.Models.Response.Fds;
public partial class CancelFdsWaybillResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_fds_waybill_cancel_response")]
    public PddFdsWaybillCancelResponseResponse PddFdsWaybillCancelResponse { get; set; }
    public partial class PddFdsWaybillCancelResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 取消回传结果true:成功false：失败
        /// </summary>
        [JsonPropertyName("return_result")]
        public bool? ReturnResult { get; set; }

    }

}

