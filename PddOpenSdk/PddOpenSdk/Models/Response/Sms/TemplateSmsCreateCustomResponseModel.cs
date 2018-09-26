using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class SmsCreateCustomTemplateResponse
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("result")]
        public object Result { get; set; }
    }

    public class TemplateSmsCreateCustomResponseModel
    {

        /// <summary>
        /// Examples: {"result":null}
        /// </summary>
        [JsonProperty("sms_create_custom_template_response")]
        public SmsCreateCustomTemplateResponse SmsCreateCustomTemplateResponse { get; set; }
    }


}
