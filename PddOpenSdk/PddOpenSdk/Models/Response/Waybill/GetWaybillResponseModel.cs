using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Waybill
{
    public partial class GetWaybillResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_waybill_get_response")]
        public PddWaybillGetResponseResponseModel PddWaybillGetResponse { get; set; }
        public partial class PddWaybillGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 系统自动生成
            /// </summary>
            [JsonProperty("modules")]
            public List<ModulesResponseModel> Modules { get; set; }
            public partial class ModulesResponseModel : PddResponseModel
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
