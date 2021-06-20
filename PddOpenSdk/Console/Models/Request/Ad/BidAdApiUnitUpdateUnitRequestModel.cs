using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class BidAdApiUnitUpdateUnitRequestModel : PddRequestModel
{
/// <summary>
/// 广告单元Id
/// </summary>
[JsonProperty("adId")]
public long AdId {get;set;}
/// <summary>
/// 出价不得为空。单位厘。
/// </summary>
[JsonProperty("bid")]
public long Bid {get;set;}

}

}
