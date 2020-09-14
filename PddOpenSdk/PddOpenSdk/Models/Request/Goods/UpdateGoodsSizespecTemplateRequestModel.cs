using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class UpdateGoodsSizespecTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 尺码表
        /// </summary>
        [JsonProperty("size_spec_dto")]
        public SizeSpecDtoRequestModel SizeSpecDto { get; set; }
        public partial class SizeSpecDtoRequestModel : PddRequestModel
        {
            /// <summary>
            /// 尺码表分类id，pdd.goods.sizespec.class.get得到
            /// </summary>
            [JsonProperty("class_id")]
            public int ClassId { get; set; }
            /// <summary>
            /// 尺码表内容
            /// </summary>
            [JsonProperty("content")]
            public ContentRequestModel Content { get; set; }
            /// <summary>
            /// 尺码表id
            /// </summary>
            [JsonProperty("id")]
            public long Id { get; set; }
            /// <summary>
            /// 尺码表名称
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }
            public partial class ContentRequestModel : PddRequestModel
            {
                /// <summary>
                /// 尺码表元数据（表头），pdd.goods.sizespec.meta.get得到
                /// </summary>
                [JsonProperty("meta")]
                public MetaRequestModel Meta { get; set; }
                /// <summary>
                /// 尺码表行数据
                /// </summary>
                [JsonProperty("records")]
                public List<RecordsRequestModel> Records { get; set; }
                public partial class MetaRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 尺码元素
                    /// </summary>
                    [JsonProperty("elements")]
                    public List<ElementsRequestModel> Elements { get; set; }
                    /// <summary>
                    /// 尺码组
                    /// </summary>
                    [JsonProperty("groups")]
                    public List<GroupsRequestModel> Groups { get; set; }
                    public partial class ElementsRequestModel : PddRequestModel
                    {
                        /// <summary>
                        /// 尺码元数据id
                        /// </summary>
                        [JsonProperty("id")]
                        public int Id { get; set; }
                        /// <summary>
                        /// 尺码元数据名称
                        /// </summary>
                        [JsonProperty("name")]
                        public string Name { get; set; }

                    }
                    public partial class GroupsRequestModel : PddRequestModel
                    {
                        /// <summary>
                        /// 尺码元数据id
                        /// </summary>
                        [JsonProperty("id")]
                        public int Id { get; set; }
                        /// <summary>
                        /// 尺码元数据名称
                        /// </summary>
                        [JsonProperty("name")]
                        public string Name { get; set; }

                    }

                }
                public partial class RecordsRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 尺码组和尺码表元素的值
                    /// </summary>
                    [JsonProperty("values")]
                    public Dictionary<string, object> Values { get; set; }
                    public partial class ValuesRequestModel : PddRequestModel
                    {
                        /// <summary>
                        /// 尺码组和尺码表元素的id
                        /// </summary>
                        [JsonProperty("$key")]
                        public int Key { get; set; }
                        /// <summary>
                        /// 尺码组和尺码表元素的值
                        /// </summary>
                        [JsonProperty("$value")]
                        public string Value { get; set; }

                    }

                }

            }

        }

    }

}
