using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsFabricRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.goods.fabric.get
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

    }

}
