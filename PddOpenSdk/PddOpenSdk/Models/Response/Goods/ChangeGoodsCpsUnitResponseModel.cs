using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class ChangeGoodsCpsUnitResponseModel
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_change_success")]
        public bool IsChangeSuccess { get; set; }
    }


}
