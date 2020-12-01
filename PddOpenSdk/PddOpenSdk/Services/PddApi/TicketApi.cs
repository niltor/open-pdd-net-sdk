
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Ticket;
using PddOpenSdk.Models.Response.Ticket;
namespace PddOpenSdk.Services.PddApi
{
    public class TicketApi : PddCommonApi
    {
        public TicketApi() { }
        public TicketApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 门票商品查询接口
        /// </summary>
        public async Task<QueryTicketGoodsResponseModel> QueryTicketGoodsAsync(QueryTicketGoodsRequestModel queryTicketGoods)
        {
            var result = await PostAsync<QueryTicketGoodsRequestModel, QueryTicketGoodsResponseModel>("pdd.ticket.goods.query", queryTicketGoods);
            return result;
        }
        /// <summary>
        /// 门票商品新建及更新接口
        /// </summary>
        public async Task<UploadTicketGoodsResponseModel> UploadTicketGoodsAsync(UploadTicketGoodsRequestModel uploadTicketGoods)
        {
            var result = await PostAsync<UploadTicketGoodsRequestModel, UploadTicketGoodsResponseModel>("pdd.ticket.goods.upload", uploadTicketGoods);
            return result;
        }
        /// <summary>
        /// 旅游门票订单创建异步回调接口
        /// </summary>
        public async Task<NotifycationTicketOrderCreateResponseModel> NotifycationTicketOrderCreateAsync(NotifycationTicketOrderCreateRequestModel notifycationTicketOrderCreate)
        {
            var result = await PostAsync<NotifycationTicketOrderCreateRequestModel, NotifycationTicketOrderCreateResponseModel>("pdd.ticket.order.create.notifycation", notifycationTicketOrderCreate);
            return result;
        }
        /// <summary>
        /// 旅游门票订单售后结果回调
        /// </summary>
        public async Task<NotifycationTicketOrderRefundResponseModel> NotifycationTicketOrderRefundAsync(NotifycationTicketOrderRefundRequestModel notifycationTicketOrderRefund)
        {
            var result = await PostAsync<NotifycationTicketOrderRefundRequestModel, NotifycationTicketOrderRefundResponseModel>("pdd.ticket.order.refund.notifycation", notifycationTicketOrderRefund);
            return result;
        }
        /// <summary>
        /// 旅游门票商品履约规则新增
        /// </summary>
        public async Task<AddTicketSkuRuleResponseModel> AddTicketSkuRuleAsync(AddTicketSkuRuleRequestModel addTicketSkuRule)
        {
            var result = await PostAsync<AddTicketSkuRuleRequestModel, AddTicketSkuRuleResponseModel>("pdd.ticket.sku.rule.add", addTicketSkuRule);
            return result;
        }
        /// <summary>
        /// 旅游门票商品履约规则修改
        /// </summary>
        public async Task<EditTicketSkuRuleResponseModel> EditTicketSkuRuleAsync(EditTicketSkuRuleRequestModel editTicketSkuRule)
        {
            var result = await PostAsync<EditTicketSkuRuleRequestModel, EditTicketSkuRuleResponseModel>("pdd.ticket.sku.rule.edit", editTicketSkuRule);
            return result;
        }
        /// <summary>
        /// 旅游门票商品履约生效规则查询
        /// </summary>
        public async Task<GetTicketSkuRuleResponseModel> GetTicketSkuRuleAsync(GetTicketSkuRuleRequestModel getTicketSkuRule)
        {
            var result = await PostAsync<GetTicketSkuRuleRequestModel, GetTicketSkuRuleResponseModel>("pdd.ticket.sku.rule.get", getTicketSkuRule);
            return result;
        }
        /// <summary>
        /// 旅游门票订单核销通知接口
        /// </summary>
        public async Task<NotifycationTicketVerificationResponseModel> NotifycationTicketVerificationAsync(NotifycationTicketVerificationRequestModel notifycationTicketVerification)
        {
            var result = await PostAsync<NotifycationTicketVerificationRequestModel, NotifycationTicketVerificationResponseModel>("pdd.ticket.verification.notifycation", notifycationTicketVerification);
            return result;
        }

    }
}
