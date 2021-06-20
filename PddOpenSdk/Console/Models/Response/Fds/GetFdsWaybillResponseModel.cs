using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Fds
{
public partial class GetFdsWaybillResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("pdd_fds_waybill_get_response")]
public PddFdsWaybillGetResponseResponseModel PddFdsWaybillGetResponse {get;set;}
public partial class PddFdsWaybillGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 系统自动生成
/// </summary>
[JsonProperty("modules")]
public List<ModulesResponseModel> Modules {get;set;}
public partial class ModulesResponseModel : PddResponseModel
{
/// <summary>
/// 请求 id
/// </summary>
[JsonProperty("object_id")]
public string ObjectId {get;set;}
/// <summary>
/// 快运母单号
/// </summary>
[JsonProperty("parent_waybill_code")]
public string ParentWaybillCode {get;set;}
/// <summary>
/// 模板内容（模板内容加密，只需透传至打印组件
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
