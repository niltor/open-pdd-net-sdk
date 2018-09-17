using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetGoodsCountryRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.goods.country.get
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }

    }
}
