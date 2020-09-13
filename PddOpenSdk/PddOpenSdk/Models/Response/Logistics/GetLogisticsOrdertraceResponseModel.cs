using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Logistics
{
public partial class GetLogisticsOrdertraceResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("logistics_ordertrace_get_resposne")]
public LogisticsOrdertraceGetResposneResponseModel LogisticsOrdertraceGetResposne {get;set;}
public partial class LogisticsOrdertraceGetResposneResponseModel : PddResponseModel
{
/// <summary>
/// 返回列表
/// </summary>
[JsonProperty("trace_list")]
public List<TraceListResponseModel> TraceList {get;set;}
public partial class TraceListResponseModel : PddResponseModel
{
/// <summary>
/// 状态发生的时间
/// </summary>
[JsonProperty("status_time")]
public string StatusTime {get;set;}
/// <summary>
/// 状态描述
/// </summary>
[JsonProperty("status_desc")]
public string StatusDesc {get;set;}
/// <summary>
/// 节点说明 ，指明当前节点揽收、派送，签收。 GOT 揽件 SEND 派件  SIGN 签收 ARRIVAL 到件 DEPARTURE 发件 FAIL 问题件 REJECTION 拒签 STAY_IN_WAREHOUSE 留仓 SIGN_ON_BEHALF 代收点代签 OTHER 其他 RETURN 退件 IN_ CABINET 入柜/入代收点 OUT_ CABINET 出柜/出代收点
/// </summary>
[JsonProperty("action")]
public string Action {get;set;}
/// <summary>
/// 地址地一
/// </summary>
[JsonProperty("node_description")]
public string NodeDescription {get;set;}
/// <summary>
/// 时间。。
/// </summary>
[JsonProperty("time")]
public string Time {get;set;}
/// <summary>
/// 描述
/// </summary>
[JsonProperty("desc")]
public string Desc {get;set;}

}

}

}

}
