namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsCatsResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_cats_get_response")]
    public GoodsCatsGetResponseResponse GoodsCatsGetResponse { get; set; }
    public partial class GoodsCatsGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 类目树对象
        /// </summary>
        [JsonPropertyName("goods_cats_list")]
        public List<GoodsCatsListResponse> GoodsCatsList { get; set; }
        public partial class GoodsCatsListResponse : PddResponseModel
        {

            /// <summary>
            /// 商品类目ID
            /// </summary>
            [JsonPropertyName("cat_id")]
            public long? CatId { get; set; }

            /// <summary>
            /// 商品类目名称
            /// </summary>
            [JsonPropertyName("cat_name")]
            public string CatName { get; set; }

            /// <summary>
            /// 类目层级，1-一级类目，2-二级类目，3-三级类目，4-四级类目
            /// </summary>
            [JsonPropertyName("level")]
            public int? Level { get; set; }

            /// <summary>
            /// id所属父类目ID，其中，parent_id=0时为顶级节点
            /// </summary>
            [JsonPropertyName("parent_cat_id")]
            public long? ParentCatId { get; set; }

        }

    }

}

