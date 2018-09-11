using App.Models.PddApiResult;
using System.Threading.Tasks;
namespace App.Services.PddApiRequest
{
    public class InvoiceApiRequest : PddRequest {
        /// <summary>
/// 开票申请单查询
/// </summary>
/// <param name="ApplicationId">申请流水号</param>
/// <param name="OrderSn">订单号；订单号和申请时间必填其一</param>
/// <param name="Status">申请状态：0-已拒绝，1-申请中，2-已同意</param>
/// <param name="UpdateStartTime">申请开始时间, 时间戳（毫秒）</param>
/// <param name="UpdateEndTime">申请结束时间, 时间戳（毫秒）</param>
/// <param name="Page">页码，默认1</param>
/// <param name="PageSize">每页返回数目，默认50</param>
public async Task<QueryInvoiceApplicationApiResult> QueryInvoiceApplicationAsync(number ApplicationId,string OrderSn,number Status,number UpdateStartTime,number UpdateEndTime,number Page,number PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("application_id",Application Id);
dic.Add("order_sn",Order Sn);
dic.Add("status",Status);
dic.Add("update_start_time",Update Start Time);
dic.Add("update_end_time",Update End Time);
dic.Add("page",Page);
dic.Add("page_size",Page Size);
    
    var result = Post<QueryInvoiceApplicationApiResult>(pdd.invoice.application.query,);
    return JsonConvert.DeserializeObject<QueryInvoiceApplicationApiResult>(result);
}/// <summary>
/// 开票申请单审核
/// </summary>
/// <param name="ApplicationId">申请流水号</param>
/// <param name="OrderSn">订单号</param>
/// <param name="Status">审核结果：0 = 拒绝，2 = 同意</param>
/// <param name="Reason">驳回原因，status=0必填</param>
public async Task<UpdateInvoiceApplicationApiResult> UpdateInvoiceApplicationAsync(number ApplicationId,string OrderSn,number Status,string Reason)
{
    var dic = new Dictionary<string, string>();
    dic.Add("application_id",Application Id);
dic.Add("order_sn",Order Sn);
dic.Add("status",Status);
dic.Add("reason",Reason);
    
    var result = Post<UpdateInvoiceApplicationApiResult>(pdd.invoice.application.update,);
    return JsonConvert.DeserializeObject<UpdateInvoiceApplicationApiResult>(result);
}/// <summary>
/// 查询已回传发票
/// </summary>
/// <param name="OrderSn">订单号</param>
/// <param name="SerialNo">发票流水号</param>
public async Task<QueryInvoiceDetailApiResult> QueryInvoiceDetailAsync(string OrderSn,string SerialNo)
{
    var dic = new Dictionary<string, string>();
    dic.Add("order_sn",Order Sn);
dic.Add("serial_no",Serial No);
    
    var result = Post<QueryInvoiceDetailApiResult>(pdd.invoice.detail.query,);
    return JsonConvert.DeserializeObject<QueryInvoiceDetailApiResult>(result);
}/// <summary>
/// 开票结果回传
/// </summary>
/// <param name="PayerName">发票抬头</param>
/// <param name="OrderSn">订单号</param>
/// <param name="ApplicationId">申请流水号</param>
/// <param name="BusinessType">抬头类型：0-个人，1-企业</param>
/// <param name="InvoiceKind">发票种类：0-电子发票，1-纸质发票，2-专票；目前只支持0</param>
/// <param name="InvoiceType">开票类型：0-蓝票，1-红票；目前 只支持0</param>
/// <param name="InvoiceAmount">开票金额</param>
/// <param name="SumPrice">不含税金额</param>
/// <param name="PayerRegisterNo">税号，企业必填</param>
/// <param name="TaxRate">税率,整数</param>
/// <param name="SumTax">总税额</param>
/// <param name="InvoiceCode">发票代码</param>
/// <param name="InvoiceNo">发票号码</param>
/// <param name="PayeeOperator">开票人</param>
/// <param name="InvoiceTime">开票日期,时间戳（毫秒）</param>
/// <param name="InvoiceFileContent">发票内容，pdf文件，转码base64编码</param>
/// <param name="OriginalInvoiceCode">原蓝票代码（红票必填）</param>
/// <param name="OriginalInvoiceNo">原蓝票号码（红票必填）</param>
/// <param name="Memo">备注</param>
public async Task<UploadInvoiceDetailApiResult> UploadInvoiceDetailAsync(string PayerName,string OrderSn,number ApplicationId,number BusinessType,number InvoiceKind,number InvoiceType,number InvoiceAmount,number SumPrice,string PayerRegisterNo,string TaxRate,string SumTax,string InvoiceCode,string InvoiceNo,string PayeeOperator,number InvoiceTime,string InvoiceFileContent,string OriginalInvoiceCode,string OriginalInvoiceNo,string Memo)
{
    var dic = new Dictionary<string, string>();
    dic.Add("payer_name",Payer Name);
dic.Add("order_sn",Order Sn);
dic.Add("application_id",Application Id);
dic.Add("business_type",Business Type);
dic.Add("invoice_kind",Invoice Kind);
dic.Add("invoice_type",Invoice Type);
dic.Add("invoice_amount",Invoice Amount);
dic.Add("sum_price",Sum Price);
dic.Add("payer_register_no",Payer Register No);
dic.Add("tax_rate",Tax Rate);
dic.Add("sum_tax",Sum Tax);
dic.Add("invoice_code",Invoice Code);
dic.Add("invoice_no",Invoice No);
dic.Add("payee_operator",Payee Operator);
dic.Add("invoice_time",Invoice Time);
dic.Add("invoice_file_content",Invoice File Content);
dic.Add("original_invoice_code",Original Invoice Code);
dic.Add("original_invoice_no",Original Invoice No);
dic.Add("memo",Memo);
    
    var result = Post<UploadInvoiceDetailApiResult>(pdd.invoice.detail.upload,);
    return JsonConvert.DeserializeObject<UploadInvoiceDetailApiResult>(result);
}
    }
}
