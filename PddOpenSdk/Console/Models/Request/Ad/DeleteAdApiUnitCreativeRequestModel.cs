using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class DeleteAdApiUnitCreativeRequestModel : PddRequestModel
{
/// <summary>
/// 创意单元Id
/// </summary>
[JsonProperty("unitCreativeId")]
public long UnitCreativeId {get;set;}

}

}
