using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Pmcuser
{
    public partial class CancelPmcUserRequestModel : PddRequestModel
    {
        /// <summary>
        /// 用户唯一id
        /// </summary>
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

    }

}
