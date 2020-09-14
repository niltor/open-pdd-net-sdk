using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Fds
{
    public partial class CancelFdsWaybillResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_fds_waybill_cancel_response")]
        public PddFdsWaybillCancelResponseResponseModel PddFdsWaybillCancelResponse { get; set; }
        public partial class PddFdsWaybillCancelResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 取消回传结果true:成功false：失败
            /// </summary>
            [JsonProperty("return_result")]
            public bool? ReturnResult { get; set; }

        }

    }

}
