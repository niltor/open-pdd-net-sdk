using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Logisticsticket
{
public partial class UploadLogisticsTicketImageRequestModel : PddRequestModel
{
/// <summary>
/// 支持格式有：jpg/jpeg、png等图片格式，入参为图片的base64编码，最大支持1M
/// </summary>
[JsonProperty("image")]
public string Image {get;set;}

}

}
