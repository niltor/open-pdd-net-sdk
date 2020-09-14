using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsSizespecTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 尺码表id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

    }

}
