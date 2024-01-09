namespace PddOpenSdk.Models.Response.Ddk;
public partial class QueryDdkPromotionGoodsResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 报备记录列表
        /// </summary>
        [JsonPropertyName("application_list")]
        public List<ApplicationListResponse> ApplicationList { get; set; }

        /// <summary>
        /// 报备记录总数
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        public partial class ApplicationListResponse : PddResponseModel
        {

            /// <summary>
            /// 审核信息
            /// </summary>
            [JsonPropertyName("comment")]
            public string Comment { get; set; }

            /// <summary>
            /// 报备提交时间
            /// </summary>
            [JsonPropertyName("commit_time")]
            public long? CommitTime { get; set; }

            /// <summary>
            /// 商品id
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 店铺id
            /// </summary>
            [JsonPropertyName("mall_id")]
            public long? MallId { get; set; }

            /// <summary>
            /// 推广结束时间
            /// </summary>
            [JsonPropertyName("promotion_end_time")]
            public long? PromotionEndTime { get; set; }

            /// <summary>
            /// 推广开始时间
            /// </summary>
            [JsonPropertyName("promotion_start_time")]
            public long? PromotionStartTime { get; set; }

            /// <summary>
            /// 报备状态。0-已创建，1-已提交，2-已通过，3-已驳回
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 最后更新时间
            /// </summary>
            [JsonPropertyName("updated_at")]
            public long? UpdatedAt { get; set; }

        }

    }

}

