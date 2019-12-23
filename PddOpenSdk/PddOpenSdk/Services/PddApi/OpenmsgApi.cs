using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Openmsg;
using PddOpenSdk.Models.Response.Openmsg;
namespace PddOpenSdk.Services.PddApi
{
    public class OpenmsgApi : PddCommonApi
    {
        /// <summary>
        /// 根据运单号查询短信发送记录
        /// </summary>
        public async Task<RecordOpenMsgServiceQueryExpressMsgResponseModel> RecordOpenMsgServiceQueryExpressMsgAsync(RecordOpenMsgServiceQueryExpressMsgRequestModel recordOpenMsgServiceQueryExpressMsg)
        {
            var result = await PostAsync<RecordOpenMsgServiceQueryExpressMsgRequestModel, RecordOpenMsgServiceQueryExpressMsgResponseModel>("pdd.open.msg.service.query.express.msg.record", recordOpenMsgServiceQueryExpressMsg);
            return result;
        }
        /// <summary>
        /// 查询短信发送记录
        /// </summary>
        public async Task<RecordOpenMsgServiceQueryMsgResponseModel> RecordOpenMsgServiceQueryMsgAsync(RecordOpenMsgServiceQueryMsgRequestModel recordOpenMsgServiceQueryMsg)
        {
            var result = await PostAsync<RecordOpenMsgServiceQueryMsgRequestModel, RecordOpenMsgServiceQueryMsgResponseModel>("pdd.open.msg.service.query.msg.record", recordOpenMsgServiceQueryMsg);
            return result;
        }
        /// <summary>
        /// 短信批量发送接口
        /// </summary>
        public async Task<MsgOpenMsgServiceSendBatchResponseModel> MsgOpenMsgServiceSendBatchAsync(MsgOpenMsgServiceSendBatchRequestModel msgOpenMsgServiceSendBatch)
        {
            var result = await PostAsync<MsgOpenMsgServiceSendBatchRequestModel, MsgOpenMsgServiceSendBatchResponseModel>("pdd.open.msg.service.send.batch.msg", msgOpenMsgServiceSendBatch);
            return result;
        }
        /// <summary>
        /// 根据运单号发短信
        /// </summary>
        public async Task<MsgOpenMsgServiceSendExpressResponseModel> MsgOpenMsgServiceSendExpressAsync(MsgOpenMsgServiceSendExpressRequestModel msgOpenMsgServiceSendExpress)
        {
            var result = await PostAsync<MsgOpenMsgServiceSendExpressRequestModel, MsgOpenMsgServiceSendExpressResponseModel>("pdd.open.msg.service.send.express.msg", msgOpenMsgServiceSendExpress);
            return result;
        }
        /// <summary>
        /// 短信发送接口
        /// </summary>
        public async Task<MsgOpenMsgServiceSendResponseModel> MsgOpenMsgServiceSendAsync(MsgOpenMsgServiceSendRequestModel msgOpenMsgServiceSend)
        {
            var result = await PostAsync<MsgOpenMsgServiceSendRequestModel, MsgOpenMsgServiceSendResponseModel>("pdd.open.msg.service.send.msg", msgOpenMsgServiceSend);
            return result;
        }

    }
}
