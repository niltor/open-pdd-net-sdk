using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Voucher
{
public partial class VerificationVoucherOtaCardPrepareResponseModel : PddResponseModel
{
/// <summary>
/// 响应体
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("errorCode")]
public int? ErrorCode {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("errorMsg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 卡密和订单信息
/// </summary>
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 卡券信息
/// </summary>
[JsonProperty("card_vo")]
public CardVoResponseModel CardVo {get;set;}
/// <summary>
/// 商品信息
/// </summary>
[JsonProperty("order_goods_vo")]
public OrderGoodsVoResponseModel OrderGoodsVo {get;set;}
/// <summary>
/// 订单信息
/// </summary>
[JsonProperty("order_vo")]
public OrderVoResponseModel OrderVo {get;set;}
public partial class CardVoResponseModel : PddResponseModel
{
/// <summary>
/// 卡券有效期结束时间，单位秒
/// </summary>
[JsonProperty("available_end_time")]
public long? AvailableEndTime {get;set;}
/// <summary>
/// 卡券有效期开始时间，单位秒
/// </summary>
[JsonProperty("available_start_time")]
public long? AvailableStartTime {get;set;}
/// <summary>
/// 打码卡密
/// </summary>
[JsonProperty("mask_card_no")]
public string MaskCardNo {get;set;}
/// <summary>
/// 剩余可用次数
/// </summary>
[JsonProperty("remain_times")]
public int? RemainTimes {get;set;}
/// <summary>
/// 券状态码。1-未核销，2-已核销， 3-已过期，4-已销毁
/// </summary>
[JsonProperty("status")]
public int? Status {get;set;}
/// <summary>
/// 状态文案
/// </summary>
[JsonProperty("status_tips")]
public string StatusTips {get;set;}
/// <summary>
/// 总次数
/// </summary>
[JsonProperty("total_times")]
public int? TotalTimes {get;set;}

}
public partial class OrderGoodsVoResponseModel : PddResponseModel
{
/// <summary>
/// 商品标题
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 购买商品数
/// </summary>
[JsonProperty("goods_number")]
public int? GoodsNumber {get;set;}
/// <summary>
/// 外部商品编码
/// </summary>
[JsonProperty("out_goods_sn")]
public string OutGoodsSn {get;set;}
/// <summary>
/// 外部sku编码
/// </summary>
[JsonProperty("out_sku_sn")]
public string OutSkuSn {get;set;}
/// <summary>
/// 规格
/// </summary>
[JsonProperty("spec")]
public string Spec {get;set;}

}
public partial class OrderVoResponseModel : PddResponseModel
{
/// <summary>
/// 用户实付金额
/// </summary>
[JsonProperty("order_amount_fen")]
public long? OrderAmountFen {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}

}

}

}
