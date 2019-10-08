using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Waybill
{
public partial class WaybillcodeWaybillQueryByRequestModel : PddRequestModel
{
/// <summary>
/// 系统自动生成
/// </summary>
[JsonProperty("param_list")]
public List<ParamListRequestModel> ParamList {get;set;}
public partial class ParamListRequestModel : PddRequestModel
{
/// <summary>
/// 请求id
/// </summary>
[JsonProperty("object_id")]
public string ObjectId {get;set;}
/// <summary>
/// 电子面单号
/// </summary>
[JsonProperty("waybill_code")]
public string WaybillCode {get;set;}
/// <summary>
/// 快递公司code
/// </summary>
[JsonProperty("wp_code")]
public string WpCode {get;set;}

}

}

}
