using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Waybill
{
public partial class GetCloudprintStdtemplatesRequestModel : PddRequestModel
{
/// <summary>
/// 快递公司code
/// </summary>
[JsonProperty("wp_code")]
public string WpCode {get;set;}

}

}
