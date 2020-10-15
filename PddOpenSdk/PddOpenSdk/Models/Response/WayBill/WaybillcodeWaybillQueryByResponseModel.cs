using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.WayBill
{
    public partial class WaybillcodeWaybillQueryByResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_waybill_query_by_waybillcode_response")]
        public PddWaybillQueryByWaybillcodeResponseResponseModel PddWaybillQueryByWaybillcodeResponse { get; set; }
        public partial class PddWaybillQueryByWaybillcodeResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 查询返回值
            /// </summary>
            [JsonProperty("modules")]
            public List<ModulesResponseModel> Modules { get; set; }
            public partial class ModulesResponseModel : PddResponseModel
            {
                /// <summary>
                /// 面单查询结构体
                /// </summary>
                [JsonProperty("waybill_cloud_print_response")]
                public WaybillCloudPrintResponseResponseModel WaybillCloudPrintResponse { get; set; }
                public partial class WaybillCloudPrintResponseResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 请求id
                    /// </summary>
                    [JsonProperty("object_id")]
                    public string ObjectId { get; set; }
                    /// <summary>
                    /// 面单信息
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

    }

}
