namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsSizespecTemplateResponse : PddResponseModel
{

    /// <summary>
    /// 响应
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 请求成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 尺码表分类id
            /// </summary>
            [JsonPropertyName("class_id")]
            public long? ClassId { get; set; }

            /// <summary>
            /// 尺码表内容
            /// </summary>
            [JsonPropertyName("content")]
            public ContentResponse Content { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [JsonPropertyName("create_at")]
            public long? CreateAt { get; set; }

            /// <summary>
            /// 扩展类型
            /// </summary>
            [JsonPropertyName("extend_type")]
            public int? ExtendType { get; set; }

            /// <summary>
            /// 尺码表id
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 是否尺码表分类默认
            /// </summary>
            [JsonPropertyName("is_default")]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// 尺码表属于的店铺
            /// </summary>
            [JsonPropertyName("mall_id")]
            public long? MallId { get; set; }

            /// <summary>
            /// 尺码表名称
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; }

            /// <summary>
            /// 是否可复用
            /// </summary>
            [JsonPropertyName("reusable")]
            public bool? Reusable { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [JsonPropertyName("update_at")]
            public long? UpdateAt { get; set; }

            /// <summary>
            /// 使用的商品数
            /// </summary>
            [JsonPropertyName("used")]
            public long? Used { get; set; }
            public partial class ContentResponse : PddResponseModel
            {

                /// <summary>
                /// 尺码表元数据（表头）
                /// </summary>
                [JsonPropertyName("meta")]
                public MetaResponse Meta { get; set; }

                /// <summary>
                /// 尺码表图片
                /// </summary>
                [JsonPropertyName("pic_url")]
                public string PicUrl { get; set; }

                /// <summary>
                /// 尺码表行数据
                /// </summary>
                [JsonPropertyName("records")]
                public List<RecordsResponse> Records { get; set; }
                public partial class MetaResponse : PddResponseModel
                {

                    /// <summary>
                    /// 可批量的尺码元素id
                    /// </summary>
                    [JsonPropertyName("batchable_element_ids")]
                    public List<int?> BatchableElementIds { get; set; }

                    /// <summary>
                    /// 尺码元素
                    /// </summary>
                    [JsonPropertyName("elements")]
                    public List<ElementsResponse> Elements { get; set; }

                    /// <summary>
                    /// 尺码组
                    /// </summary>
                    [JsonPropertyName("groups")]
                    public List<GroupsResponse> Groups { get; set; }
                    public partial class ElementsResponse : PddResponseModel
                    {

                        /// <summary>
                        /// 尺码元数据id
                        /// </summary>
                        [JsonPropertyName("id")]
                        public int? Id { get; set; }

                        /// <summary>
                        /// 尺码元数据名称
                        /// </summary>
                        [JsonPropertyName("name")]
                        public string Name { get; set; }

                    }
                    public partial class GroupsResponse : PddResponseModel
                    {

                        /// <summary>
                        /// 尺码元数据id
                        /// </summary>
                        [JsonPropertyName("id")]
                        public int? Id { get; set; }

                        /// <summary>
                        /// 尺码元数据名称
                        /// </summary>
                        [JsonPropertyName("name")]
                        public string Name { get; set; }

                    }

                }
                public partial class RecordsResponse : PddResponseModel
                {

                    /// <summary>
                    /// 尺码组和尺码表元素的值
                    /// </summary>
                    [JsonPropertyName("values")]
                    public Dictionary<string, object> Values { get; set; }
                    public partial class ValuesResponse : PddResponseModel
                    {

                        /// <summary>
                        /// 尺码组和尺码表元素的id
                        /// </summary>
                        [JsonPropertyName("$key")]
                        public int? Key { get; set; }

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

}

