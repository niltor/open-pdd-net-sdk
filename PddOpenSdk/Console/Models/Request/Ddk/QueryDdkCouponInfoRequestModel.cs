using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class QueryDdkCouponInfoRequestModel : PddRequestModel
{
/// <summary>
/// 优惠券id
/// </summary>
[JsonProperty("coupon_ids")]
public List<string> CouponIds {get;set;}

}

}
