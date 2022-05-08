namespace PddOpenSdk.Models.Response.Pmc;
public partial class GetPmcUserResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pmc_user_get_response")]
    public PmcUserGetResponseResponse PmcUserGetResponse { get; set; }
    public partial class PmcUserGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 开通的用户数据
        /// </summary>
        [JsonPropertyName("pmc_user")]
        public PmcUserResponse PmcUser { get; set; }
        public partial class PmcUserResponse : PddResponseModel
        {

            /// <summary>
            /// 用户首次开通时间
            /// </summary>
            [JsonPropertyName("created")]
            public string Created { get; set; }

            /// <summary>
            /// 用户授权是否有效，0表示授权有效，1表示授权过期
            /// </summary>
            [JsonPropertyName("is_expire")]
            public int? IsExpire { get; set; }

            /// <summary>
            /// 用户最后开通时间
            /// </summary>
            [JsonPropertyName("modified")]
            public string Modified { get; set; }

            /// <summary>
            /// 用户ID
            /// </summary>
            [JsonPropertyName("owner_id")]
            public string OwnerId { get; set; }

            /// <summary>
            /// 用户开通的消息类型列表。如果为空表示应用开通的所有类型
            /// </summary>
            [JsonPropertyName("topics")]
            public List<string> Topics { get; set; }

        }

    }

}

