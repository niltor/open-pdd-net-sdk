namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsOptResponse : PddResponseModel
{

    /// <summary>
    /// 返回response
    /// </summary>
    [JsonPropertyName("goods_opt_get_response")]
    public GoodsOptGetResponseResponse GoodsOptGetResponse { get; set; }
    public partial class GoodsOptGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// opt列表
        /// </summary>
        [JsonPropertyName("goods_opt_list")]
        public List<GoodsOptListResponse> GoodsOptList { get; set; }
        public partial class GoodsOptListResponse : PddResponseModel
        {

            /// <summary>
            /// 层级，1-一级，2-二级，3-三级，4-四级
            /// </summary>
            [JsonPropertyName("level")]
            public int? Level { get; set; }

            /// <summary>
            /// 商品标签ID
            /// </summary>
            [JsonPropertyName("opt_id")]
            public long? OptId { get; set; }

            /// <summary>
            /// 商品标签名
            /// </summary>
            [JsonPropertyName("opt_name")]
            public string OptName { get; set; }

            /// <summary>
            /// id所属父ID，其中，parent_id=0时为顶级节点
            /// </summary>
            [JsonPropertyName("parent_opt_id")]
            public long? ParentOptId { get; set; }

        }

    }

}

