using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Waybill
{
    public partial class GetCloudprintCustomaresRequestModel : PddRequestModel
    {
        /// <summary>
        /// 用户使用的标准模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

    }

}
