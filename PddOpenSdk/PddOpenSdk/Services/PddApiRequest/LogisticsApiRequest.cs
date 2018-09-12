using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class LogisticsApiRequest : PddRequest {
        /// <summary>
/// 客户与机器人的聊天记录获取接口
/// </summary>
/// <param name="SessionId">pdd会话id</param>
public async Task<GetLogisticsCsHistoryMessageApiResult> GetLogisticsCsHistoryMessageAsync(string(64) SessionId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("session_id",Session Id);
    
    var result = Post<GetLogisticsCsHistoryMessageApiResult>(pdd.logistics.cs.history.message.get,);
    return JsonConvert.DeserializeObject<GetLogisticsCsHistoryMessageApiResult>(result);
}/// <summary>
/// 客服给发消息接口
/// </summary>
/// <param name="SessionId">pdd会话id</param>
/// <param name="WpSessionId">物流公司会话id</param>
/// <param name="ActionTime">样式YYYY-MM-DD HH:MM:SS</param>
/// <param name="MessageType">0：文本1：图片</param>
/// <param name="Text">message_type为0时不为空</param>
/// <param name="Attach">message_type为1时不为空</param>
/// <param name="Preview">message_type为1时不为空</param>
public async Task<SendLogisticsCsMessageApiResult> SendLogisticsCsMessageAsync(string(64) SessionId,string(64) WpSessionId,string ActionTime,int MessageType,string(1024) Text,string(1024) Attach,string(1024) Preview)
{
    var dic = new Dictionary<string, string>();
    dic.Add("session_id",Session Id);
dic.Add("wp_session_id",Wp Session Id);
dic.Add("action_time",Action Time);
dic.Add("message_type",Message Type);
dic.Add("text",Text);
dic.Add("attach",Attach);
dic.Add("preview",Preview);
    
    var result = Post<SendLogisticsCsMessageApiResult>(pdd.logistics.cs.message.send,);
    return JsonConvert.DeserializeObject<SendLogisticsCsMessageApiResult>(result);
}/// <summary>
/// 客服关闭会话接口
/// </summary>
/// <param name="SessionId">pdd会话id</param>
/// <param name="WpSessionId">物流公司会话id</param>
/// <param name="ActionTime">样式YYYY-MM-DD HH:MM:SS</param>
public async Task<CloseLogisticsCsSessionApiResult> CloseLogisticsCsSessionAsync(string(64) SessionId,string(64) WpSessionId,string ActionTime)
{
    var dic = new Dictionary<string, string>();
    dic.Add("session_id",Session Id);
dic.Add("wp_session_id",Wp Session Id);
dic.Add("action_time",Action Time);
    
    var result = Post<CloseLogisticsCsSessionApiResult>(pdd.logistics.cs.session.close,);
    return JsonConvert.DeserializeObject<CloseLogisticsCsSessionApiResult>(result);
}/// <summary>
/// 物流客服系统创建同步会话状态接口
/// </summary>
/// <param name="SessionId">pdd会话id</param>
/// <param name="WpSessionId">物流公司会话id</param>
/// <param name="ActionTime">样式YYYY-MM-DD HH:MM:SS</param>
/// <param name="BizType">可选值：1：已分配 2：排队中 3：分配异常</param>
/// <param name="DealerId">客服id，biz_type为1时必填</param>
/// <param name="QueueId">队列id，biz_type为1时必填</param>
/// <param name="QueueName">对列名，biz_type为1时必填</param>
/// <param name="QueueIndex">排队位置，biz_type为2时必填</param>
/// <param name="ExceptionCode">分配遇到的异常，示例：33222，biz_type为3时不为空</param>
/// <param name="ExceptionMsg">物流客服系统遇到的异常，biz_type为3时不为空</param>
public async Task<StartLogisticsCsSessionApiResult> StartLogisticsCsSessionAsync(string(64) SessionId,string(64) WpSessionId,string ActionTime,int BizType,string(64) DealerId,string(64) QueueId,string(128) QueueName,int QueueIndex,int ExceptionCode,string ExceptionMsg)
{
    var dic = new Dictionary<string, string>();
    dic.Add("session_id",Session Id);
dic.Add("wp_session_id",Wp Session Id);
dic.Add("action_time",Action Time);
dic.Add("biz_type",Biz Type);
dic.Add("dealer_id",Dealer Id);
dic.Add("queue_id",Queue Id);
dic.Add("queue_name",Queue Name);
dic.Add("queue_index",Queue Index);
dic.Add("exception_code",Exception Code);
dic.Add("exception_msg",Exception Msg);
    
    var result = Post<StartLogisticsCsSessionApiResult>(pdd.logistics.cs.session.start,);
    return JsonConvert.DeserializeObject<StartLogisticsCsSessionApiResult>(result);
}/// <summary>
/// 快递公司工单查询接口
/// </summary>
/// <param name="StartUpdatedAt">必填，最后更新时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数。示例：1523762012。</param>
/// <param name="EndUpdatedAt">必填，最后更新时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过 30 分钟。示例：1523763012。</param>
/// <param name="Page">返回页码 默认 1，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值。注：必须采用倒序的分页方式（从最后一页往回取）才能避免漏单问题</param>
/// <param name="PageSize">返回数量，默认 100。最大 100</param>
public async Task<GetLogisticsTicketApiResult> GetLogisticsTicketAsync(number StartUpdatedAt,number EndUpdatedAt,number Page,number PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("start_updated_at",Start Updated At);
dic.Add("end_updated_at",End Updated At);
dic.Add("page",Page);
dic.Add("page_size",Page Size);
    
    var result = Post<GetLogisticsTicketApiResult>(pdd.logistics.ticket.get,);
    return JsonConvert.DeserializeObject<GetLogisticsTicketApiResult>(result);
}/// <summary>
/// 工单图片上传接口
/// </summary>
/// <param name="Image">支持格式有：jpg/jpeg、png等图片格式，入参为图片的base64编码，最大支持1M</param>
public async Task<UploadLogisticsTicketImageApiResult> UploadLogisticsTicketImageAsync(string Image)
{
    var dic = new Dictionary<string, string>();
    dic.Add("image",Image);
    
    var result = Post<UploadLogisticsTicketImageApiResult>(pdd.logistics.ticket.image.upload,);
    return JsonConvert.DeserializeObject<UploadLogisticsTicketImageApiResult>(result);
}/// <summary>
/// 快递公司处理结果回调接口
/// </summary>
/// <param name="TicketId">工单id</param>
/// <param name="WaybillNo">运单号</param>
/// <param name="HandleResult">处理结果</param>
/// <param name="SignState">签收状态，0:默认,1:未签收,2:已签收</param>
/// <param name="CompensateState">是否赔付，0:默认,1:未赔付,2:已赔付</param>
/// <param name="CompensateAmount">赔付金额(单位:分)</param>
/// <param name="AttachPathList">附件url,示例：["http://testimg.yangkeduo.com/pdd_oms/2018-01-16/411068e948835ae053a86c13f8ebb5ee.jpg"]</param>
/// <param name="Duty">责任方，0:默认, 1:消费者,2:商家,3:快递公司,4:其他</param>
/// <param name="ExpressDealer">处理人</param>
/// <param name="ExpressDealerContact">处理人联系方式</param>
public async Task<NotifyLogisticsTicketApiResult> NotifyLogisticsTicketAsync(number TicketId,string WaybillNo,string HandleResult,number SignState,number CompensateState,number CompensateAmount,string AttachPathList,number Duty,string ExpressDealer,string ExpressDealerContact)
{
    var dic = new Dictionary<string, string>();
    dic.Add("ticket_id",Ticket Id);
dic.Add("waybill_no",Waybill No);
dic.Add("handle_result",Handle Result);
dic.Add("sign_state",Sign State);
dic.Add("compensate_state",Compensate State);
dic.Add("compensate_amount",Compensate Amount);
dic.Add("attach_path_list",Attach Path List);
dic.Add("duty",Duty);
dic.Add("express_dealer",Express Dealer);
dic.Add("express_dealer_contact",Express Dealer Contact);
    
    var result = Post<NotifyLogisticsTicketApiResult>(pdd.logistics.ticket.notify,);
    return JsonConvert.DeserializeObject<NotifyLogisticsTicketApiResult>(result);
}/// <summary>
/// 快递公司工单问题类型列表接口
/// </summary>
/// <param name="Type">pdd.logistics.ticket.problem.type.get</param>
public async Task<GetLogisticsTicketProblemTypeApiResult> GetLogisticsTicketProblemTypeAsync(string Type)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
    
    var result = Post<GetLogisticsTicketProblemTypeApiResult>(pdd.logistics.ticket.problem.type.get,);
    return JsonConvert.DeserializeObject<GetLogisticsTicketProblemTypeApiResult>(result);
}
    }
}
