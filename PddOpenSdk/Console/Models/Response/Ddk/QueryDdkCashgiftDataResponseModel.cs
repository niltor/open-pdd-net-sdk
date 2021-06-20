using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
public partial class QueryDdkCashgiftDataResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("cashgift_data_response")]
public CashgiftDataResponseResponseModel CashgiftDataResponse {get;set;}
public partial class CashgiftDataResponseResponseModel : PddResponseModel
{
/// <summary>
/// 多多礼金数据列表
/// </summary>
[JsonProperty("list")]
public List<ListResponseModel> List {get;set;}
/// <summary>
/// 请求到的结果数
/// </summary>
[JsonProperty("total")]
public int? Total {get;set;}
public partial class ListResponseModel : PddResponseModel
{
/// <summary>
/// 礼金券创建总金额，单位为分
/// </summary>
[JsonProperty("amount")]
public long? Amount {get;set;}
/// <summary>
/// 礼金ID
/// </summary>
[JsonProperty("cash_gift_id")]
public long? CashGiftId {get;set;}
/// <summary>
/// 礼金名称
/// </summary>
[JsonProperty("cash_gift_name")]
public string CashGiftName {get;set;}
/// <summary>
/// 礼金券面额
/// </summary>
[JsonProperty("couponAmount")]
public int? CouponAmount {get;set;}
/// <summary>
/// 已领取礼金券总金额，单位为分（实时数据）
/// </summary>
[JsonProperty("fetch_amount")]
public long? FetchAmount {get;set;}
/// <summary>
/// 已领取礼金券数量（实时数据）
/// </summary>
[JsonProperty("fetch_quantity")]
public int? FetchQuantity {get;set;}
/// <summary>
/// 商品信息
/// </summary>
[JsonProperty("goods_info")]
public GoodsInfoResponseModel GoodsInfo {get;set;}
/// <summary>
/// 礼金订单使用的券总金额，单位为分（实时数据）
/// </summary>
[JsonProperty("order_coupon_amount")]
public long? OrderCouponAmount {get;set;}
/// <summary>
/// 礼金订单产生的总GMV，单位为分（实时数据）
/// </summary>
[JsonProperty("order_gmv")]
public long? OrderGmv {get;set;}
/// <summary>
/// 礼金订单数量（实时数据）
/// </summary>
[JsonProperty("order_quantity")]
public int? OrderQuantity {get;set;}
/// <summary>
/// 礼金订单预估佣金，单位为分（实时数据）
/// </summary>
[JsonProperty("pre_promotion_amount")]
public long? PrePromotionAmount {get;set;}
/// <summary>
/// 礼金券创建总数量
/// </summary>
[JsonProperty("quantity")]
public int? Quantity {get;set;}
/// <summary>
/// 退回礼金券总金额，单位为分
/// </summary>
[JsonProperty("refund_amount")]
public long? RefundAmount {get;set;}
/// <summary>
/// 退回礼金券数量
/// </summary>
[JsonProperty("refund_quantity")]
public int? RefundQuantity {get;set;}
/// <summary>
/// 礼金状态：1-未生效；2-生效中；3-已过期；4-活动中止（用户主动停止）；5-活动中止（佣金降低）；6-活动中止（推广活动异常）
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
public partial class GoodsInfoResponseModel : PddResponseModel
{
/// <summary>
/// 商品优惠券面额，单位为分
/// </summary>
[JsonProperty("coupon_discount")]
public long? CouponDiscount {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 商品原价，单位为分
/// </summary>
[JsonProperty("goods_price")]
public long? GoodsPrice {get;set;}
/// <summary>
/// 商品佣金比例，千分比
/// </summary>
[JsonProperty("rate")]
public int? Rate {get;set;}
/// <summary>
/// 招商团长duoid
/// </summary>
[JsonProperty("zs_duo_id")]
public long? ZsDuoId {get;set;}

}

}

}

}

}
