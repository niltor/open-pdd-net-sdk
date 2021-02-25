using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Util
{
    public partial class ReportOpenWaybillTypeResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("open_waybill_type_report_response")]
        public OpenWaybillTypeReportResponseResponseModel OpenWaybillTypeReportResponse { get; set; }
        public partial class OpenWaybillTypeReportResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 结果列表
            /// </summary>
            [JsonProperty("result_list")]
            public List<ResultListResponseModel> ResultList { get; set; }
            public partial class ResultListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 订单号
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }
                /// <summary>
                /// true：报备成功，false：报备失败
                /// </summary>
                [JsonProperty("success")]
                public bool? Success { get; set; }

            }

        }

    }

}
