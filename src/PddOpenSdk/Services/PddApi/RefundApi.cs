
using PddOpenSdk.Models.Request.Refund;
using PddOpenSdk.Models.Response.Refund;

namespace PddOpenSdk.Services.PddApi;
public class RefundApi : PddCommonApi
{
    public RefundApi() { }
    public RefundApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 退货入库
    /// </summary>
    public async Task<UpdateNextoneLogisticsWarehouseResponse> UpdateNextoneLogisticsWarehouseAsync(UpdateNextoneLogisticsWarehouse updateNextoneLogisticsWarehouse)
    {
        var result = await PostAsync<UpdateNextoneLogisticsWarehouse, UpdateNextoneLogisticsWarehouseResponse>("pdd.nextone.logistics.warehouse.update", updateNextoneLogisticsWarehouse);
        return result;
    }

    /// <summary>
    /// 取消发货
    /// </summary>
    public async Task<CancelRdcPddgeniusSendgoodsResponse> CancelRdcPddgeniusSendgoodsAsync(CancelRdcPddgeniusSendgoods cancelRdcPddgeniusSendgoods)
    {
        var result = await PostAsync<CancelRdcPddgeniusSendgoods, CancelRdcPddgeniusSendgoodsResponse>("pdd.rdc.pddgenius.sendgoods.cancel", cancelRdcPddgeniusSendgoods);
        return result;
    }

    /// <summary>
    /// 获取商家退货地址库
    /// </summary>
    public async Task<GetRefundAddressListResponse> GetRefundAddressListAsync(GetRefundAddressList getRefundAddressList)
    {
        var result = await PostAsync<GetRefundAddressList, GetRefundAddressListResponse>("pdd.refund.address.list.get", getRefundAddressList);
        return result;
    }

    /// <summary>
    /// 同意退款
    /// </summary>
    public async Task<AgreeRefundResponse> AgreeRefundAsync(AgreeRefund agreeRefund)
    {
        var result = await PostAsync<AgreeRefund, AgreeRefundResponse>("pdd.refund.agree", agreeRefund);
        return result;
    }

    /// <summary>
    /// 商家换货发货
    /// </summary>
    public async Task<ShippingRefundExchangeResponse> ShippingRefundExchangeAsync(ShippingRefundExchange shippingRefundExchange)
    {
        var result = await PostAsync<ShippingRefundExchange, ShippingRefundExchangeResponse>("pdd.refund.exchange.shipping", shippingRefundExchange);
        return result;
    }

    /// <summary>
    /// 售后单详情接口
    /// </summary>
    public async Task<GetRefundInformationResponse> GetRefundInformationAsync(GetRefundInformation getRefundInformation)
    {
        var result = await PostAsync<GetRefundInformation, GetRefundInformationResponse>("pdd.refund.information.get", getRefundInformation);
        return result;
    }

    /// <summary>
    /// 售后列表接口
    /// </summary>
    public async Task<GetRefundListIncrementResponse> GetRefundListIncrementAsync(GetRefundListIncrement getRefundListIncrement)
    {
        var result = await PostAsync<GetRefundListIncrement, GetRefundListIncrementResponse>("pdd.refund.list.increment.get", getRefundListIncrement);
        return result;
    }

    /// <summary>
    /// 商家售后同意退货
    /// </summary>
    public async Task<AgreeRefundReturngoodsResponse> AgreeRefundReturngoodsAsync(AgreeRefundReturngoods agreeRefundReturngoods)
    {
        var result = await PostAsync<AgreeRefundReturngoods, AgreeRefundReturngoodsResponse>("pdd.refund.returngoods.agree", agreeRefundReturngoods);
        return result;
    }

    /// <summary>
    /// 售后校验接口
    /// </summary>
    public async Task<CheckRefundStatusResponse> CheckRefundStatusAsync(CheckRefundStatus checkRefundStatus)
    {
        var result = await PostAsync<CheckRefundStatus, CheckRefundStatusResponse>("pdd.refund.status.check", checkRefundStatus);
        return result;
    }

}
