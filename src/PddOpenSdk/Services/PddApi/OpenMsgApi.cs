
using PddOpenSdk.Models.Request.OpenMsg;
using PddOpenSdk.Models.Response.OpenMsg;
namespace PddOpenSdk.Services.PddApi;
public class OpenMsgApi : PddCommonApi
{
    public OpenMsgApi() { }
    public OpenMsgApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 查询短信发送记录
    /// </summary>
    public async Task<RecordOpenMsgServiceQueryMsgResponse> RecordOpenMsgServiceQueryMsgAsync(RecordOpenMsgServiceQueryMsg recordOpenMsgServiceQueryMsg)
    {
        var result = await PostAsync<RecordOpenMsgServiceQueryMsg, RecordOpenMsgServiceQueryMsgResponse>("pdd.open.msg.service.query.msg.record", recordOpenMsgServiceQueryMsg);
        return result;
    }

    /// <summary>
    /// 短信批量发送接口
    /// </summary>
    public async Task<MsgOpenMsgServiceSendBatchResponse> MsgOpenMsgServiceSendBatchAsync(MsgOpenMsgServiceSendBatch msgOpenMsgServiceSendBatch)
    {
        var result = await PostAsync<MsgOpenMsgServiceSendBatch, MsgOpenMsgServiceSendBatchResponse>("pdd.open.msg.service.send.batch.msg", msgOpenMsgServiceSendBatch);
        return result;
    }

    /// <summary>
    /// 根据运单号发短信
    /// </summary>
    public async Task<MsgOpenMsgServiceSendExpressResponse> MsgOpenMsgServiceSendExpressAsync(MsgOpenMsgServiceSendExpress msgOpenMsgServiceSendExpress)
    {
        var result = await PostAsync<MsgOpenMsgServiceSendExpress, MsgOpenMsgServiceSendExpressResponse>("pdd.open.msg.service.send.express.msg", msgOpenMsgServiceSendExpress);
        return result;
    }

    /// <summary>
    /// 短信发送接口
    /// </summary>
    public async Task<MsgOpenMsgServiceSendResponse> MsgOpenMsgServiceSendAsync(MsgOpenMsgServiceSend msgOpenMsgServiceSend)
    {
        var result = await PostAsync<MsgOpenMsgServiceSend, MsgOpenMsgServiceSendResponse>("pdd.open.msg.service.send.msg", msgOpenMsgServiceSend);
        return result;
    }

}
