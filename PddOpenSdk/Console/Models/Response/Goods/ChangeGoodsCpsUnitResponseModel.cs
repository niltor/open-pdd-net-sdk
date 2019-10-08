using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class ChangeGoodsCpsUnitResponseModel : PddResponseModel
{
/// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("is_change_success")]
public bool? IsChangeSuccess {get;set;}

}

}
