namespace PddOpenSdk.Models.Request.Util;
public partial class RefreshPopAuthToken
{

    /// <summary>
    /// grantType==refresh_token 时需要
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; }

}

