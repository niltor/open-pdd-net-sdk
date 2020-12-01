using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.ServiceMarket
{
    public partial class SearchServicemarketContractRequestModel : PddRequestModel
    {
        /// <summary>
        /// 买家店铺id
        /// </summary>
        [JsonProperty("mallId")]
        public long MallId { get; set; }

    }

}
