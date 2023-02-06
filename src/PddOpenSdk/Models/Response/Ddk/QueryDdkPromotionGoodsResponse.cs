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
            /// 报备状态，0-已创建，1-已提交，2-已通过，3-已驳回
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

        }

    }

}

