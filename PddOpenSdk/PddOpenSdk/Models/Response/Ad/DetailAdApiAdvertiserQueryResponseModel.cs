using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class DetailAdApiAdvertiserQueryResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("error_code")]
public int? ErrorCode {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("error_msg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 广告主审核状态。1表示审核通过，2表示待审核，3表示审核拒绝，4表示复审拒绝。
/// </summary>
[JsonProperty("advertiser_audit_status")]
public int? AdvertiserAuditStatus {get;set;}
/// <summary>
/// 惩罚信息
/// </summary>
[JsonProperty("advertiser_punish_detail")]
public AdvertiserPunishDetailResponseModel AdvertiserPunishDetail {get;set;}
/// <summary>
/// 广告主审核原因
/// </summary>
[JsonProperty("audit_reason")]
public int? AuditReason {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("mall_Id")]
public long? MallId {get;set;}
public partial class AdvertiserPunishDetailResponseModel : PddResponseModel
{
/// <summary>
/// 惩罚原因
/// </summary>
[JsonProperty("punish_reason")]
public string PunishReason {get;set;}
/// <summary>
/// 惩罚状态。1表示正常，2表示惩罚中。
/// </summary>
[JsonProperty("punish_status")]
public int? PunishStatus {get;set;}

}

}

}

}

}
