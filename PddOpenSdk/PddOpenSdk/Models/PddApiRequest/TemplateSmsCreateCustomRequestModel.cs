using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class TemplateSmsCreateCustomRequestModel : PddRequestModel
    {
        /// <summary>
        /// 短信模板名称
        /// </summary>
        [JsonProperty("name")]
        public object Name { get; set; }
        /// <summary>
        /// 拼接短信内容
        /// </summary>
        [JsonProperty("content")]
        public object Content { get; set; }

        public partial class ContentRequestModel : PddRequestModel
        {

        }

    }
}
