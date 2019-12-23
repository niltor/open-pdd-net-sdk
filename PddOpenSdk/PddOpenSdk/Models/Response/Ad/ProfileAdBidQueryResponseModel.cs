using System.Collections.Generic;
using Newtonsoft.Json;
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
            /// 定向类型。1表示通投，2表示访客重定向，3表示相似商品定向，4表示叶子类目定向，5表示相似店铺定向，6表示兴趣点定向，7表示人群包定向，8表示地域定向人群，9表示商品高潜人群，10表示高品质商品偏好人群，11表示大促偏好人群，12表示爱分享人群
            /// </summary>
            [JsonProperty("target_type")]
            public int? TargetType { get; set; }
            public partial class FeaturesResponseModel : PddResponseModel
            {
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
