using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class UploadGoodsFilespaceImageRequestModel : PddRequestModel
{
/// <summary>
/// 图片文件流
/// </summary>
[JsonProperty("file_path")]
public string FilePath {get;set;}

}

}
