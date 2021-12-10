namespace PddOpenSdk.Models.Response.WayBill;
public partial class CancelWaybillResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_waybill_cancel_response")]
    public PddWaybillCancelResponseResponse PddWaybillCancelResponse { get; set; }
    public partial class PddWaybillCancelResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 调用取消是否成功
        /// </summary>
        [JsonPropertyName("cancel_result")]
        public bool? CancelResult { get; set; }

    }

}

