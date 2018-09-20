using Newtonsoft.Json;

namespace PddOpenSdk.Models
{
    class AccessTokenResponseModel
    {
        [JsonProperty("scope")]
        public string[] Scope { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }
        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }
    }
}
