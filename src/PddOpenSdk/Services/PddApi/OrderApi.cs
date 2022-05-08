
using PddOpenSdk.Models.Request.Order;
using PddOpenSdk.Models.Response.Order;
namespace PddOpenSdk.Services.PddApi;
public class OrderApi : PddCommonApi
{
    public OrderApi() { }
    public OrderApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// erp打单信息同步
    /// </summary>
    public async Task<SyncErpOrderResponse> SyncErpOrderAsync(SyncErpOrder syncErpOrder)
    {
        var result = await PostAsync<SyncErpOrder, SyncErpOrderResponse>("pdd.erp.order.sync", syncErpOrder);
        return result;
    }

    /// <summary>
    /// 订单基础信息列表查询接口（根据成交时间）
    /// </summary>
    public async Task<GetOrderBasicListResponse> GetOrderBasicListAsync(GetOrderBasicList getOrderBasicList)
    {
        var result = await PostAsync<GetOrderBasicList, GetOrderBasicListResponse>("pdd.order.basic.list.get", getOrderBasicList);
        return result;
    }

    /// <summary>
    /// 订单详情
    /// </summary>
    public async Task<GetOrderInformationResponse> GetOrderInformationAsync(GetOrderInformation getOrderInformation)
    {
        var result = await PostAsync<GetOrderInformation, GetOrderInformationResponse>("pdd.order.information.get", getOrderInformation);
        return result;
    }

    /// <summary>
    /// 订单列表查询接口（根据成交时间）
    /// </summary>
    public async Task<GetOrderListResponse> GetOrderListAsync(GetOrderList getOrderList)
    {
        var result = await PostAsync<GetOrderList, GetOrderListResponse>("pdd.order.list.get", getOrderList);
        return result;
    }

    /// <summary>
    /// 编辑商家订单备注
    /// </summary>
    public async Task<UpdateOrderNoteResponse> UpdateOrderNoteAsync(UpdateOrderNote updateOrderNote)
    {
        var result = await PostAsync<UpdateOrderNote, UpdateOrderNoteResponse>("pdd.order.note.update", updateOrderNote);
        return result;
    }

    /// <summary>
    /// 订单增量接口
    /// </summary>
    public async Task<GetOrderNumberListIncrementResponse> GetOrderNumberListIncrementAsync(GetOrderNumberListIncrement getOrderNumberListIncrement)
    {
        var result = await PostAsync<GetOrderNumberListIncrement, GetOrderNumberListIncrementResponse>("pdd.order.number.list.increment.get", getOrderNumberListIncrement);
        return result;
    }

    /// <summary>
    /// 查询订单承诺信息
    /// </summary>
    public async Task<GetOrderPromiseInfoResponse> GetOrderPromiseInfoAsync(GetOrderPromiseInfo getOrderPromiseInfo)
    {
        var result = await PostAsync<GetOrderPromiseInfo, GetOrderPromiseInfoResponse>("pdd.order.promise.info.get", getOrderPromiseInfo);
        return result;
    }

    /// <summary>
    /// 订单状态
    /// </summary>
    public async Task<GetOrderStatusResponse> GetOrderStatusAsync(GetOrderStatus getOrderStatus)
    {
        var result = await PostAsync<GetOrderStatus, GetOrderStatusResponse>("pdd.order.status.get", getOrderStatus);
        return result;
    }

    /// <summary>
    /// 修改订单收件地址接口
    /// </summary>
    public async Task<AddressOrderUpdateResponse> AddressOrderUpdateAsync(AddressOrderUpdate addressOrderUpdate)
    {
        var result = await PostAsync<AddressOrderUpdate, AddressOrderUpdateResponse>("pdd.order.update.address", addressOrderUpdate);
        return result;
    }

    /// <summary>
    /// 订单额外运单信息上传
    /// </summary>
    public async Task<LogisticsOrderUploadExtraResponse> LogisticsOrderUploadExtraAsync(LogisticsOrderUploadExtra logisticsOrderUploadExtra)
    {
        var result = await PostAsync<LogisticsOrderUploadExtra, LogisticsOrderUploadExtraResponse>("pdd.order.upload.extra.logistics", logisticsOrderUploadExtra);
        return result;
    }

    /// <summary>
    /// 订单关联运单信息上传
    /// </summary>
    public async Task<LogisticsOrderUploadRelationResponse> LogisticsOrderUploadRelationAsync(LogisticsOrderUploadRelation logisticsOrderUploadRelation)
    {
        var result = await PostAsync<LogisticsOrderUploadRelation, LogisticsOrderUploadRelationResponse>("pdd.order.upload.relation.logistics", logisticsOrderUploadRelation);
        return result;
    }

    /// <summary>
    /// 虚拟业务信息查询接口
    /// </summary>
    public async Task<GetOrderVirtualInformationResponse> GetOrderVirtualInformationAsync(GetOrderVirtualInformation getOrderVirtualInformation)
    {
        var result = await PostAsync<GetOrderVirtualInformation, GetOrderVirtualInformationResponse>("pdd.order.virtual.information.get", getOrderVirtualInformation);
        return result;
    }

}
