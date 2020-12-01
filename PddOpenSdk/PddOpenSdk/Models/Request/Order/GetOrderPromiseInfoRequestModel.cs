using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Order
{
    public partial class GetOrderPromiseInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 承诺id
        /// </summary>
        [JsonProperty("promise_id")]
        public long PromiseId { get; set; }

    }

}
