using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Express
{
public partial class QueryStockWareDetailRequestModel : PddRequestModel
{
/// <summary>
/// 货品id
/// </summary>
[JsonProperty("ware_id")]
public long WareId {get;set;}

}

}
