namespace PddOpenSdk.Models.Response.Refund;
public partial class CancelRdcPddgeniusSendgoodsResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("rdc_pddgenius_sendgoods_cancel_response")]
    public RdcPddgeniusSendgoodsCancelResponseResponse RdcPddgeniusSendgoodsCancelResponse { get; set; }
    public partial class RdcPddgeniusSendgoodsCancelResponseResponse : PddResponseModel
    {

        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// result_data
            /// </summary>
            [JsonPropertyName("result_data")]
            public ResultDataResponse ResultData { get; set; }
            public partial class ResultDataResponse : PddResponseModel
            {

                /// <summary>
                /// 退款单ID
                /// </summary>
                [JsonPropertyName("refund_id")]
                public long? RefundId { get; set; }

            }

        }

    }

}

