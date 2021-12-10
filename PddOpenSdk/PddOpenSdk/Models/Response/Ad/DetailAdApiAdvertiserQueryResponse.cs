namespace PddOpenSdk.Models.Response.Ad;
public partial class DetailAdApiAdvertiserQueryResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 广告主审核状态。1表示审核通过，2表示待审核，3表示审核拒绝，4表示复审拒绝。
            /// </summary>
            [JsonPropertyName("advertiser_audit_status")]
            public int? AdvertiserAuditStatus { get; set; }

            /// <summary>
            /// 惩罚信息
            /// </summary>
            [JsonPropertyName("advertiser_punish_detail")]
            public AdvertiserPunishDetailResponse AdvertiserPunishDetail { get; set; }

            /// <summary>
            /// 广告主审核原因
            /// </summary>
            [JsonPropertyName("audit_reason")]
            public int? AuditReason { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("mall_Id")]
            public long? MallId { get; set; }
            public partial class AdvertiserPunishDetailResponse : PddResponseModel
            {

                /// <summary>
                /// 惩罚原因
                /// </summary>
                [JsonPropertyName("punish_reason")]
                public string PunishReason { get; set; }

                /// <summary>
                /// 惩罚状态。1表示正常，2表示惩罚中。
                /// </summary>
                [JsonPropertyName("punish_status")]
                public int? PunishStatus { get; set; }

            }

        }

    }

}

