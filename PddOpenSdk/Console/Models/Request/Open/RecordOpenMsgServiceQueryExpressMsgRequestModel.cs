using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Open
{
public partial class RecordOpenMsgServiceQueryExpressMsgRequestModel : PddRequestModel
{
/// <summary>
/// 短信发送流水
/// </summary>
[JsonProperty("biz_id")]
public string BizId {get;set;}
/// <summary>
/// 分页参数，每页数量。最大值50
/// </summary>
[JsonProperty("page_number")]
public int PageNumber {get;set;}
/// <summary>
/// 分页参数,页码
/// </summary>
[JsonProperty("page_size")]
public int PageSize {get;set;}
/// <summary>
/// 短信发送日期，支持近30天记录查询，格式yyyyMMdd
/// </summary>
[JsonProperty("send_date")]
public string SendDate {get;set;}
/// <summary>
/// 查询的物流编号
/// </summary>
[JsonProperty("waybill_code")]
public string WaybillCode {get;set;}
/// <summary>
/// 物流公司编号
/// </summary>
[JsonProperty("wp_code")]
public string WpCode {get;set;}

}

}
