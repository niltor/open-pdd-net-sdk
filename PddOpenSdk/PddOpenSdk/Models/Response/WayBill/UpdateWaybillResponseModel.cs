using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.WayBill
{
    public partial class UpdateWaybillResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_waybill_update_response")]
        public PddWaybillUpdateResponseResponseModel PddWaybillUpdateResponse { get; set; }
        public partial class PddWaybillUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 模板内容
            /// </summary>
            [JsonProperty("print_data")]
            public string PrintData { get; set; }
            /// <summary>
            /// 面单号
            /// </summary>
            [JsonProperty("waybill_code")]
            public string WaybillCode { get; set; }

        }

    }

}
