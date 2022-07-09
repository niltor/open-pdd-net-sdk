namespace PddOpenSdk.Models.Response.Util;
public partial class GetPopMallBindTokenResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("pop_auth_token_create_response")]
    public PopAuthTokenCreateResponseResponse PopAuthTokenCreateResponse { get; set; }
    public partial class PopAuthTokenCreateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// access_token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// access_token过期时间点
        /// </summary>
        [JsonPropertyName("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// access_token过期时间段，10（表示10秒后过期）
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 商家店铺id
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 商家账号名称
        /// </summary>
        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// r1级别API或字段的访问过期时间点
        /// </summary>
        [JsonPropertyName("r1_expires_at")]
        public long? R1ExpiresAt { get; set; }

        /// <summary>
        /// r1级别API或字段的访问过期时间；	 10（表示10秒后过期）
        /// </summary>
        [JsonPropertyName("r1_expires_in")]
        public int? R1ExpiresIn { get; set; }

        /// <summary>
        /// r2级别API或字段的访问过期时间点
        /// </summary>
        [JsonPropertyName("r2_expires_at")]
        public long? R2ExpiresAt { get; set; }

        /// <summary>
        /// r2级别API或字段的访问过期时间；10（表示10秒后过期）
        /// </summary>
        [JsonPropertyName("r2_expires_in")]
        public int? R2ExpiresIn { get; set; }

        /// <summary>
        /// refresh token，可用来刷新access_token
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Refresh token过期时间点
        /// </summary>
        [JsonPropertyName("refresh_token_expires_at")]
        public long? RefreshTokenExpiresAt { get; set; }

        /// <summary>
        /// refresh_token过期时间段，10表示10秒后过期
        /// </summary>
        [JsonPropertyName("refresh_token_expires_in")]
        public int? RefreshTokenExpiresIn { get; set; }

        /// <summary>
        /// 接口列表
        /// </summary>
        [JsonPropertyName("scope")]
        public List<string> Scope { get; set; }

        /// <summary>
        /// w1级别API或字段的访问过期时间点
        /// </summary>
        [JsonPropertyName("w1_expires_at")]
        public long? W1ExpiresAt { get; set; }

        /// <summary>
        /// w1级别API或字段的访问过期时间；	 10（表示10秒后过期）
        /// </summary>
        [JsonPropertyName("w1_expires_in")]
        public int? W1ExpiresIn { get; set; }

        /// <summary>
        /// w2级别API或字段的访问过期时间点
        /// </summary>
        [JsonPropertyName("w2_expires_at")]
        public long? W2ExpiresAt { get; set; }

        /// <summary>
        /// w2级别API或字段的访问过期时间；10（表示10秒后过期）
        /// </summary>
        [JsonPropertyName("w2_expires_in")]
        public int? W2ExpiresIn { get; set; }

    }

}

