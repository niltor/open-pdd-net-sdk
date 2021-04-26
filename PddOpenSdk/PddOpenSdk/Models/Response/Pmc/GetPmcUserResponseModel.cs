using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Pmc
{
    public partial class GetPmcUserResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pmc_user_get_response")]
        public PmcUserGetResponseResponseModel PmcUserGetResponse { get; set; }
        public partial class PmcUserGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 开通的用户数据
            /// </summary>
            [JsonProperty("pmc_user")]
            public PmcUserResponseModel PmcUser { get; set; }
            public partial class PmcUserResponseModel : PddResponseModel
            {
                /// <summary>
                /// 用户首次开通时间
                /// </summary>
                [JsonProperty("created")]
                public string Created { get; set; }
                /// <summary>
                /// 用户授权是否有效，0表示授权有效，1表示授权过期
                /// </summary>
                [JsonProperty("is_expire")]
                public int? IsExpire { get; set; }
                /// <summary>
                /// 用户最后开通时间
                /// </summary>
                [JsonProperty("modified")]
                public string Modified { get; set; }
                /// <summary>
                /// 用户ID
                /// </summary>
                [JsonProperty("owner_id")]
                public string OwnerId { get; set; }
                /// <summary>
                /// 用户开通的消息类型列表。如果为空表示应用开通的所有类型
                /// </summary>
                [JsonProperty("topics")]
                public List<string> Topics { get; set; }

            }

        }

    }

}
