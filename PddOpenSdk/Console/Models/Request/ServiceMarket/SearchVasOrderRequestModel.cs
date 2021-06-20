using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.ServiceMarket
{
public partial class SearchVasOrderRequestModel : PddRequestModel
{
/// <summary>
/// 创建时间结束，UNIX时间戳（ms 级别），默认为当前时间，支持最大范围为7天。
/// </summary>
[JsonProperty("create_time_end")]
public long? CreateTimeEnd {get;set;}
/// <summary>
/// 创建时间开始，UNIX时间戳（ms级别），默认为当前时间往前推7天，支持最大范围为7天。
/// </summary>
[JsonProperty("create_time_start")]
public long? CreateTimeStart {get;set;}
/// <summary>
/// 买家店铺id
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}
/// <summary>
/// 服务订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 订单状态，枚举值，0-未完成，1-已完成，2-已取消，空-全部
/// </summary>
[JsonProperty("order_status")]
public int? OrderStatus {get;set;}
/// <summary>
/// 分页页码
/// </summary>
[JsonProperty("page")]
public int Page {get;set;}
/// <summary>
/// 分页大小，最大支持100
/// </summary>
[JsonProperty("page_size")]
public int PageSize {get;set;}
/// <summary>
/// 支付时间开始，UNIX时间戳（ms 级别）
/// </summary>
[JsonProperty("pay_time_end")]
public long? PayTimeEnd {get;set;}
/// <summary>
/// 支付时间开始，UNIX时间戳（ms 级别）
/// </summary>
[JsonProperty("pay_time_start")]
public long? PayTimeStart {get;set;}
/// <summary>
/// 服务sku_id，可在服务详情页中获取
/// </summary>
[JsonProperty("sku_id")]
public long? SkuId {get;set;}
/// <summary>
/// 售后状态，0-未售后，1-已售后
/// </summary>
[JsonProperty("refund_status")]
public int? RefundStatus {get;set;}

}

}
