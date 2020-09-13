using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Order
{
public partial class GetChatPromiseInfoRequestModel : PddRequestModel
{
/// <summary>
/// 承诺id
/// </summary>
[JsonProperty("promise_id")]
public long PromiseId {get;set;}

}

}
