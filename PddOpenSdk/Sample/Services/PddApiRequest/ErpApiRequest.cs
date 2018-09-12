using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class ErpApiRequest : PddRequest {
        /// <summary>
/// erp打单信息同步
/// </summary>
/// <param name="OrderSn">订单号</param>
/// <param name="OrderState">订单状态：1-已打单</param>
/// <param name="WaybillNo">运单号</param>
/// <param name="LogisticsId">物流公司编码</param>
public async Task<SyncErpOrderApiResult> SyncErpOrderAsync(string OrderSn,integer OrderState,string WaybillNo,integer LogisticsId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("order_sn",OrderSn);
dic.Add("order_state",OrderState);
dic.Add("waybill_no",WaybillNo);
dic.Add("logistics_id",LogisticsId);
    
    var result = await PostAsync<SyncErpOrderApiResult>("pdd.erp.order.sync",dic);
    return result;
}/// <summary>
/// 订单详情
/// </summary>
/// <param name="Type">该值为：pdd.order.information.get</param>
/// <param name="OrderSn">订单号</param>
public async Task<GetOrderInformationApiResult> GetOrderInformationAsync(string Type,string OrderSn)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("order_sn",OrderSn);
    
    var result = await PostAsync<GetOrderInformationApiResult>("pdd.order.information.get",dic);
    return result;
}/// <summary>
/// 订单列表查询接口（根据成团时间）
/// </summary>
/// <param name="OrderStatus">发货状态，1：待发货，2：已发货待签收，3：已签收 5：全部</param>
/// <param name="RefundStatus">售后状态 1：无售后或售后关闭，2：售后处理中，3：退款中，4： 退款成功 5：全部</param>
/// <param name="StartConfirmAt">必填，成团时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数</param>
/// <param name="EndConfirmAt">必填，成团时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过  24 小时</param>
/// <param name="Page">返回页码 默认 1，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值</param>
/// <param name="PageSize">返回数量，默认 100。最大 100</param>
public async Task<GetOrderListApiResult> GetOrderListAsync(int OrderStatus,int RefundStatus,int StartConfirmAt,int EndConfirmAt,int Page,int PageSize)
{
    var dic = new Dictionary<string, object>();
    dic.Add("order_status",OrderStatus);
dic.Add("refund_status",RefundStatus);
dic.Add("start_confirm_at",StartConfirmAt);
dic.Add("end_confirm_at",EndConfirmAt);
dic.Add("page",Page);
dic.Add("page_size",PageSize);
    
    var result = await PostAsync<GetOrderListApiResult>("pdd.order.list.get",dic);
    return result;
}/// <summary>
/// 订单全量列表
/// </summary>
/// <param name="Type">该值为：pdd.order.number.list.get</param>
/// <param name="OrderStatus">发货状态，1：待发货  2：已发货待签收  3：已签收 5：全部 暂时只开放待发货订单查询</param>
/// <param name="PageSize">返回数量，默认100。最大100</param>
/// <param name="Page">返回页码 默认1，页码从1开始; PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用默认值</param>
public async Task<GetOrderNumberListApiResult> GetOrderNumberListAsync(string Type,int OrderStatus,int PageSize,int Page)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("order_status",OrderStatus);
dic.Add("page_size",PageSize);
dic.Add("page",Page);
    
    var result = await PostAsync<GetOrderNumberListApiResult>("pdd.order.number.list.get",dic);
    return result;
}/// <summary>
/// 订单增量接口
/// </summary>
/// <param name="Type">该值为：pdd.order.number.list.increment.get</param>
/// <param name="IsLuckyFlag">订单类型（是否抽奖订单），0-全部，1-非抽奖订单，2-抽奖订单</param>
/// <param name="OrderStatus">发货状态，1-待发货，2-已发货待签收，3-已签收，5-全部</param>
/// <param name="StartUpdatedAt">必填，最后更新时间开始时间的时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数</param>
/// <param name="EndUpdatedAt">必填，最后更新时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时; 00 分 00 秒)起至现在的总秒数; PS：开始时间结束时间间距不超过 30 分钟</param>
/// <param name="Page">返回页码，默认 1，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值</param>
/// <param name="RefundStatus">售后状态，1-无售后或售后关闭，2-售后处理中，3-退款中，4-退款成功 5-全部</param>
/// <param name="PageSize">返回数量，默认 100。最大 100</param>
public async Task<GetOrderNumberListIncrementApiResult> GetOrderNumberListIncrementAsync(string Type,string IsLuckyFlag,int OrderStatus,string StartUpdatedAt,string EndUpdatedAt,int Page,string RefundStatus,int PageSize)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("is_lucky_flag",IsLuckyFlag);
dic.Add("order_status",OrderStatus);
dic.Add("start_updated_at",StartUpdatedAt);
dic.Add("end_updated_at",EndUpdatedAt);
dic.Add("page",Page);
dic.Add("refund_status",RefundStatus);
dic.Add("page_size",PageSize);
    
    var result = await PostAsync<GetOrderNumberListIncrementApiResult>("pdd.order.number.list.increment.get",dic);
    return result;
}/// <summary>
/// 订单状态
/// </summary>
/// <param name="Type">该值为：pdd.order.status.get</param>
/// <param name="OrderSns">20150909-452750051,20150909-452750134 用逗号分开</param>
public async Task<GetOrderStatusApiResult> GetOrderStatusAsync(string Type,string OrderSns)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("order_sns",OrderSns);
    
    var result = await PostAsync<GetOrderStatusApiResult>("pdd.order.status.get",dic);
    return result;
}
    }
}
