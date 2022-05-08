namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsOuterCatMappingResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("outer_cat_mapping_get_response")]
    public OuterCatMappingGetResponseResponse OuterCatMappingGetResponse { get; set; }
    public partial class OuterCatMappingGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 一级类目
        /// </summary>
        [JsonPropertyName("cat_id1")]
        public long? CatId1 { get; set; }

        /// <summary>
        /// 二级类目
        /// </summary>
        [JsonPropertyName("cat_id2")]
        public long? CatId2 { get; set; }

        /// <summary>
        /// 三级类目
        /// </summary>
        [JsonPropertyName("cat_id3")]
        public long? CatId3 { get; set; }

        /// <summary>
        /// 四级类目
        /// </summary>
        [JsonPropertyName("cat_id4")]
        public long? CatId4 { get; set; }

    }

}

