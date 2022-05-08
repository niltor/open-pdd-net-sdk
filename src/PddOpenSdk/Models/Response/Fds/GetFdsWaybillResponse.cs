namespace PddOpenSdk.Models.Response.Fds;
public partial class GetFdsWaybillResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_fds_waybill_get_response")]
    public PddFdsWaybillGetResponseResponse PddFdsWaybillGetResponse { get; set; }
    public partial class PddFdsWaybillGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [JsonPropertyName("modules")]
        public List<ModulesResponse> Modules { get; set; }
        public partial class ModulesResponse : PddResponseModel
        {

            /// <summary>
            /// 请求 id
            /// </summary>
            [JsonPropertyName("object_id")]
            public string ObjectId { get; set; }

            /// <summary>
            /// 快运母单号
            /// </summary>
            [JsonPropertyName("parent_waybill_code")]
            public string ParentWaybillCode { get; set; }

            /// <summary>
            /// 模板内容（模板内容加密，只需透传至打印组件
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

