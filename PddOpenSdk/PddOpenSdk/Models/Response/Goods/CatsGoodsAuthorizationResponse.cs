namespace PddOpenSdk.Models.Response.Goods;
public partial class CatsGoodsAuthorizationResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_auth_cats_get_response")]
    public GoodsAuthCatsGetResponseResponse GoodsAuthCatsGetResponse { get; set; }
    public partial class GoodsAuthCatsGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 类目对象列表
        /// </summary>
        [JsonPropertyName("goods_cats_list")]
        public List<GoodsCatsListResponse> GoodsCatsList { get; set; }
        public partial class GoodsCatsListResponse : PddResponseModel
        {

            /// <summary>
            /// 类目ID，一级类目ID
            /// </summary>
            [JsonPropertyName("cat_id")]
            public long? CatId { get; set; }

            /// <summary>
            /// 对应ID下的类目名称
            /// </summary>
            [JsonPropertyName("cat_name")]
            public string CatName { get; set; }

            /// <summary>
            /// 是否为叶子类目
            /// </summary>
            [JsonPropertyName("leaf")]
            public bool? Leaf { get; set; }

        }

    }

}

