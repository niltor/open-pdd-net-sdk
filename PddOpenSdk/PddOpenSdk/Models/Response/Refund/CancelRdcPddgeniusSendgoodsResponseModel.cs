using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Refund
{
    public partial class CancelRdcPddgeniusSendgoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("rdc_pddgenius_sendgoods_cancel_response")]
        public RdcPddgeniusSendgoodsCancelResponseResponseModel RdcPddgeniusSendgoodsCancelResponse { get; set; }
        public partial class RdcPddgeniusSendgoodsCancelResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// result
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// result_data
                /// </summary>
                [JsonProperty("result_data")]
                public ResultDataResponseModel ResultData { get; set; }
                public partial class ResultDataResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 退款单ID
                    /// </summary>
                    [JsonProperty("refund_id")]
                    public long? RefundId { get; set; }

                }

            }

        }

    }

}
