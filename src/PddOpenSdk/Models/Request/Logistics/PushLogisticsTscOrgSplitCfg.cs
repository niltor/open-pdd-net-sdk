namespace PddOpenSdk.Models.Request.Logistics;
public partial class PushLogisticsTscOrgSplitCfg
{

    /// <summary>
    /// 请求体
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 操作类型，0-删除 1-新增
        /// </summary>
        [JsonPropertyName("action")]
        public int Action { get; set; }

        /// <summary>
        /// 数据列表，每次最多10条
        /// </summary>
        [JsonPropertyName("items")]
        public List<ItemsModel> Items { get; set; }

        /// <summary>
        /// 操作唯一码40个字符
        /// </summary>
        [JsonPropertyName("unique_code")]
        public string UniqueCode { get; set; }
        public partial class ItemsModel
        {

            /// <summary>
            /// 原网点编码
            /// </summary>
            [JsonPropertyName("from_branch_code")]
            public string FromBranchCode { get; set; }

            /// <summary>
            /// 原网点名称
            /// </summary>
            [JsonPropertyName("from_branch_name")]
            public string FromBranchName { get; set; }

            /// <summary>
            /// 原三段码
            /// </summary>
            [JsonPropertyName("from_third_seg")]
            public string FromThirdSeg { get; set; }

            /// <summary>
            /// 批次中的唯一键
            /// </summary>
            [JsonPropertyName("object_id")]
            public long ObjectId { get; set; }

            /// <summary>
            /// 操作人不能为空
            /// </summary>
            [JsonPropertyName("operator")]
            public string Operator { get; set; }

            /// <summary>
            /// 拆分映射类型，0三段码维度，1网点维度
            /// </summary>
            [JsonPropertyName("split_type")]
            public int SplitType { get; set; }

            /// <summary>
            /// 数据编辑时间
            /// </summary>
            [JsonPropertyName("timestamp")]
            public long Timestamp { get; set; }

            /// <summary>
            /// 新网点编码
            /// </summary>
            [JsonPropertyName("to_branch_code")]
            public string ToBranchCode { get; set; }

            /// <summary>
            /// 新网点名称
            /// </summary>
            [JsonPropertyName("to_branch_name")]
            public string ToBranchName { get; set; }

            /// <summary>
            /// 新三段码
            /// </summary>
            [JsonPropertyName("to_third_seg")]
            public string ToThirdSeg { get; set; }

            /// <summary>
            /// 快递商编码
            /// </summary>
            [JsonPropertyName("wp_code")]
            public string WpCode { get; set; }

        }

    }

}

