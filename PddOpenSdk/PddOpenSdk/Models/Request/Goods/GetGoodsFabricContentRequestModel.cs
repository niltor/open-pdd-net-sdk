using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsFabricContentRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.goods.fabric.content.get
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

    }

}
