using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UploadLogisticsTicketImageResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("logistics_ticket_image_upload_response")]
public object LogisticsTicketImageUploadResponse {get;set;}
/// <summary>
/// 图片url
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}

    public partial class LogisticsTicketImageUploadResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 图片url
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}

}

}
}
