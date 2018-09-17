using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class UploadInvoiceDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonProperty("payer_name")]
        public object PayerName { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public object OrderSn { get; set; }
        /// <summary>
        /// 申请流水号
        /// </summary>
        [JsonProperty("application_id")]
        public int ApplicationId { get; set; }
        /// <summary>
        /// 抬头类型：0-个人，1-企业
        /// </summary>
        [JsonProperty("business_type")]
        public int BusinessType { get; set; }
        /// <summary>
        /// 发票种类：0-电子发票，1-纸质发票，2-专票；目前只支持0
        /// </summary>
        [JsonProperty("invoice_kind")]
        public int InvoiceKind { get; set; }
        /// <summary>
        /// 开票类型：0-蓝票，1-红票；目前 只支持0
        /// </summary>
        [JsonProperty("invoice_type")]
        public int InvoiceType { get; set; }
        /// <summary>
        /// 开票金额
        /// </summary>
        [JsonProperty("invoice_amount")]
        public int InvoiceAmount { get; set; }
        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonProperty("sum_price")]
        public int SumPrice { get; set; }
        /// <summary>
        /// 税号，企业必填
        /// </summary>
        [JsonProperty("payer_register_no")]
        public object PayerRegisterNo { get; set; }
        /// <summary>
        /// 税率,整数
        /// </summary>
        [JsonProperty("tax_rate")]
        public object TaxRate { get; set; }
        /// <summary>
        /// 总税额
        /// </summary>
        [JsonProperty("sum_tax")]
        public object SumTax { get; set; }
        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("invoice_code")]
        public object InvoiceCode { get; set; }
        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("invoice_no")]
        public object InvoiceNo { get; set; }
        /// <summary>
        /// 原蓝票代码（红票必填）
        /// </summary>
        [JsonProperty("original_invoice_code")]
        public object OriginalInvoiceCode { get; set; }
        /// <summary>
        /// 原蓝票号码（红票必填）
        /// </summary>
        [JsonProperty("original_invoice_no")]
        public object OriginalInvoiceNo { get; set; }
        /// <summary>
        /// 开票人
        /// </summary>
        [JsonProperty("payee_operator")]
        public object PayeeOperator { get; set; }
        /// <summary>
        /// 开票日期,时间戳（毫秒）
        /// </summary>
        [JsonProperty("invoice_time")]
        public int InvoiceTime { get; set; }
        /// <summary>
        /// 发票内容，pdf文件，转码base64编码
        /// </summary>
        [JsonProperty("invoice_file_content")]
        public object InvoiceFileContent { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public object Memo { get; set; }

    }
}
