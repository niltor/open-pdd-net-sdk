using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Util
{
    public partial class CreatePopAuthTokenRequestModel : PddRequestModel
    {
        /// <summary>
        /// 授权code，grantType==authorization_code 时需要
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

    }

}
