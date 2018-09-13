using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetLogisticsTicketResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("logistics_ticket_get_response")]
public object LogisticsTicketGetResponse {get;set;}
/// <summary>
/// 列表总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}
/// <summary>
/// 工单列表
/// </summary>
[JsonProperty("logistics_ticket_list")]
public object LogisticsTicketList {get;set;}
/// <summary>
/// 订单号生成的物流单号
/// </summary>
[JsonProperty("pre_delivery_id")]
public object PreDeliveryId {get;set;}
/// <summary>
/// 物流商处理结果
/// </summary>
[JsonProperty("handle_result")]
public object HandleResult {get;set;}
/// <summary>
/// 物流商快递编码
/// </summary>
[JsonProperty("express_company_id")]
public int ExpressCompanyId {get;set;}
/// <summary>
/// 赔付状态 0:默认,1:未赔付,2:已赔付
/// </summary>
[JsonProperty("compensate_state")]
public int CompensateState {get;set;}
/// <summary>
/// 赔付金额(单位:分)
/// </summary>
[JsonProperty("compensate_amount")]
public int CompensateAmount {get;set;}
/// <summary>
/// 物流商回传凭证
/// </summary>
[JsonProperty("express_attachment")]
public object ExpressAttachment {get;set;}
/// <summary>
/// 0:默认,1:未签收,2:已签收
/// </summary>
[JsonProperty("sign_state")]
public int SignState {get;set;}
/// <summary>
/// 处理人
/// </summary>
[JsonProperty("express_dealer")]
public object ExpressDealer {get;set;}
/// <summary>
/// 处理人联系方式
/// </summary>
[JsonProperty("express_dealer_contact")]
public object ExpressDealerContact {get;set;}
/// <summary>
/// 工单退回次数
/// </summary>
[JsonProperty("retreat_count")]
public int RetreatCount {get;set;}
/// <summary>
/// 联系人姓名
/// </summary>
[JsonProperty("receive_name")]
public object ReceiveName {get;set;}
/// <summary>
/// 联系人电话
/// </summary>
[JsonProperty("receive_contact")]
public object ReceiveContact {get;set;}
/// <summary>
/// 工单创建时间戳
/// </summary>
[JsonProperty("created_at")]
public int CreatedAt {get;set;}
/// <summary>
/// 工单最后更新时间戳
/// </summary>
[JsonProperty("updated_at")]
public int UpdatedAt {get;set;}
/// <summary>
/// 问题描述
/// </summary>
[JsonProperty("title")]
public object Title {get;set;}
/// <summary>
/// 备注
/// </summary>
[JsonProperty("description")]
public object Description {get;set;}
/// <summary>
/// 问题来源，	0:买家,1:卖家
/// </summary>
[JsonProperty("source")]
public int Source {get;set;}
/// <summary>
/// 工单id
/// </summary>
[JsonProperty("ticket_id")]
public int TicketId {get;set;}
/// <summary>
/// 运单号
/// </summary>
[JsonProperty("waybill_no")]
public object WaybillNo {get;set;}
/// <summary>
/// 紧急度，0:中,1:紧急
/// </summary>
[JsonProperty("urgent_type")]
public int UrgentType {get;set;}
/// <summary>
/// 问题类型id
/// </summary>
[JsonProperty("type_id")]
public int TypeId {get;set;}
/// <summary>
/// 附件列表
/// </summary>
[JsonProperty("attach_url")]
public object AttachUrl {get;set;}
/// <summary>
/// 工单状态， 0:待确认,1:跟进中,2:待回访,3:已完结
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}

    public partial class LogisticsTicketGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 列表总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}
/// <summary>
/// 工单列表
/// </summary>
[JsonProperty("logistics_ticket_list")]
public object LogisticsTicketList {get;set;}

}

    public partial class LogisticsTicketListResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单号生成的物流单号
/// </summary>
[JsonProperty("pre_delivery_id")]
public object PreDeliveryId {get;set;}
/// <summary>
/// 物流商处理结果
/// </summary>
[JsonProperty("handle_result")]
public object HandleResult {get;set;}
/// <summary>
/// 物流商快递编码
/// </summary>
[JsonProperty("express_company_id")]
public int ExpressCompanyId {get;set;}
/// <summary>
/// 赔付状态 0:默认,1:未赔付,2:已赔付
/// </summary>
[JsonProperty("compensate_state")]
public int CompensateState {get;set;}
/// <summary>
/// 赔付金额(单位:分)
/// </summary>
[JsonProperty("compensate_amount")]
public int CompensateAmount {get;set;}
/// <summary>
/// 物流商回传凭证
/// </summary>
[JsonProperty("express_attachment")]
public object ExpressAttachment {get;set;}
/// <summary>
/// 0:默认,1:未签收,2:已签收
/// </summary>
[JsonProperty("sign_state")]
public int SignState {get;set;}
/// <summary>
/// 处理人
/// </summary>
[JsonProperty("express_dealer")]
public object ExpressDealer {get;set;}
/// <summary>
/// 处理人联系方式
/// </summary>
[JsonProperty("express_dealer_contact")]
public object ExpressDealerContact {get;set;}
/// <summary>
/// 工单退回次数
/// </summary>
[JsonProperty("retreat_count")]
public int RetreatCount {get;set;}
/// <summary>
/// 联系人姓名
/// </summary>
[JsonProperty("receive_name")]
public object ReceiveName {get;set;}
/// <summary>
/// 联系人电话
/// </summary>
[JsonProperty("receive_contact")]
public object ReceiveContact {get;set;}
/// <summary>
/// 工单创建时间戳
/// </summary>
[JsonProperty("created_at")]
public int CreatedAt {get;set;}
/// <summary>
/// 工单最后更新时间戳
/// </summary>
[JsonProperty("updated_at")]
public int UpdatedAt {get;set;}
/// <summary>
/// 问题描述
/// </summary>
[JsonProperty("title")]
public object Title {get;set;}
/// <summary>
/// 备注
/// </summary>
[JsonProperty("description")]
public object Description {get;set;}
/// <summary>
/// 问题来源，	0:买家,1:卖家
/// </summary>
[JsonProperty("source")]
public int Source {get;set;}
/// <summary>
/// 工单id
/// </summary>
[JsonProperty("ticket_id")]
public int TicketId {get;set;}
/// <summary>
/// 运单号
/// </summary>
[JsonProperty("waybill_no")]
public object WaybillNo {get;set;}
/// <summary>
/// 紧急度，0:中,1:紧急
/// </summary>
[JsonProperty("urgent_type")]
public int UrgentType {get;set;}
/// <summary>
/// 问题类型id
/// </summary>
[JsonProperty("type_id")]
public int TypeId {get;set;}
/// <summary>
/// 附件列表
/// </summary>
[JsonProperty("attach_url")]
public object AttachUrl {get;set;}
/// <summary>
/// 工单状态， 0:待确认,1:跟进中,2:待回访,3:已完结
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}

}

}
}
