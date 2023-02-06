namespace PddOpenSdk.Models.Response.Goods;
public partial class RelationGoodsGetResponse : PddResponseModel
{

    /// <summary>
    /// 映射关系查询返回对象列表
    /// </summary>
    [JsonPropertyName("query_goods_relation_response")]
    public List<QueryGoodsRelationResponseResponse> QueryGoodsRelationResponse { get; set; }
    public partial class QueryGoodsRelationResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 外部平台商品id
        /// </summary>
        [JsonPropertyName("out_goods_id")]
        public string OutGoodsId { get; set; }

        /// <summary>
        /// 拼多多商品id
        /// </summary>
        [JsonPropertyName("pdd_goods_id")]
        public long? PddGoodsId { get; set; }

    }

}

