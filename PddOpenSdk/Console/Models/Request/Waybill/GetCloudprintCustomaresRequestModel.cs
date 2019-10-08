using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Waybill
{
public partial class GetCloudprintCustomaresRequestModel : PddRequestModel
{
/// <summary>
/// 用户使用的模板id，即pdd.cloudprint.stdtemplates.get接口中的standard_template_id
/// </summary>
[JsonProperty("template_id")]
public string TemplateId {get;set;}

}

}
