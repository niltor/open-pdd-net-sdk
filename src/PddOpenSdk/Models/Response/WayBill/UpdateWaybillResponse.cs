namespace PddOpenSdk.Models.Response.WayBill;
public partial class UpdateWaybillResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_waybill_update_response")]
    public PddWaybillUpdateResponseResponse PddWaybillUpdateResponse { get; set; }
    public partial class PddWaybillUpdateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 模板内容
        /// </summary>
        [JsonPropertyName("print_data")]
        public string PrintData { get; set; }

        /// <summary>
        /// 面单号
        /// </summary>
        [JsonPropertyName("waybill_code")]
        public string WaybillCode { get; set; }

    }

}

