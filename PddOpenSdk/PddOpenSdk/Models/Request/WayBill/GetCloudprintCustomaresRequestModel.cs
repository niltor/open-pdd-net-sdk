using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.WayBill
{
    public partial class GetCloudprintCustomaresRequestModel : PddRequestModel
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("template_id")]
        public int TemplateId { get; set; }

    }

}
