
using PddOpenSdk.Models.Request.Ticket;
using PddOpenSdk.Models.Response.Ticket;

namespace PddOpenSdk.Services.PddApi;
public class TicketApi : PddCommonApi
{
    public TicketApi() { }
    public TicketApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 旅游门票区域编码查询
    /// </summary>
    public async Task<GetTicketAreacodeResponse> GetTicketAreacodeAsync(GetTicketAreacode getTicketAreacode)
    {
        var result = await PostAsync<GetTicketAreacode, GetTicketAreacodeResponse>("pdd.ticket.areacode.get", getTicketAreacode);
        return result;
    }

    /// <summary>
    /// 门票商品查询接口
    /// </summary>
    public async Task<QueryTicketGoodsResponse> QueryTicketGoodsAsync(QueryTicketGoods queryTicketGoods)
    {
        var result = await PostAsync<QueryTicketGoods, QueryTicketGoodsResponse>("pdd.ticket.goods.query", queryTicketGoods);
        return result;
    }

    /// <summary>
    /// 门票商品新建及更新接口
    /// </summary>
    public async Task<UploadTicketGoodsResponse> UploadTicketGoodsAsync(UploadTicketGoods uploadTicketGoods)
    {
        var result = await PostAsync<UploadTicketGoods, UploadTicketGoodsResponse>("pdd.ticket.goods.upload", uploadTicketGoods);
        return result;
    }

    /// <summary>
    /// 旅游门票订单创建异步回调接口
    /// </summary>
    public async Task<NotifycationTicketOrderCreateResponse> NotifycationTicketOrderCreateAsync(NotifycationTicketOrderCreate notifycationTicketOrderCreate)
    {
        var result = await PostAsync<NotifycationTicketOrderCreate, NotifycationTicketOrderCreateResponse>("pdd.ticket.order.create.notifycation", notifycationTicketOrderCreate);
        return result;
    }

    /// <summary>
    /// 旅游门票订单售后结果回调
    /// </summary>
    public async Task<NotifycationTicketOrderRefundResponse> NotifycationTicketOrderRefundAsync(NotifycationTicketOrderRefund notifycationTicketOrderRefund)
    {
        var result = await PostAsync<NotifycationTicketOrderRefund, NotifycationTicketOrderRefundResponse>("pdd.ticket.order.refund.notifycation", notifycationTicketOrderRefund);
        return result;
    }

    /// <summary>
    /// 旅游门票拼多多景区编码查询
    /// </summary>
    public async Task<GetTicketScenicResponse> GetTicketScenicAsync(GetTicketScenic getTicketScenic)
    {
        var result = await PostAsync<GetTicketScenic, GetTicketScenicResponse>("pdd.ticket.scenic.get", getTicketScenic);
        return result;
    }

    /// <summary>
    /// 旅游门票商品履约规则新增
    /// </summary>
    public async Task<AddTicketSkuRuleResponse> AddTicketSkuRuleAsync(AddTicketSkuRule addTicketSkuRule)
    {
        var result = await PostAsync<AddTicketSkuRule, AddTicketSkuRuleResponse>("pdd.ticket.sku.rule.add", addTicketSkuRule);
        return result;
    }

    /// <summary>
    /// 旅游门票商品履约规则修改
    /// </summary>
    public async Task<EditTicketSkuRuleResponse> EditTicketSkuRuleAsync(EditTicketSkuRule editTicketSkuRule)
    {
        var result = await PostAsync<EditTicketSkuRule, EditTicketSkuRuleResponse>("pdd.ticket.sku.rule.edit", editTicketSkuRule);
        return result;
    }

    /// <summary>
    /// 旅游门票商品履约生效规则查询
    /// </summary>
    public async Task<GetTicketSkuRuleResponse> GetTicketSkuRuleAsync(GetTicketSkuRule getTicketSkuRule)
    {
        var result = await PostAsync<GetTicketSkuRule, GetTicketSkuRuleResponse>("pdd.ticket.sku.rule.get", getTicketSkuRule);
        return result;
    }

    /// <summary>
    /// 旅游门票订单核销通知接口
    /// </summary>
    public async Task<NotifycationTicketVerificationResponse> NotifycationTicketVerificationAsync(NotifycationTicketVerification notifycationTicketVerification)
    {
        var result = await PostAsync<NotifycationTicketVerification, NotifycationTicketVerificationResponse>("pdd.ticket.verification.notifycation", notifycationTicketVerification);
        return result;
    }

}
