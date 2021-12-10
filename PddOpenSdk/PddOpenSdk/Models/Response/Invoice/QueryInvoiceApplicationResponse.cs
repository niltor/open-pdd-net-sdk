namespace PddOpenSdk.Models.Response.Invoice;
public partial class QueryInvoiceApplicationResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("invoice_application_query_response")]
    public InvoiceApplicationQueryResponseResponse InvoiceApplicationQueryResponse { get; set; }
    public partial class InvoiceApplicationQueryResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 发票申请列表
        /// </summary>
        [JsonPropertyName("invoice_application_list")]
        public List<InvoiceApplicationListResponse> InvoiceApplicationList { get; set; }
        public partial class InvoiceApplicationListResponse : PddResponseModel
        {

            /// <summary>
            /// 申请状态：0-已拒绝，1-申请中，2-已同意
            /// </summary>
            [JsonPropertyName("application_status")]
            public int? ApplicationStatus { get; set; }

            /// <summary>
            /// 申请时间
            /// </summary>
            [JsonPropertyName("apply_time")]
            public int? ApplyTime { get; set; }

            /// <summary>
            /// 抬头类型：0-个人，1-企业
            /// </summary>
            [JsonPropertyName("business_type")]
            public int? BusinessType { get; set; }

            /// <summary>
            /// 开票金额，暂为null，取买家实付
            /// </summary>
            [JsonPropertyName("invoice_amount")]
            public string InvoiceAmount { get; set; }

            /// <summary>
            /// 发票种类：0-电子，1-纸质，2-专票；目前只支持0和2
            /// </summary>
            [JsonPropertyName("invoice_kind")]
            public int? InvoiceKind { get; set; }

            /// <summary>
            /// 发票类型：0-蓝票，1-红票
            /// </summary>
            [JsonPropertyName("invoice_type")]
            public int? InvoiceType { get; set; }

            /// <summary>
            /// 开票方式 0=手动开票,1=自动开票
            /// </summary>
            [JsonPropertyName("invoice_way")]
            public int? InvoiceWay { get; set; }

            /// <summary>
            /// 店铺id
            /// </summary>
            [JsonPropertyName("mall_id")]
            public long? MallId { get; set; }

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
            /// 企业税号，抬头为企业类型必填
            /// </summary>
            [JsonPropertyName("payer_register_no")]
            public string PayerRegisterNo { get; set; }

            /// <summary>
            /// 是否正品发票：0=非正品发票，1=非正品发票
            /// </summary>
            [JsonPropertyName("quality_goods_invoice")]
            public int? QualityGoodsInvoice { get; set; }

            /// <summary>
            /// 驳回原因
            /// </summary>
            [JsonPropertyName("reason")]
            public string Reason { get; set; }

            /// <summary>
            /// 不含税金额，暂为null
            /// </summary>
            [JsonPropertyName("sum_price")]
            public string SumPrice { get; set; }

            /// <summary>
            /// 总税额，暂为null
            /// </summary>
            [JsonPropertyName("sum_tax")]
            public string SumTax { get; set; }

            /// <summary>
            /// 税率，暂为null
            /// </summary>
            [JsonPropertyName("tax_rate")]
            public string TaxRate { get; set; }

            /// <summary>
            /// 开票申请触发类型：1-申请开票，2-改抬头
            /// </summary>
            [JsonPropertyName("trigger_status")]
            public int? TriggerStatus { get; set; }

        }

    }

}

