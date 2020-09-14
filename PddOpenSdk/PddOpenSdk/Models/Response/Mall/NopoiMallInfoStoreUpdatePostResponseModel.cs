using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class NopoiMallInfoStoreUpdatePostResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res")]
        public string Res { get; set; }

    }

}
