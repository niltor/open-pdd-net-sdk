using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UploadLogisticsTicketImageResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("logistics_ticket_image_upload_response")]
public LogisticsTicketImageUploadResponseResponseModel LogisticsTicketImageUploadResponse {get;set;}

    public partial class LogisticsTicketImageUploadResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 图片url
/// </summary>
[JsonProperty("image_url")]
public string ImageUrl {get;set;}

}

}
}
