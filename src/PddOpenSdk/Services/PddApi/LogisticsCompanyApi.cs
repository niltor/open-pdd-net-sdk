
using PddOpenSdk.Models.Request.LogisticsCompany;
using PddOpenSdk.Models.Response.LogisticsCompany;

namespace PddOpenSdk.Services.PddApi;
public class LogisticsCompanyApi : PddCommonApi
{
    public LogisticsCompanyApi() { }
    public LogisticsCompanyApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 客户与机器人的聊天记录获取接口
    /// </summary>
    public async Task<GetLogisticsCsHistoryMessageResponse> GetLogisticsCsHistoryMessageAsync(GetLogisticsCsHistoryMessage getLogisticsCsHistoryMessage)
    {
        var result = await PostAsync<GetLogisticsCsHistoryMessage, GetLogisticsCsHistoryMessageResponse>("pdd.logistics.cs.history.message.get", getLogisticsCsHistoryMessage);
        return result;
    }

    /// <summary>
    /// 客服给发消息接口
    /// </summary>
    public async Task<SendLogisticsCsMessageResponse> SendLogisticsCsMessageAsync(SendLogisticsCsMessage sendLogisticsCsMessage)
    {
        var result = await PostAsync<SendLogisticsCsMessage, SendLogisticsCsMessageResponse>("pdd.logistics.cs.message.send", sendLogisticsCsMessage);
        return result;
    }

    /// <summary>
    /// 客服关闭会话接口
    /// </summary>
    public async Task<CloseLogisticsCsSessionResponse> CloseLogisticsCsSessionAsync(CloseLogisticsCsSession closeLogisticsCsSession)
    {
        var result = await PostAsync<CloseLogisticsCsSession, CloseLogisticsCsSessionResponse>("pdd.logistics.cs.session.close", closeLogisticsCsSession);
        return result;
    }

    /// <summary>
    /// 物流客服系统创建同步会话状态接口
    /// </summary>
    public async Task<StartLogisticsCsSessionResponse> StartLogisticsCsSessionAsync(StartLogisticsCsSession startLogisticsCsSession)
    {
        var result = await PostAsync<StartLogisticsCsSession, StartLogisticsCsSessionResponse>("pdd.logistics.cs.session.start", startLogisticsCsSession);
        return result;
    }

    /// <summary>
    /// 快递公司工单查询接口
    /// </summary>
    public async Task<GetLogisticsTicketResponse> GetLogisticsTicketAsync(GetLogisticsTicket getLogisticsTicket)
    {
        var result = await PostAsync<GetLogisticsTicket, GetLogisticsTicketResponse>("pdd.logistics.ticket.get", getLogisticsTicket);
        return result;
    }

    /// <summary>
    /// 工单图片上传接口
    /// </summary>
    public async Task<UploadLogisticsTicketImageResponse> UploadLogisticsTicketImageAsync(UploadLogisticsTicketImage uploadLogisticsTicketImage)
    {
        var result = await PostAsync<UploadLogisticsTicketImage, UploadLogisticsTicketImageResponse>("pdd.logistics.ticket.image.upload", uploadLogisticsTicketImage);
        return result;
    }

    /// <summary>
    /// 快递公司处理结果回调接口
    /// </summary>
    public async Task<NotifyLogisticsTicketResponse> NotifyLogisticsTicketAsync(NotifyLogisticsTicket notifyLogisticsTicket)
    {
        var result = await PostAsync<NotifyLogisticsTicket, NotifyLogisticsTicketResponse>("pdd.logistics.ticket.notify", notifyLogisticsTicket);
        return result;
    }

    /// <summary>
    /// 快递公司工单问题类型列表接口
    /// </summary>
    public async Task<GetLogisticsTicketProblemTypeResponse> GetLogisticsTicketProblemTypeAsync(GetLogisticsTicketProblemType getLogisticsTicketProblemType)
    {
        var result = await PostAsync<GetLogisticsTicketProblemType, GetLogisticsTicketProblemTypeResponse>("pdd.logistics.ticket.problem.type.get", getLogisticsTicketProblemType);
        return result;
    }

    /// <summary>
    /// 寄件实操回告接口
    /// </summary>
    public async Task<NotifyServiceMailBizactionResponse> NotifyServiceMailBizactionAsync(NotifyServiceMailBizaction notifyServiceMailBizaction)
    {
        var result = await PostAsync<NotifyServiceMailBizaction, NotifyServiceMailBizactionResponse>("pdd.service.mail.bizaction.notify", notifyServiceMailBizaction);
        return result;
    }

    /// <summary>
    /// 轨迹订阅接口
    /// </summary>
    public async Task<SubLogisticsCoTrackResponse> SubLogisticsCoTrackAsync(SubLogisticsCoTrack subLogisticsCoTrack)
    {
        var result = await PostAsync<SubLogisticsCoTrack, SubLogisticsCoTrackResponse>("pdd.logistics.co.track.sub", subLogisticsCoTrack);
        return result;
    }

    /// <summary>
    /// 获取丰巢开平的access_token
    /// </summary>
    public async Task<AuthServiceMailOrderFcResponse> AuthServiceMailOrderFcAsync(AuthServiceMailOrderFc authServiceMailOrderFc)
    {
        var result = await PostAsync<AuthServiceMailOrderFc, AuthServiceMailOrderFcResponse>("pdd.service.mail.order.fc.auth", authServiceMailOrderFc);
        return result;
    }

    /// <summary>
    /// 服务时间查询接口
    /// </summary>
    public async Task<QueryServiceMailServiceTimeResponse> QueryServiceMailServiceTimeAsync(QueryServiceMailServiceTime queryServiceMailServiceTime)
    {
        var result = await PostAsync<QueryServiceMailServiceTime, QueryServiceMailServiceTimeResponse>("pdd.service.mail.service.time.query", queryServiceMailServiceTime);
        return result;
    }

}
