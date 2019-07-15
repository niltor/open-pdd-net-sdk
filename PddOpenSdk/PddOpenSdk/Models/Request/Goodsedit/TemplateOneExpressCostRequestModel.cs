using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class TemplateOneExpressCostRequestModel : PddRequestModel
    {
        /// <summary>
        /// 运费模板id
        /// </summary>
        [JsonProperty("cost_template_id")]
        public long CostTemplateId { get; set; }

    }

}
