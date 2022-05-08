namespace PddOpenSdk.Models.Response.Ad;
public partial class ListAdApiUnitCreativeQueryResponse : PddResponseModel
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
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 每笔成交金额(average pay amount)，单位厘
            /// </summary>
            [JsonPropertyName("avgPayAmount")]
            public double? AvgPayAmount { get; set; }

            /// <summary>
            /// 广告点击量
            /// </summary>
            [JsonPropertyName("click")]
            public long? Click { get; set; }

            /// <summary>
            /// 平均点击花费，单位厘
            /// </summary>
            [JsonPropertyName("cpc")]
            public double? Cpc { get; set; }

            /// <summary>
            /// 千次展现成本
            /// </summary>
            [JsonPropertyName("cpm")]
            public double? Cpm { get; set; }

            /// <summary>
            /// 创意类型。2表示静态创意创意，3表示智能创意。
            /// </summary>
            [JsonPropertyName("creativeType")]
            public int? CreativeType { get; set; }

            /// <summary>
            /// 广告点击率
            /// </summary>
            [JsonPropertyName("ctr")]
            public double? Ctr { get; set; }

            /// <summary>
            /// 点击转化率
            /// </summary>
            [JsonPropertyName("cvr")]
            public double? Cvr { get; set; }

            /// <summary>
            /// 启用状态。1表示启用，2表示暂停。
            /// </summary>
            [JsonPropertyName("dataOperateStatus")]
            public int? DataOperateStatus { get; set; }

            /// <summary>
            /// 广告转化支付金额，单位厘
            /// </summary>
            [JsonPropertyName("gmv")]
            public long? Gmv { get; set; }

            /// <summary>
            /// 商品收藏数
            /// </summary>
            [JsonPropertyName("goodsFavNum")]
            public long? GoodsFavNum { get; set; }

            /// <summary>
            /// 创意图片高
            /// </summary>
            [JsonPropertyName("imageHeight")]
            public int? ImageHeight { get; set; }

            /// <summary>
            /// 创意图片链接
            /// </summary>
            [JsonPropertyName("imageUrl")]
            public string ImageUrl { get; set; }

            /// <summary>
            /// 创意图片宽
            /// </summary>
            [JsonPropertyName("imageWidth")]
            public int? ImageWidth { get; set; }

            /// <summary>
            /// 广告曝光量
            /// </summary>
            [JsonPropertyName("impression")]
            public long? Impression { get; set; }

            /// <summary>
            /// 店铺收藏数
            /// </summary>
            [JsonPropertyName("mallFavNum")]
            public long? MallFavNum { get; set; }

            /// <summary>
            /// 广告转化支付订单量
            /// </summary>
            [JsonPropertyName("orderNum")]
            public long? OrderNum { get; set; }

            /// <summary>
            /// 广告投入产出比
            /// </summary>
            [JsonPropertyName("roi")]
            public double? Roi { get; set; }

            /// <summary>
            /// 广告消耗，单位厘
            /// </summary>
            [JsonPropertyName("spend")]
            public long? Spend { get; set; }

            /// <summary>
            /// 创意单元状态。1表示推广中，2表示手动暂停，3表示已删除，4表示待发布，5表示已驳回。
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 状态描述，当状态是驳回时显示驳回原因
            /// </summary>
            [JsonPropertyName("statusDesc")]
            public string StatusDesc { get; set; }

            /// <summary>
            /// 创意标题
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; }

            /// <summary>
            /// 转化成本
            /// </summary>
            [JsonPropertyName("transactionCost")]
            public double? TransactionCost { get; set; }

            /// <summary>
            /// 创意单元Id
            /// </summary>
            [JsonPropertyName("unitCreativeId")]
            public long? UnitCreativeId { get; set; }

        }

    }

}

