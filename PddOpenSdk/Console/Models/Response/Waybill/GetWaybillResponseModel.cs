using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Waybill
{
public partial class GetWaybillResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("pdd_waybill_get_response")]
public PddWaybillGetResponseResponseModel PddWaybillGetResponse {get;set;}
public partial class PddWaybillGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 系统自动生成
/// </summary>
[JsonProperty("modules")]
public List<ModulesResponseModel> Modules {get;set;}
public partial class ModulesResponseModel : PddResponseModel
{
/// <summary>
/// 请求id
/// </summary>
[JsonProperty("object_id")]
public string ObjectId {get;set;}
/// <summary>
/// 快运母单号
/// </summary>
[JsonProperty("parent_waybill_code")]
public string ParentWaybillCode {get;set;}
/// <summary>
/// 面单信息
/// </summary>
[JsonProperty("print_data")]
public string PrintData {get;set;}
/// <summary>
/// 面单号
/// </summary>
[JsonProperty("waybill_code")]
public string WaybillCode {get;set;}

}

}

}

}
