namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsSpecResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_spec_get_response")]
    public GoodsSpecGetResponseResponse GoodsSpecGetResponse { get; set; }
    public partial class GoodsSpecGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 规格列表对象
        /// </summary>
        [JsonPropertyName("goods_spec_list")]
        public List<GoodsSpecListResponse> GoodsSpecList { get; set; }
        public partial class GoodsSpecListResponse : PddResponseModel
        {

            /// <summary>
            /// 规格所属的叶子类目ID
            /// </summary>
            [JsonPropertyName("cat_id")]
            public long? CatId { get; set; }

            /// <summary>
            /// 商品规格对应的ID
            /// </summary>
            [JsonPropertyName("parent_spec_id")]
            public long? ParentSpecId { get; set; }

            /// <summary>
            /// 商品规格ID对应的规格名称
            /// </summary>
            [JsonPropertyName("parent_spec_name")]
            public string ParentSpecName { get; set; }

        }

    }

}

