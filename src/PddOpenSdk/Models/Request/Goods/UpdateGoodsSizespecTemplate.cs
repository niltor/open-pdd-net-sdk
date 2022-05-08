namespace PddOpenSdk.Models.Request.Goods;
public partial class UpdateGoodsSizespecTemplate
{

    /// <summary>
    /// 尺码表
    /// </summary>
    [JsonPropertyName("size_spec_dto")]
    public SizeSpecDtoModel SizeSpecDto { get; set; }
    public partial class SizeSpecDtoModel
    {

        /// <summary>
        /// 尺码表分类id，pdd.goods.sizespec.class.get得到
        /// </summary>
        [JsonPropertyName("class_id")]
        public int ClassId { get; set; }

        /// <summary>
        /// 尺码表内容
        /// </summary>
        [JsonPropertyName("content")]
        public ContentModel Content { get; set; }

        /// <summary>
        /// 尺码表id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 尺码表名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        public partial class ContentModel
        {

            /// <summary>
            /// 尺码表元数据（表头），pdd.goods.sizespec.meta.get得到
            /// </summary>
            [JsonPropertyName("meta")]
            public MetaModel Meta { get; set; }

            /// <summary>
            /// 尺码表行数据
            /// </summary>
            [JsonPropertyName("records")]
            public List<RecordsModel> Records { get; set; }
            public partial class MetaModel
            {

                /// <summary>
                /// 尺码元素
                /// </summary>
                [JsonPropertyName("elements")]
                public List<ElementsModel> Elements { get; set; }

                /// <summary>
                /// 尺码组
                /// </summary>
                [JsonPropertyName("groups")]
                public List<GroupsModel> Groups { get; set; }
                public partial class ElementsModel
                {

                    /// <summary>
                    /// 尺码元数据id
                    /// </summary>
                    [JsonPropertyName("id")]
                    public int Id { get; set; }

                    /// <summary>
                    /// 尺码元数据名称
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                }
                public partial class GroupsModel
                {

                    /// <summary>
                    /// 尺码元数据id
                    /// </summary>
                    [JsonPropertyName("id")]
                    public int Id { get; set; }

                    /// <summary>
                    /// 尺码元数据名称
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                }

            }
            public partial class RecordsModel
            {

                /// <summary>
                /// 尺码组和尺码表元素的值
                /// </summary>
                [JsonPropertyName("values")]
                public Dictionary<string, object> Values { get; set; }
                public partial class ValuesModel
                {

                    /// <summary>
                    /// 尺码组和尺码表元素的id
                    /// </summary>
                    [JsonPropertyName("$key")]
                    public int Key { get; set; }

                    /// <summary>
                    /// 尺码组和尺码表元素的值
                    /// </summary>
                    [JsonPropertyName("$value")]
                    public string Value { get; set; }

                }

            }

        }

    }

}

