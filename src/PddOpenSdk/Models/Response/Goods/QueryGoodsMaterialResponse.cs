namespace PddOpenSdk.Models.Response.Goods;
public partial class QueryGoodsMaterialResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("material_list")]
    public List<MaterialListResponse> MaterialList { get; set; }
    public partial class MaterialListResponse : PddResponseModel
    {

        /// <summary>
        /// 申诉审核信息
        /// </summary>
        [JsonPropertyName("appeal_check_comment")]
        public string AppealCheckComment { get; set; }

        /// <summary>
        /// 审核信息
        /// </summary>
        [JsonPropertyName("check_comment")]
        public string CheckComment { get; set; }

        /// <summary>
        /// 审核状态（1：待审核；2：通过；3：驳回；101：申诉待审核；102：申诉通过；103：申诉驳回）
        /// </summary>
        [JsonPropertyName("check_status")]
        public int? CheckStatus { get; set; }

        /// <summary>
        /// 素材内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 素材id
        /// </summary>
        [JsonPropertyName("material_id")]
        public long? MaterialId { get; set; }

        /// <summary>
        /// 线上素材
        /// </summary>
        [JsonPropertyName("online_material")]
        public string OnlineMaterial { get; set; }

        /// <summary>
        /// 素材类型（1：白底图；3：长图）
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

    }

}

