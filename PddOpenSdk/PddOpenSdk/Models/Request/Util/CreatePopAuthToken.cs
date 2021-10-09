namespace PddOpenSdk.Models.Request.Util;
public partial class CreatePopAuthToken
{

    /// <summary>
    /// 授权code，grantType==authorization_code 时需要
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }

}

