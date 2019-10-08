using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class DeleteGoodsCpsUnitResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("goods_cps_unit_delete_response")]
public GoodsCpsUnitDeleteResponseResponseModel GoodsCpsUnitDeleteResponse {get;set;}
public partial class GoodsCpsUnitDeleteResponseResponseModel : PddResponseModel
{
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}

}

}

}
