using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class DeleteGoodsSizespecTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 尺码表模板id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

    }

}
