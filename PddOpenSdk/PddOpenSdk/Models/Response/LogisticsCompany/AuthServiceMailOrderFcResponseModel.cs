using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.LogisticsCompany
{
    public partial class AuthServiceMailOrderFcResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("expires_in")]
        public int? ExpiresIn { get; set; }

    }

}
