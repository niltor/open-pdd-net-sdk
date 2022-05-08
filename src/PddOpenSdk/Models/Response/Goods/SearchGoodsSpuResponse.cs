namespace PddOpenSdk.Models.Response.Goods;
public partial class SearchGoodsSpuResponse : PddResponseModel
{

    /// <summary>
    /// 标品搜索查询结果
    /// </summary>
    [JsonPropertyName("spu_search_response")]
    public SpuSearchResponseResponse SpuSearchResponse { get; set; }
    public partial class SpuSearchResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 标品列表
        /// </summary>
        [JsonPropertyName("spu_list")]
        public List<SpuListResponse> SpuList { get; set; }
        public partial class SpuListResponse : PddResponseModel
        {

            /// <summary>
            /// 标品所在的类目ID。若非叶子类目，表示该标品可用于该类目下的任何叶子类目。
            /// </summary>
            [JsonPropertyName("cat_id")]
            public long? CatId { get; set; }

            /// <summary>
            /// 关键属性
            /// </summary>
            [JsonPropertyName("key_prop")]
            public List<KeyPropResponse> KeyProp { get; set; }

            /// <summary>
            /// 标品标题
            /// </summary>
            [JsonPropertyName("spu_name")]
            public string SpuName { get; set; }
            public partial class KeyPropResponse : PddResponseModel
            {

                /// <summary>
                /// 引用属性ID
                /// </summary>
                [JsonPropertyName("ref_pid")]
                public long? RefPid { get; set; }

                /// <summary>
                /// 属性值
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; }

                /// <summary>
                /// 属性值单位
                /// </summary>
                [JsonPropertyName("value_unit")]
                public string ValueUnit { get; set; }

                /// <summary>
                /// 属性值ID
                /// </summary>
                [JsonPropertyName("vid")]
                public long? Vid { get; set; }

            }

        }

    }

}

