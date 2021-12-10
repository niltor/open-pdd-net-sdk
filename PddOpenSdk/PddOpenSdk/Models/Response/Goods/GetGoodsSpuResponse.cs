namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsSpuResponse : PddResponseModel
{

    /// <summary>
    /// 标品详情查询结果
    /// </summary>
    [JsonPropertyName("spu_get_response")]
    public SpuGetResponseResponse SpuGetResponse { get; set; }
    public partial class SpuGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 绑定属性，商品属性中对应的引用属性的属性值需要和绑定属性值相同。
        /// </summary>
        [JsonPropertyName("bind_prop")]
        public List<BindPropResponse> BindProp { get; set; }

        /// <summary>
        /// 商品轮播图
        /// </summary>
        [JsonPropertyName("carousel_gallery")]
        public List<string> CarouselGallery { get; set; }

        /// <summary>
        /// 标品所在的类目ID。若非叶子类目，表示该标品可用于该类目下的任何叶子类目。
        /// </summary>
        [JsonPropertyName("cat_id")]
        public long? CatId { get; set; }

        /// <summary>
        /// 商品详情图
        /// </summary>
        [JsonPropertyName("detail_gallery")]
        public List<string> DetailGallery { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 关键属性
        /// </summary>
        [JsonPropertyName("key_prop")]
        public List<KeyPropResponse> KeyProp { get; set; }

        /// <summary>
        /// 商品前缀标题，若有返回值，则表示发布该标品对应的商品时，商品标题的开头需要包含这部分字符串。
        /// </summary>
        [JsonPropertyName("pre_title")]
        public string PreTitle { get; set; }

        /// <summary>
        /// 销售属性，商品属性中对应的引用属性的属性值需要是销售属性值的子集。
        /// </summary>
        [JsonPropertyName("sale_prop")]
        public List<SalePropResponse> SaleProp { get; set; }

        /// <summary>
        /// 标品标题
        /// </summary>
        [JsonPropertyName("spu_name")]
        public string SpuName { get; set; }
        public partial class BindPropResponse : PddResponseModel
        {

            /// <summary>
            /// 属性名
            /// </summary>
            [JsonPropertyName("pname")]
            public string Pname { get; set; }

            /// <summary>
            /// 引用属性ID
            /// </summary>
            [JsonPropertyName("ref_pid")]
            public long? RefPid { get; set; }

            /// <summary>
            /// 属性值单位
            /// </summary>
            [JsonPropertyName("value_unit")]
            public string ValueUnit { get; set; }

            /// <summary>
            /// 属性值
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; }

            /// <summary>
            /// 属性值ID
            /// </summary>
            [JsonPropertyName("vid")]
            public long? Vid { get; set; }

        }
        public partial class KeyPropResponse : PddResponseModel
        {

            /// <summary>
            /// 属性名
            /// </summary>
            [JsonPropertyName("pname")]
            public string Pname { get; set; }

            /// <summary>
            /// 引用属性id
            /// </summary>
            [JsonPropertyName("ref_pid")]
            public long? RefPid { get; set; }

            /// <summary>
            /// 属性值单位
            /// </summary>
            [JsonPropertyName("value_unit")]
            public string ValueUnit { get; set; }

            /// <summary>
            /// 属性值
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; }

            /// <summary>
            /// 属性值ID
            /// </summary>
            [JsonPropertyName("vid")]
            public long? Vid { get; set; }

        }
        public partial class SalePropResponse : PddResponseModel
        {

            /// <summary>
            /// 组ID
            /// </summary>
            [JsonPropertyName("group_id")]
            public int? GroupId { get; set; }

            /// <summary>
            /// 父规格ID
            /// </summary>
            [JsonPropertyName("parent_spec_id")]
            public long? ParentSpecId { get; set; }

            /// <summary>
            /// 属性名
            /// </summary>
            [JsonPropertyName("pname")]
            public string Pname { get; set; }

            /// <summary>
            /// 引用属性ID
            /// </summary>
            [JsonPropertyName("ref_pid")]
            public long? RefPid { get; set; }

            /// <summary>
            /// 规格ID
            /// </summary>
            [JsonPropertyName("spec_id")]
            public long? SpecId { get; set; }

            /// <summary>
            /// 属性值单位
            /// </summary>
            [JsonPropertyName("value_unit")]
            public string ValueUnit { get; set; }

            /// <summary>
            /// 属性值
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; }

            /// <summary>
            /// 属性值ID
            /// </summary>
            [JsonPropertyName("vid")]
            public long? Vid { get; set; }

        }

    }

}

