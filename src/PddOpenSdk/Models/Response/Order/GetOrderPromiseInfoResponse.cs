namespace PddOpenSdk.Models.Response.Order;
public partial class GetOrderPromiseInfoResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("promise_info_get_response")]
    public PromiseInfoGetResponseResponse PromiseInfoGetResponse { get; set; }
    public partial class PromiseInfoGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("promise_info")]
        public PromiseInfoResponse PromiseInfo { get; set; }
        public partial class PromiseInfoResponse : PddResponseModel
        {

            /// <summary>
            /// 承诺详情
            /// </summary>
            [JsonPropertyName("detail_info")]
            public Dictionary<string, object> DetailInfo { get; set; }

            /// <summary>
            /// 额外信息
            /// </summary>
            [JsonPropertyName("extra_info")]
            public Dictionary<string, object> ExtraInfo { get; set; }

            /// <summary>
            /// 是否已删除
            /// </summary>
            [JsonPropertyName("is_deleted")]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// 订单号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 服务承诺描述
            /// </summary>
            [JsonPropertyName("promise_desc")]
            public string PromiseDesc { get; set; }

            /// <summary>
            /// 服务承诺单性质，1-平台协议，2-客服承 诺，3-平台建议
            /// </summary>
            [JsonPropertyName("promise_level")]
            public int? PromiseLevel { get; set; }

            /// <summary>
            /// 服务承诺状态，0-已创建，1-履约中，2-履 约未达成，3-履约成功
            /// </summary>
            [JsonPropertyName("promise_status")]
            public int? PromiseStatus { get; set; }

            /// <summary>
            /// 服务承诺类型，1-指定快递/物流，2-优先发 货
            /// </summary>
            [JsonPropertyName("promise_type")]
            public int? PromiseType { get; set; }

            /// <summary>
            /// 承诺信息id
            /// </summary>
            [JsonPropertyName("promise_id")]
            public long? PromiseId { get; set; }

            /// <summary>
            /// 业务场景，1-发货场景
            /// </summary>
            [JsonPropertyName("scene_type")]
            public int? SceneType { get; set; }

            /// <summary>
            /// 最后更新时间
            /// </summary>
            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }
            public partial class DetailInfoResponse : PddResponseModel
            {

                /// <summary>
                /// key 详情请参阅接口文档
                /// </summary>
                [JsonPropertyName("$key")]
                public string Key { get; set; }

                /// <summary>
                /// value 详情请参阅接口文档
                /// </summary>
                [JsonPropertyName("$value")]
                public string Value { get; set; }

            }
            public partial class ExtraInfoResponse : PddResponseModel
            {

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("$key")]
                public string Key { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("$value")]
                public string Value { get; set; }

            }

        }

    }

}

