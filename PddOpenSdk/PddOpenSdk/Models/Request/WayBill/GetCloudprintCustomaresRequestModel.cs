using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.WayBill
{
    public partial class GetCloudprintCustomaresRequestModel : PddRequestModel
    {
        /// <summary>
        /// 用户使用的模板id，即pdd.cloudprint.stdtemplates.get接口中的standard_template_id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

    }

}
