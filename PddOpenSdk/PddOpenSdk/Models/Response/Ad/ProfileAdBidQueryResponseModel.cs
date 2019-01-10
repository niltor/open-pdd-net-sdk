using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ProfileAdBidQueryResponseModel : PddResponseModel
    {
        /// <summary>
        /// 开平返回
        /// </summary>
        [JsonProperty("open_api_response")]
        public List<OpenApiResponseResponseModel> OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 兴趣点信息
            /// </summary>
            [JsonProperty("features")]
            public List<FeaturesResponseModel> Features { get; set; }
            /// <summary>
            /// 用户数量
            /// </summary>
            [JsonProperty("uv")]
            public long? Uv { get; set; }
            /// <summary>
            /// 定向类型， 2：访客重定向 3：相似商品定向 4：叶子类目定向 5：相似店铺定向 6：近期对我的商品相关属性感兴趣的用户
            /// </summary>
            [JsonProperty("target_type")]
            public int? TargetType { get; set; }
            public partial class FeaturesResponseModel : PddResponseModel
            {
                /// <summary>
                /// 用户数量
                /// </summary>
                [JsonProperty("uv")]
                public long? Uv { get; set; }
                /// <summary>
                /// 兴趣点名称
                /// </summary>
                [JsonProperty("sub_level_target_name")]
                public string SubLevelTargetName { get; set; }
                /// <summary>
                /// 兴趣点ID
                /// </summary>
                [JsonProperty("sub_level_target_id")]
                public long? SubLevelTargetId { get; set; }

            }

        }

    }

}
