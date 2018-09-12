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
    dic.Add("session_id",SessionId);
    
    var result = Post<GetLogisticsCsHistoryMessageApiResult>("pdd.logistics.cs.history.message.get",dic);
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
    dic.Add("session_id",SessionId);
dic.Add("wp_session_id",WpSessionId);
dic.Add("action_time",ActionTime);
dic.Add("message_type",MessageType);
dic.Add("text",Text);
dic.Add("attach",Attach);
dic.Add("preview",Preview);
    
    var result = Post<SendLogisticsCsMessageApiResult>("pdd.logistics.cs.message.send",dic);
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
    dic.Add("session_id",SessionId);
dic.Add("wp_session_id",WpSessionId);
dic.Add("action_time",ActionTime);
    
    var result = Post<CloseLogisticsCsSessionApiResult>("pdd.logistics.cs.session.close",dic);
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
    dic.Add("session_id",SessionId);
dic.Add("wp_session_id",WpSessionId);
dic.Add("action_time",ActionTime);
dic.Add("biz_type",BizType);
dic.Add("dealer_id",DealerId);
dic.Add("queue_id",QueueId);
dic.Add("queue_name",QueueName);
dic.Add("queue_index",QueueIndex);
dic.Add("exception_code",ExceptionCode);
dic.Add("exception_msg",ExceptionMsg);
    
    var result = Post<StartLogisticsCsSessionApiResult>("pdd.logistics.cs.session.start",dic);
    return JsonConvert.DeserializeObject<StartLogisticsCsSessionApiResult>(result);
}/// <summary>
/// 快递公司工单查询接口
/// </summary>
/// <param name="StartUpdatedAt">必填，最后更新时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数。示例：1523762012。</param>
/// <param name="EndUpdatedAt">必填，最后更新时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过 30 分钟。示例：1523763012。</param>
/// <param name="Page">返回页码 默认 1，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值。注：必须采用倒序的分页方式（从最后一页往回取）才能避免漏单问题</param>
/// <param name="PageSize">返回数量，默认 100。最大 100</param>
public async Task<GetLogisticsTicketApiResult> GetLogisticsTicketAsync(int StartUpdatedAt,int EndUpdatedAt,int Page,int PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("start_updated_at",StartUpdatedAt);
dic.Add("end_updated_at",EndUpdatedAt);
dic.Add("page",Page);
dic.Add("page_size",PageSize);
    
    var result = Post<GetLogisticsTicketApiResult>("pdd.logistics.ticket.get",dic);
    return JsonConvert.DeserializeObject<GetLogisticsTicketApiResult>(result);
}/// <summary>
/// 工单图片上传接口
/// </summary>
/// <param name="Image">支持格式有：jpg/jpeg、png等图片格式，入参为图片的base64编码，最大支持1M</param>
public async Task<UploadLogisticsTicketImageApiResult> UploadLogisticsTicketImageAsync(string Image)
{
    var dic = new Dictionary<string, string>();
    dic.Add("image",Image);
    
    var result = Post<UploadLogisticsTicketImageApiResult>("pdd.logistics.ticket.image.upload",dic);
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
public async Task<NotifyLogisticsTicketApiResult> NotifyLogisticsTicketAsync(int TicketId,string WaybillNo,string HandleResult,int SignState,int CompensateState,int CompensateAmount,string AttachPathList,int Duty,string ExpressDealer,string ExpressDealerContact)
{
    var dic = new Dictionary<string, string>();
    dic.Add("ticket_id",TicketId);
dic.Add("waybill_no",WaybillNo);
dic.Add("handle_result",HandleResult);
dic.Add("sign_state",SignState);
dic.Add("compensate_state",CompensateState);
dic.Add("compensate_amount",CompensateAmount);
dic.Add("attach_path_list",AttachPathList);
dic.Add("duty",Duty);
dic.Add("express_dealer",ExpressDealer);
dic.Add("express_dealer_contact",ExpressDealerContact);
    
    var result = Post<NotifyLogisticsTicketApiResult>("pdd.logistics.ticket.notify",dic);
    return JsonConvert.DeserializeObject<NotifyLogisticsTicketApiResult>(result);
}/// <summary>
/// 快递公司工单问题类型列表接口
/// </summary>
/// <param name="Type">pdd.logistics.ticket.problem.type.get</param>
public async Task<GetLogisticsTicketProblemTypeApiResult> GetLogisticsTicketProblemTypeAsync(string Type)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
    
    var result = Post<GetLogisticsTicketProblemTypeApiResult>("pdd.logistics.ticket.problem.type.get",dic);
    return JsonConvert.DeserializeObject<GetLogisticsTicketProblemTypeApiResult>(result);
}
    }
}
