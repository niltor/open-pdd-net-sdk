using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Order
{
public partial class GetOrderStatusRequestModel : PddRequestModel
{
/// <summary>
/// 20150909-452750051,20150909-452750134 用逗号分开
/// </summary>
[JsonProperty("order_sns")]
public string OrderSns {get;set;}

}

}
