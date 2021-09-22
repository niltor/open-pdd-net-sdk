
using PddOpenSdk.Models.Request.LogisticsCompany;
using PddOpenSdk.Models.Response.LogisticsCompany;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class LogisticsCompanyApi : PddCommonApi
    {
        public LogisticsCompanyApi() { }
        public LogisticsCompanyApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 客户与机器人的聊天记录获取接口
        /// </summary>
        public async Task<GetLogisticsCsHistoryMessageResponseModel> GetLogisticsCsHistoryMessageAsync(GetLogisticsCsHistoryMessageRequestModel getLogisticsCsHistoryMessage)
        {
            var result = await PostAsync<GetLogisticsCsHistoryMessageRequestModel, GetLogisticsCsHistoryMessageResponseModel>("pdd.logistics.cs.history.message.get", getLogisticsCsHistoryMessage);
            return result;
        }
        /// <summary>
        /// 客服给发消息接口
        /// </summary>
        public async Task<SendLogisticsCsMessageResponseModel> SendLogisticsCsMessageAsync(SendLogisticsCsMessageRequestModel sendLogisticsCsMessage)
        {
            var result = await PostAsync<SendLogisticsCsMessageRequestModel, SendLogisticsCsMessageResponseModel>("pdd.logistics.cs.message.send", sendLogisticsCsMessage);
            return result;
        }
        /// <summary>
        /// 客服关闭会话接口
        /// </summary>
        public async Task<CloseLogisticsCsSessionResponseModel> CloseLogisticsCsSessionAsync(CloseLogisticsCsSessionRequestModel closeLogisticsCsSession)
        {
            var result = await PostAsync<CloseLogisticsCsSessionRequestModel, CloseLogisticsCsSessionResponseModel>("pdd.logistics.cs.session.close", closeLogisticsCsSession);
            return result;
        }
        /// <summary>
        /// 物流客服系统创建同步会话状态接口
        /// </summary>
        public async Task<StartLogisticsCsSessionResponseModel> StartLogisticsCsSessionAsync(StartLogisticsCsSessionRequestModel startLogisticsCsSession)
        {
            var result = await PostAsync<StartLogisticsCsSessionRequestModel, StartLogisticsCsSessionResponseModel>("pdd.logistics.cs.session.start", startLogisticsCsSession);
            return result;
        }
        /// <summary>
        /// 快递公司工单查询接口
        /// </summary>
        public async Task<GetLogisticsTicketResponseModel> GetLogisticsTicketAsync(GetLogisticsTicketRequestModel getLogisticsTicket)
        {
            var result = await PostAsync<GetLogisticsTicketRequestModel, GetLogisticsTicketResponseModel>("pdd.logistics.ticket.get", getLogisticsTicket);
            return result;
        }
        /// <summary>
        /// 工单图片上传接口
        /// </summary>
        public async Task<UploadLogisticsTicketImageResponseModel> UploadLogisticsTicketImageAsync(UploadLogisticsTicketImageRequestModel uploadLogisticsTicketImage)
        {
            var result = await PostAsync<UploadLogisticsTicketImageRequestModel, UploadLogisticsTicketImageResponseModel>("pdd.logistics.ticket.image.upload", uploadLogisticsTicketImage);
            return result;
        }
        /// <summary>
        /// 快递公司处理结果回调接口
        /// </summary>
        public async Task<NotifyLogisticsTicketResponseModel> NotifyLogisticsTicketAsync(NotifyLogisticsTicketRequestModel notifyLogisticsTicket)
        {
            var result = await PostAsync<NotifyLogisticsTicketRequestModel, NotifyLogisticsTicketResponseModel>("pdd.logistics.ticket.notify", notifyLogisticsTicket);
            return result;
        }
        /// <summary>
        /// 快递公司工单问题类型列表接口
        /// </summary>
        public async Task<GetLogisticsTicketProblemTypeResponseModel> GetLogisticsTicketProblemTypeAsync(GetLogisticsTicketProblemTypeRequestModel getLogisticsTicketProblemType)
        {
            var result = await PostAsync<GetLogisticsTicketProblemTypeRequestModel, GetLogisticsTicketProblemTypeResponseModel>("pdd.logistics.ticket.problem.type.get", getLogisticsTicketProblemType);
            return result;
        }
        /// <summary>
        /// 寄件实操回告接口
        /// </summary>
        public async Task<NotifyServiceMailBizactionResponseModel> NotifyServiceMailBizactionAsync(NotifyServiceMailBizactionRequestModel notifyServiceMailBizaction)
        {
            var result = await PostAsync<NotifyServiceMailBizactionRequestModel, NotifyServiceMailBizactionResponseModel>("pdd.service.mail.bizaction.notify", notifyServiceMailBizaction);
            return result;
        }
        /// <summary>
        /// 柜子状态变更通知接口
        /// </summary>
        public async Task<NotifyServiceMailBoxStatusResponseModel> NotifyServiceMailBoxStatusAsync(NotifyServiceMailBoxStatusRequestModel notifyServiceMailBoxStatus)
        {
            var result = await PostAsync<NotifyServiceMailBoxStatusRequestModel, NotifyServiceMailBoxStatusResponseModel>("pdd.service.mail.box.status.notify", notifyServiceMailBoxStatus);
            return result;
        }
        /// <summary>
        /// 轨迹订阅接口
        /// </summary>
        public async Task<SubLogisticsCoTrackResponseModel> SubLogisticsCoTrackAsync(SubLogisticsCoTrackRequestModel subLogisticsCoTrack)
        {
            var result = await PostAsync<SubLogisticsCoTrackRequestModel, SubLogisticsCoTrackResponseModel>("pdd.logistics.co.track.sub", subLogisticsCoTrack);
            return result;
        }
        /// <summary>
        /// 获取丰巢开平的access_token
        /// </summary>
        public async Task<AuthServiceMailOrderFcResponseModel> AuthServiceMailOrderFcAsync(AuthServiceMailOrderFcRequestModel authServiceMailOrderFc)
        {
            var result = await PostAsync<AuthServiceMailOrderFcRequestModel, AuthServiceMailOrderFcResponseModel>("pdd.service.mail.order.fc.auth", authServiceMailOrderFc);
            return result;
        }
        /// <summary>
        /// 服务时间查询接口
        /// </summary>
        public async Task<QueryServiceMailServiceTimeResponseModel> QueryServiceMailServiceTimeAsync(QueryServiceMailServiceTimeRequestModel queryServiceMailServiceTime)
        {
            var result = await PostAsync<QueryServiceMailServiceTimeRequestModel, QueryServiceMailServiceTimeResponseModel>("pdd.service.mail.service.time.query", queryServiceMailServiceTime);
            return result;
        }

    }
}
