namespace PddOpenSdk.Models.Response.Invoice;
public partial class QueryEinvoiceInfoResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("einvoice_info_query_response")]
    public EinvoiceInfoQueryResponseResponse EinvoiceInfoQueryResponse { get; set; }
    public partial class EinvoiceInfoQueryResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("invoice_info_list")]
        public List<InvoiceInfoListResponse> InvoiceInfoList { get; set; }
        public partial class InvoiceInfoListResponse : PddResponseModel
        {

            /// <summary>
            /// 购方地址
            /// </summary>
            [JsonPropertyName("buyer_address")]
            public string BuyerAddress { get; set; }

            /// <summary>
            /// 购方银行账号
            /// </summary>
            [JsonPropertyName("buyer_bank_account")]
            public string BuyerBankAccount { get; set; }

            /// <summary>
            /// 购方银行名称
            /// </summary>
            [JsonPropertyName("buyer_bank_name")]
            public string BuyerBankName { get; set; }

            /// <summary>
            /// 购方名称(发票抬头)
            /// </summary>
            [JsonPropertyName("buyer_name")]
            public string BuyerName { get; set; }

            /// <summary>
            /// 购方电话
            /// </summary>
            [JsonPropertyName("buyer_phone_number")]
            public string BuyerPhoneNumber { get; set; }

            /// <summary>
            /// 购方税号
            /// </summary>
            [JsonPropertyName("buyer_tax_no")]
            public string BuyerTaxNo { get; set; }

            /// <summary>
            /// 复核人
            /// </summary>
            [JsonPropertyName("checker")]
            public string Checker { get; set; }

            /// <summary>
            /// 开票时间（毫秒，如：1594023438064），以服务商回传成功时间为准
            /// </summary>
            [JsonPropertyName("create_time")]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 开票人
            /// </summary>
            [JsonPropertyName("drawer")]
            public string Drawer { get; set; }

            /// <summary>
            /// 发票代码
            /// </summary>
            [JsonPropertyName("invoice_code")]
            public string InvoiceCode { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("invoice_item_list")]
            public List<InvoiceItemListResponse> InvoiceItemList { get; set; }

            /// <summary>
            /// 发票号码
            /// </summary>
            [JsonPropertyName("invoice_no")]
            public string InvoiceNo { get; set; }

            /// <summary>
            /// 发票开票日期（毫秒，如：1594023438064)
            /// </summary>
            [JsonPropertyName("invoice_time")]
            public long? InvoiceTime { get; set; }

            /// <summary>
            /// 发票类型 0-蓝票，1-红票
            /// </summary>
            [JsonPropertyName("invoice_type")]
            public int? InvoiceType { get; set; }

            /// <summary>
            /// pdd订单号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 原蓝票代码（红票时返回）
            /// </summary>
            [JsonPropertyName("original_invoice_code")]
            public string OriginalInvoiceCode { get; set; }

            /// <summary>
            /// 原蓝票号码（红票时返回）
            /// </summary>
            [JsonPropertyName("original_invoice_no")]
            public string OriginalInvoiceNo { get; set; }

            /// <summary>
            /// 收款人
            /// </summary>
            [JsonPropertyName("payee")]
            public string Payee { get; set; }

            /// <summary>
            /// 发票下载地址，30分钟内有效
            /// </summary>
            [JsonPropertyName("pdf_path")]
            public string PdfPath { get; set; }

            /// <summary>
            /// 发票备注信息
            /// </summary>
            [JsonPropertyName("remark")]
            public string Remark { get; set; }

            /// <summary>
            /// 销方地址
            /// </summary>
            [JsonPropertyName("seller_address")]
            public string SellerAddress { get; set; }

            /// <summary>
            /// 销方银行账号
            /// </summary>
            [JsonPropertyName("seller_bank_account")]
            public string SellerBankAccount { get; set; }

            /// <summary>
            /// 销方银行名称
            /// </summary>
            [JsonPropertyName("seller_bank_name")]
            public string SellerBankName { get; set; }

            /// <summary>
            /// 销方名称
            /// </summary>
            [JsonPropertyName("seller_name")]
            public string SellerName { get; set; }

            /// <summary>
            /// 销方电话
            /// </summary>
            [JsonPropertyName("seller_phone_number")]
            public string SellerPhoneNumber { get; set; }

            /// <summary>
            /// 销方税号
            /// </summary>
            [JsonPropertyName("seller_tax_no")]
            public string SellerTaxNo { get; set; }

            /// <summary>
            /// 价税合计金额(放大100倍，单位分)
            /// </summary>
            [JsonPropertyName("total_amount")]
            public long? TotalAmount { get; set; }

            /// <summary>
            /// 合计金额（不含税，放大100倍，单位分）
            /// </summary>
            [JsonPropertyName("total_price")]
            public long? TotalPrice { get; set; }

            /// <summary>
            /// 合计税额(放大100倍，单位分)
            /// </summary>
            [JsonPropertyName("total_tax_amount")]
            public long? TotalTaxAmount { get; set; }
            public partial class InvoiceItemListResponse : PddResponseModel
            {

                /// <summary>
                /// 价税合计(放大100倍,单位分)
                /// </summary>
                [JsonPropertyName("amount")]
                public long? Amount { get; set; }

                /// <summary>
                /// 税收分类编码
                /// </summary>
                [JsonPropertyName("catalog_code")]
                public string CatalogCode { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 不含税金额(放大100倍，单位分)
                /// </summary>
                [JsonPropertyName("no_tax_amount")]
                public long? NoTaxAmount { get; set; }

                /// <summary>
                /// 含税单价（放大1000000倍）
                /// </summary>
                [JsonPropertyName("price")]
                public long? Price { get; set; }

                /// <summary>
                /// 数量（放大1000000倍）
                /// </summary>
                [JsonPropertyName("quantity")]
                public long? Quantity { get; set; }

                /// <summary>
                /// 规格型号
                /// </summary>
                [JsonPropertyName("specification")]
                public string Specification { get; set; }

                /// <summary>
                /// 税率
                /// </summary>
                [JsonPropertyName("tax_rate")]
                public string TaxRate { get; set; }

                /// <summary>
                /// 总税额(放大100倍，单位分)
                /// </summary>
                [JsonPropertyName("total_tax")]
                public long? TotalTax { get; set; }

                /// <summary>
                /// 单位
                /// </summary>
                [JsonPropertyName("unit")]
                public string Unit { get; set; }

                /// <summary>
                /// 零税率标识，1：免税，2：不征税，3：普通零税率
                /// </summary>
                [JsonPropertyName("zero_tax_rate_flag")]
                public int? ZeroTaxRateFlag { get; set; }

            }

        }

    }

}

