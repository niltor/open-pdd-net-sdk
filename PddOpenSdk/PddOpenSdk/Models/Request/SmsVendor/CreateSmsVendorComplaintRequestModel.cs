using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.SmsVendor
{
public partial class CreateSmsVendorComplaintRequestModel : PddRequestModel
{
/// <summary>
/// cmpp账号名
/// </summary>
[JsonProperty("account")]
public string Account {get;set;}
/// <summary>
/// 投诉时间(格式yyyy-MM-dd HH:mm:ss)
/// </summary>
[JsonProperty("complaint_time")]
public string ComplaintTime {get;set;}
/// <summary>
/// 投诉次数
/// </summary>
[JsonProperty("count")]
public int Count {get;set;}
/// <summary>
/// 短信下发时间(格式yyyy-MM-dd HH:mm:ss)
/// </summary>
[JsonProperty("deliver_time")]
public string DeliverTime {get;set;}
/// <summary>
/// 手机号码
/// </summary>
[JsonProperty("mobile")]
public string Mobile {get;set;}
/// <summary>
/// 归属运营商
/// </summary>
[JsonProperty("operator")]
public string Operator {get;set;}
/// <summary>
/// 归属地省份
/// </summary>
[JsonProperty("province")]
public string Province {get;set;}
/// <summary>
/// 短信投诉内容(不超过500个字)
/// </summary>
[JsonProperty("sms_content")]
public string SmsContent {get;set;}

}

}
