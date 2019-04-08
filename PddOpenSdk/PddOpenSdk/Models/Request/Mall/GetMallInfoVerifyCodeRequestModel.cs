using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Mall
{
    public partial class GetMallInfoVerifyCodeRequestModel : PddRequestModel {
        /// <summary>
        /// 第三方软件账号id
        /// </summary>
        [JsonProperty ("user_id")]
        public string UserId { get; set; }
        /// <summary>
        /// 店主名称
        /// </summary>
        [JsonProperty ("ww_name")]
        public string WwName { get; set; }

    }

}