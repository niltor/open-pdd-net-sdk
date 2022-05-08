namespace PddOpenSdk.Models.Request.Invoice;
public partial class UploadInvoiceDetail
{

    /// <summary>
    /// 申请流水号
    /// </summary>
    [JsonPropertyName("application_id")]
    public long? ApplicationId { get; set; }

    /// <summary>
    /// 抬头类型：0-个人，1-企业
    /// </summary>
    [JsonPropertyName("business_type")]
    public int BusinessType { get; set; }

    /// <summary>
    /// 开票金额，整数，单位：分
    /// </summary>
    [JsonPropertyName("invoice_amount")]
    public long? InvoiceAmount { get; set; }

    /// <summary>
    /// 发票代码
    /// </summary>
    [JsonPropertyName("invoice_code")]
    public string InvoiceCode { get; set; }

    /// <summary>
    /// 发票内容，pdf文件(电票回传)，图片文件(专票回传)，转码base64编码
    /// </summary>
    [JsonPropertyName("invoice_file_content")]
    public string InvoiceFileContent { get; set; }

    /// <summary>
    /// 多张发票列表（如果本字段为空，invoice_code、invoice_no、invoice_amount、invoice_file_content这四个字段必须填写）
    /// </summary>
    [JsonPropertyName("invoice_item_list")]
    public List<InvoiceItemListModel> InvoiceItemList { get; set; }

    /// <summary>
    /// 发票种类：0-电子发票，1-纸质发票，2-专票；目前只支持0
    /// </summary>
    [JsonPropertyName("invoice_kind")]
    public int InvoiceKind { get; set; }

    /// <summary>
    /// 发票号码
    /// </summary>
    [JsonPropertyName("invoice_no")]
    public string InvoiceNo { get; set; }

    /// <summary>
    /// 开票日期,时间戳（毫秒）
    /// </summary>
    [JsonPropertyName("invoice_time")]
    public long InvoiceTime { get; set; }

    /// <summary>
    /// 开票类型：0-蓝票，1-红票；目前 只支持0
    /// </summary>
    [JsonPropertyName("invoice_type")]
    public int InvoiceType { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    [JsonPropertyName("memo")]
    public string Memo { get; set; }

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 原蓝票代码（红票必填）
    /// </summary>
    [JsonPropertyName("original_invoice_code")]
    public string OriginalInvoiceCode { get; set; }

    /// <summary>
    /// 原蓝票号码（红票必填）
    /// </summary>
    [JsonPropertyName("original_invoice_no")]
    public string OriginalInvoiceNo { get; set; }

    /// <summary>
    /// 专票回传必填，专票邮寄快递公司编码，见https://open.pinduoduo.com/application/document/api?id=pdd.logistics.companies.get返回的快递公司编码
    /// </summary>
    [JsonPropertyName("paper_shipping_id")]
    public int? PaperShippingId { get; set; }

    /// <summary>
    /// 专票回传必填，专票邮寄运单号
    /// </summary>
    [JsonPropertyName("paper_tracking_number")]
    public string PaperTrackingNumber { get; set; }

    /// <summary>
    /// 开票人
    /// </summary>
    [JsonPropertyName("payee_operator")]
    public string PayeeOperator { get; set; }

    /// <summary>
    /// （企业抬头）开户账号
    /// </summary>
    [JsonPropertyName("payer_account")]
    public string PayerAccount { get; set; }

    /// <summary>
    /// （企业抬头）地址
    /// </summary>
    [JsonPropertyName("payer_address")]
    public string PayerAddress { get; set; }

    /// <summary>
    /// （企业抬头）开户银行
    /// </summary>
    [JsonPropertyName("payer_bank")]
    public string PayerBank { get; set; }

    /// <summary>
    /// 发票抬头
    /// </summary>
    [JsonPropertyName("payer_name")]
    public string PayerName { get; set; }

    /// <summary>
    /// （企业抬头）电话
    /// </summary>
    [JsonPropertyName("payer_phone")]
    public string PayerPhone { get; set; }

    /// <summary>
    /// 税号，企业必填
    /// </summary>
    [JsonPropertyName("payer_register_no")]
    public string PayerRegisterNo { get; set; }

    /// <summary>
    /// 不含税金额，整数，单位：分
    /// </summary>
    [JsonPropertyName("sum_price")]
    public long SumPrice { get; set; }

    /// <summary>
    /// 总税额，整数，单位：分
    /// </summary>
    [JsonPropertyName("sum_tax")]
    public int SumTax { get; set; }

    /// <summary>
    /// 税率,整数
    /// </summary>
    [JsonPropertyName("tax_rate")]
    public int TaxRate { get; set; }
    public partial class InvoiceItemListModel
    {

        /// <summary>
        /// 开票金额 单位:分
        /// </summary>
        [JsonPropertyName("invoice_amount")]
        public long InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票内容，pdf文件(电票回传)，图片文件(专票回传)，转码base64编码
        /// </summary>
        [JsonPropertyName("invoice_file_content")]
        public string InvoiceFileContent { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 原蓝票代码（红票必填）
        /// </summary>
        [JsonPropertyName("original_invoice_code")]
        public string OriginalInvoiceCode { get; set; }

        /// <summary>
        /// 原蓝票号码（红票必填）
        /// </summary>
        [JsonPropertyName("original_invoice_no")]
        public string OriginalInvoiceNo { get; set; }

    }

}

