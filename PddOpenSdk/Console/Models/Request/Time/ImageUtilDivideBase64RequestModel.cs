using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Time
{
public partial class ImageUtilDivideBase64RequestModel : PddRequestModel
{
/// <summary>
/// 支持格式有：jpg/jpeg、png等图片格式，入参为图片的base64编码，最大支持2M
/// </summary>
[JsonProperty("img_data")]
public string ImgData {get;set;}

}

}
