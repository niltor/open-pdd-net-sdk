using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Invoice
{
public partial class QueryInvoiceApplicationResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("invoice_application_query_response")]
public InvoiceApplicationQueryResponseResponseModel InvoiceApplicationQueryResponse {get;set;}
public partial class InvoiceApplicationQueryResponseResponseModel : PddResponseModel
{
/// <summary>
/// 发票申请列表
/// </summary>
[JsonProperty("invoice_application_list")]
public List<InvoiceApplicationListResponseModel> InvoiceApplicationList {get;set;}
public partial class InvoiceApplicationListResponseModel : PddResponseModel
{
/// <summary>
/// 申请状态：0-已拒绝，1-申请中，2-已同意
/// </summary>
[JsonProperty("application_status")]
public int? ApplicationStatus {get;set;}
/// <summary>
/// 申请时间
/// </summary>
[JsonProperty("apply_time")]
public int? ApplyTime {get;set;}
/// <summary>
/// 抬头类型：0-个人，1-企业
/// </summary>
[JsonProperty("business_type")]
public int? BusinessType {get;set;}
/// <summary>
/// 开票金额，暂为null，取买家实付
/// </summary>
[JsonProperty("invoice_amount")]
public string InvoiceAmount {get;set;}
/// <summary>
/// 发票种类：0-电子，1-纸质，2-专票；目前只支持0
/// </summary>
[JsonProperty("invoice_kind")]
public int? InvoiceKind {get;set;}
/// <summary>
/// 发票类型：0-蓝票，1-红票；目前只支持0
/// </summary>
[JsonProperty("invoice_type")]
public int? InvoiceType {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}
/// <summary>
/// 备注
/// </summary>
[JsonProperty("memo")]
public string Memo {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// （企业抬头）开户账号
/// </summary>
[JsonProperty("payer_account")]
public string PayerAccount {get;set;}
/// <summary>
/// （企业抬头）地址
/// </summary>
[JsonProperty("payer_address")]
public string PayerAddress {get;set;}
/// <summary>
/// （企业抬头）开户银行
/// </summary>
[JsonProperty("payer_bank")]
public string PayerBank {get;set;}
/// <summary>
/// 发票抬头
/// </summary>
[JsonProperty("payer_name")]
public string PayerName {get;set;}
/// <summary>
/// （企业抬头）电话
/// </summary>
[JsonProperty("payer_phone")]
public string PayerPhone {get;set;}
/// <summary>
/// 企业税号，抬头为企业类型必填
/// </summary>
[JsonProperty("payer_register_no")]
public string PayerRegisterNo {get;set;}
/// <summary>
/// 是否正品发票：0=非正品发票，1=非正品发票
/// </summary>
[JsonProperty("quality_goods_invoice")]
public int? QualityGoodsInvoice {get;set;}
/// <summary>
/// 驳回原因
/// </summary>
[JsonProperty("reason")]
public string Reason {get;set;}
/// <summary>
/// 不含税金额，暂为null
/// </summary>
[JsonProperty("sum_price")]
public string SumPrice {get;set;}
/// <summary>
/// 总税额，暂为null
/// </summary>
[JsonProperty("sum_tax")]
public string SumTax {get;set;}
/// <summary>
/// 税率，暂为null
/// </summary>
[JsonProperty("tax_rate")]
public string TaxRate {get;set;}
/// <summary>
/// 开票申请触发类型：1-申请开票，2-改抬头
/// </summary>
[JsonProperty("trigger_status")]
public int? TriggerStatus {get;set;}

}

}

}

}
