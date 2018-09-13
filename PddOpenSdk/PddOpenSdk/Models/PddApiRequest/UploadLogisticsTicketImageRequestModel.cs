using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class UploadLogisticsTicketImageRequestModel : PddRequestModel
    {
        /// <summary>
/// 支持格式有：jpg/jpeg、png等图片格式，入参为图片的base64编码，最大支持1M
/// </summary>
[JsonProperty("image")]
public object Image {get;set;}

}
}
