using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.LogisticsCompany
{
public partial class GetLogisticsTicketResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("logistics_ticket_get_response")]
public LogisticsTicketGetResponseResponseModel LogisticsTicketGetResponse {get;set;}
public partial class LogisticsTicketGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 工单列表
/// </summary>
[JsonProperty("logistics_ticket_list")]
public List<LogisticsTicketListResponseModel> LogisticsTicketList {get;set;}
/// <summary>
/// 列表总数
/// </summary>
[JsonProperty("total_count")]
public int? TotalCount {get;set;}
public partial class LogisticsTicketListResponseModel : PddResponseModel
{
/// <summary>
/// 附件列表
/// </summary>
[JsonProperty("attach_url")]
public List<string> AttachUrl {get;set;}
/// <summary>
/// 末端品牌代码
/// </summary>
[JsonProperty("cabinet_code")]
public string CabinetCode {get;set;}
/// <summary>
/// 赔付金额(单位:分)
/// </summary>
[JsonProperty("compensate_amount")]
public long? CompensateAmount {get;set;}
/// <summary>
/// 赔付状态 0:默认,1:未赔付,2:已赔付
/// </summary>
[JsonProperty("compensate_state")]
public int? CompensateState {get;set;}
/// <summary>
/// 工单创建时间戳
/// </summary>
[JsonProperty("created_at")]
public long? CreatedAt {get;set;}
/// <summary>
/// create_type
/// </summary>
[JsonProperty("create_type")]
public int? CreateType {get;set;}
/// <summary>
/// 备注
/// </summary>
[JsonProperty("description")]
public string Description {get;set;}
/// <summary>
/// duty
/// </summary>
[JsonProperty("duty")]
public int? Duty {get;set;}
/// <summary>
/// 物流商回传凭证
/// </summary>
[JsonProperty("express_attachment")]
public List<string> ExpressAttachment {get;set;}
/// <summary>
/// 物流商快递编码
/// </summary>
[JsonProperty("express_company_id")]
public long? ExpressCompanyId {get;set;}
/// <summary>
/// 处理人
/// </summary>
[JsonProperty("express_dealer")]
public string ExpressDealer {get;set;}
/// <summary>
/// 处理人联系方式
/// </summary>
[JsonProperty("express_dealer_contact")]
public string ExpressDealerContact {get;set;}
/// <summary>
/// 物流商处理结果
/// </summary>
[JsonProperty("handle_result")]
public string HandleResult {get;set;}
/// <summary>
/// 寄件单号
/// </summary>
[JsonProperty("mail_order_sn")]
public string MailOrderSn {get;set;}
/// <summary>
/// 订单金额
/// </summary>
[JsonProperty("pay_amount")]
public long? PayAmount {get;set;}
/// <summary>
/// 订单号生成的物流单号
/// </summary>
[JsonProperty("pre_delivery_id")]
public string PreDeliveryId {get;set;}
/// <summary>
/// receive_address
/// </summary>
[JsonProperty("receive_address")]
public string ReceiveAddress {get;set;}
/// <summary>
/// 联系人电话
/// </summary>
[JsonProperty("receive_contact")]
public string ReceiveContact {get;set;}
/// <summary>
/// 联系人姓名
/// </summary>
[JsonProperty("receive_name")]
public string ReceiveName {get;set;}
/// <summary>
/// 工单退回次数
/// </summary>
[JsonProperty("retreat_count")]
public long? RetreatCount {get;set;}
/// <summary>
/// send_address
/// </summary>
[JsonProperty("send_address")]
public string SendAddress {get;set;}
/// <summary>
/// 0:默认,1:未签收,2:已签收
/// </summary>
[JsonProperty("sign_state")]
public int? SignState {get;set;}
/// <summary>
/// 问题来源，	0:买家,1:卖家
/// </summary>
[JsonProperty("source")]
public int? Source {get;set;}
/// <summary>
/// 工单状态， 0:待确认,1:跟进中,2:待回访,3:已完结
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 物流投诉标签
/// </summary>
[JsonProperty("sub_type_ids")]
public List<int?> SubTypeIds {get;set;}
/// <summary>
/// 工单id
/// </summary>
[JsonProperty("ticket_id")]
public long? TicketId {get;set;}
/// <summary>
/// 问题描述
/// </summary>
[JsonProperty("title")]
public string Title {get;set;}
/// <summary>
/// 问题类型id
/// </summary>
[JsonProperty("type_id")]
public long? TypeId {get;set;}
/// <summary>
/// 工单最后更新时间戳
/// </summary>
[JsonProperty("updated_at")]
public long? UpdatedAt {get;set;}
/// <summary>
/// 紧急度，0:中,1:紧急
/// </summary>
[JsonProperty("urgent_type")]
public int? UrgentType {get;set;}
/// <summary>
/// 运单号
/// </summary>
[JsonProperty("waybill_no")]
public string WaybillNo {get;set;}

}

}

}

}
