namespace PddOpenSdk.Models.Response.WayBill;
public partial class WaybillcodeWaybillQueryByResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_waybill_query_by_waybillcode_response")]
    public PddWaybillQueryByWaybillcodeResponseResponse PddWaybillQueryByWaybillcodeResponse { get; set; }
    public partial class PddWaybillQueryByWaybillcodeResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 查询返回值
        /// </summary>
        [JsonPropertyName("modules")]
        public List<ModulesResponse> Modules { get; set; }
        public partial class ModulesResponse : PddResponseModel
        {

            /// <summary>
            /// 面单查询结构体
            /// </summary>
            [JsonPropertyName("waybill_cloud_print_response")]
            public WaybillCloudPrintResponseResponse WaybillCloudPrintResponse { get; set; }
            public partial class WaybillCloudPrintResponseResponse : PddResponseModel
            {

                /// <summary>
                /// 请求id
                /// </summary>
                [JsonPropertyName("object_id")]
                public string ObjectId { get; set; }

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

}

