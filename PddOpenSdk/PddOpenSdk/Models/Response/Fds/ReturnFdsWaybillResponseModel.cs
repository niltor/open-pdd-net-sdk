using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Fds
{
    public partial class ReturnFdsWaybillResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_fds_waybill_return_response")]
        public PddFdsWaybillReturnResponseResponseModel PddFdsWaybillReturnResponse { get; set; }
        public partial class PddFdsWaybillReturnResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 回传结果true:成功false：失败
            /// </summary>
            [JsonProperty("return_result")]
            public bool? ReturnResult { get; set; }

        }

    }

}
