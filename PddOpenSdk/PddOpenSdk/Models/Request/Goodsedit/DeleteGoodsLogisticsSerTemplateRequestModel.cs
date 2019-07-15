using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class DeleteGoodsLogisticsSerTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 模版id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

    }

}
