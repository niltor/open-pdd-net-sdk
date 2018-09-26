using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public class LogisticsTicketImageUploadResponse
    {

        /// <summary>
        /// Examples: "http://testimg.yangkeduo.com/pdd_oms/2018-04-15/21a75990968b4f8cc7fdcc1f68ac6e78.jpg"
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class UploadLogisticsTicketImageResponseModel
    {

        /// <summary>
        /// Examples: {"image_url":"http://testimg.yangkeduo.com/pdd_oms/2018-04-15/21a75990968b4f8cc7fdcc1f68ac6e78.jpg"}
        /// </summary>
        [JsonProperty("logistics_ticket_image_upload_response")]
        public LogisticsTicketImageUploadResponse LogisticsTicketImageUploadResponse { get; set; }
    }


}
