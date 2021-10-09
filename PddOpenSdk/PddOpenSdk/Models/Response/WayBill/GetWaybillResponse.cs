namespace PddOpenSdk.Models.Response.WayBill;
public partial class GetWaybillResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_waybill_get_response")]
    public PddWaybillGetResponseResponse PddWaybillGetResponse { get; set; }
    public partial class PddWaybillGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [JsonPropertyName("modules")]
        public List<ModulesResponse> Modules { get; set; }
        public partial class ModulesResponse : PddResponseModel
        {

            /// <summary>
            /// 请求id
            /// </summary>
            [JsonPropertyName("object_id")]
            public string ObjectId { get; set; }

            /// <summary>
            /// 快运母单号
            /// </summary>
            [JsonPropertyName("parent_waybill_code")]
            public string ParentWaybillCode { get; set; }

            /// <summary>
            /// 面单信息
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

}

