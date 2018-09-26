using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsTemplateSubPropertyRequestModel : PddRequestModel
    {
        /// <summary>
        /// templatePid
        /// </summary>
        [JsonProperty("template_pid")]
        public int TemplatePid { get; set; }
        /// <summary>
        /// vid
        /// </summary>
        [JsonProperty("vid")]
        public int Vid { get; set; }

    }

}
