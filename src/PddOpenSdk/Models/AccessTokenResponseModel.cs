
namespace PddOpenSdk.Models;

public class AccessTokenResponseModel
{
    [JsonPropertyName("scope")]
    public string[] Scope { get; set; }
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }
    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; }
    [JsonPropertyName("owner_id")]
    public string OwnerId { get; set; }
    [JsonPropertyName("owner_name")]
    public string OwnerName { get; set; }
}
