using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Util
{
    public partial class CreatePopAuthTokenResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pop_auth_token_create_response")]
        public PopAuthTokenCreateResponseResponseModel PopAuthTokenCreateResponse { get; set; }
        public partial class PopAuthTokenCreateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// access_token
            /// </summary>
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }
            /// <summary>
            /// access_token过期时间点
            /// </summary>
            [JsonProperty("expires_at")]
            public long? ExpiresAt { get; set; }
            /// <summary>
            /// access_token过期时间段，10（表示10秒后过期）
            /// </summary>
            [JsonProperty("expires_in")]
            public int? ExpiresIn { get; set; }
            /// <summary>
            /// 商家店铺id
            /// </summary>
            [JsonProperty("owner_id")]
            public string OwnerId { get; set; }
            /// <summary>
            /// 商家账号名称
            /// </summary>
            [JsonProperty("owner_name")]
            public string OwnerName { get; set; }
            /// <summary>
            /// r1级别API或字段的访问过期时间点
            /// </summary>
            [JsonProperty("r1_expires_at")]
            public long? R1ExpiresAt { get; set; }
            /// <summary>
            /// r1级别API或字段的访问过期时间；	 10（表示10秒后过期）
            /// </summary>
            [JsonProperty("r1_expires_in")]
            public int? R1ExpiresIn { get; set; }
            /// <summary>
            /// r2级别API或字段的访问过期时间点
            /// </summary>
            [JsonProperty("r2_expires_at")]
            public long? R2ExpiresAt { get; set; }
            /// <summary>
            /// r2级别API或字段的访问过期时间；10（表示10秒后过期）
            /// </summary>
            [JsonProperty("r2_expires_in")]
            public int? R2ExpiresIn { get; set; }
            /// <summary>
            /// refresh token，可用来刷新access_token
            /// </summary>
            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }
            /// <summary>
            /// Refresh token过期时间点
            /// </summary>
            [JsonProperty("refresh_token_expires_at")]
            public long? RefreshTokenExpiresAt { get; set; }
            /// <summary>
            /// refresh_token过期时间段，10表示10秒后过期
            /// </summary>
            [JsonProperty("refresh_token_expires_in")]
            public int? RefreshTokenExpiresIn { get; set; }
            /// <summary>
            /// 接口列表
            /// </summary>
            [JsonProperty("scope")]
            public List<string> Scope { get; set; }
            /// <summary>
            /// w1级别API或字段的访问过期时间点
            /// </summary>
            [JsonProperty("w1_expires_at")]
            public long? W1ExpiresAt { get; set; }
            /// <summary>
            /// w1级别API或字段的访问过期时间；	 10（表示10秒后过期）
            /// </summary>
            [JsonProperty("w1_expires_in")]
            public int? W1ExpiresIn { get; set; }
            /// <summary>
            /// w2级别API或字段的访问过期时间点
            /// </summary>
            [JsonProperty("w2_expires_at")]
            public long? W2ExpiresAt { get; set; }
            /// <summary>
            /// w2级别API或字段的访问过期时间；10（表示10秒后过期）
            /// </summary>
            [JsonProperty("w2_expires_in")]
            public int? W2ExpiresIn { get; set; }

        }

    }

}
