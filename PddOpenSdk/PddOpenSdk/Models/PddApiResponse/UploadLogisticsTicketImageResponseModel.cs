using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UploadLogisticsTicketImageResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("logistics_ticket_image_upload_response")]
        public object LogisticsTicketImageUploadResponse { get; set; }

        public partial class LogisticsTicketImageUploadResponseResponseModel : PddResponseModel
        {

        }

    }
}
