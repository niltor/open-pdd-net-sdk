namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsSizespecMetaResponse : PddResponseModel
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
        /// 错误消息
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

    }

}

