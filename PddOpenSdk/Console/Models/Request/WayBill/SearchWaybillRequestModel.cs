using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.WayBill
{
public partial class SearchWaybillRequestModel : PddRequestModel
{
/// <summary>
/// 物流公司code
/// </summary>
[JsonProperty("wp_code")]
public string WpCode {get;set;}

}

}
