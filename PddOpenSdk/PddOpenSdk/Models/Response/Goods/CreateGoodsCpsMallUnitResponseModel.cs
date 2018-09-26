using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class CreateGoodsCpsMallUnitResponseModel
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_create_success")]
        public bool IsCreateSuccess { get; set; }
    }


}
