namespace PddOpenSdk.Models.Response.Ad;
public partial class QueryAdApiReportActivityReportResponse : PddResponseModel
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
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 活动列表
            /// </summary>
            [JsonPropertyName("activities")]
            public List<ActivitiesResponse> Activities { get; set; }

            /// <summary>
            /// 汇总报表
            /// </summary>
            [JsonPropertyName("sumReport")]
            public SumReportResponse SumReport { get; set; }
            public partial class ActivitiesResponse : PddResponseModel
            {

                /// <summary>
                /// 活动开始时间,日期格式:yyyy-MM-dd HH:mm
                /// </summary>
                [JsonPropertyName("beginDate")]
                public string BeginDate { get; set; }

                /// <summary>
                /// 活动结束日期,日期格式:yyyy-MM-dd HH:mm
                /// </summary>
                [JsonPropertyName("endDate")]
                public string EndDate { get; set; }

                /// <summary>
                /// 活动名称
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; }

                /// <summary>
                /// 活动报名截止时间,日期格式:yyyy-MM-dd HH:mm
                /// </summary>
                [JsonPropertyName("signUpDeadline")]
                public string SignUpDeadline { get; set; }

                /// <summary>
                /// 本场活动花费（单位厘）
                /// </summary>
                [JsonPropertyName("spend")]
                public long? Spend { get; set; }

            }
            public partial class SumReportResponse : PddResponseModel
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
                /// 广告曝光量
                /// </summary>
                [JsonPropertyName("impression")]
                public long? Impression { get; set; }

                /// <summary>
                /// 店铺关注数
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
                /// 广告消耗,单位厘
                /// </summary>
                [JsonPropertyName("spend")]
                public long? Spend { get; set; }

                /// <summary>
                /// 转化成本
                /// </summary>
                [JsonPropertyName("transactionCost")]
                public double? TransactionCost { get; set; }

            }

        }

    }

}

