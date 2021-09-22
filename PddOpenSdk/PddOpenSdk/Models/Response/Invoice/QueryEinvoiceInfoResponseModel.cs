using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Invoice
{
    public partial class QueryEinvoiceInfoResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("einvoice_info_query_response")]
        public EinvoiceInfoQueryResponseResponseModel EinvoiceInfoQueryResponse { get; set; }
        public partial class EinvoiceInfoQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("invoice_info_list")]
            public List<InvoiceInfoListResponseModel> InvoiceInfoList { get; set; }
            public partial class InvoiceInfoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 购方地址
                /// </summary>
                [JsonProperty("buyer_address")]
                public string BuyerAddress { get; set; }
                /// <summary>
                /// 购方银行账号
                /// </summary>
                [JsonProperty("buyer_bank_account")]
                public string BuyerBankAccount { get; set; }
                /// <summary>
                /// 购方银行名称
                /// </summary>
                [JsonProperty("buyer_bank_name")]
                public string BuyerBankName { get; set; }
                /// <summary>
                /// 购方名称(发票抬头)
                /// </summary>
                [JsonProperty("buyer_name")]
                public string BuyerName { get; set; }
                /// <summary>
                /// 购方电话
                /// </summary>
                [JsonProperty("buyer_phone_number")]
                public string BuyerPhoneNumber { get; set; }
                /// <summary>
                /// 购方税号
                /// </summary>
                [JsonProperty("buyer_tax_no")]
                public string BuyerTaxNo { get; set; }
                /// <summary>
                /// 复核人
                /// </summary>
                [JsonProperty("checker")]
                public string Checker { get; set; }
                /// <summary>
                /// 开票时间（毫秒，如：1594023438064），以服务商回传成功时间为准
                /// </summary>
                [JsonProperty("create_time")]
                public long? CreateTime { get; set; }
                /// <summary>
                /// 开票人
                /// </summary>
                [JsonProperty("drawer")]
                public string Drawer { get; set; }
                /// <summary>
                /// 发票代码
                /// </summary>
                [JsonProperty("invoice_code")]
                public string InvoiceCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("invoice_item_list")]
                public List<InvoiceItemListResponseModel> InvoiceItemList { get; set; }
                /// <summary>
                /// 发票号码
                /// </summary>
                [JsonProperty("invoice_no")]
                public string InvoiceNo { get; set; }
                /// <summary>
                /// 发票开票日期（毫秒，如：1594023438064)
                /// </summary>
                [JsonProperty("invoice_time")]
                public long? InvoiceTime { get; set; }
                /// <summary>
                /// 发票类型 0-蓝票，1-红票
                /// </summary>
                [JsonProperty("invoice_type")]
                public int? InvoiceType { get; set; }
                /// <summary>
                /// pdd订单号
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }
                /// <summary>
                /// 原蓝票代码（红票时返回）
                /// </summary>
                [JsonProperty("original_invoice_code")]
                public string OriginalInvoiceCode { get; set; }
                /// <summary>
                /// 原蓝票号码（红票时返回）
                /// </summary>
                [JsonProperty("original_invoice_no")]
                public string OriginalInvoiceNo { get; set; }
                /// <summary>
                /// 收款人
                /// </summary>
                [JsonProperty("payee")]
                public string Payee { get; set; }
                /// <summary>
                /// 发票下载地址，30分钟内有效
                /// </summary>
                [JsonProperty("pdf_path")]
                public string PdfPath { get; set; }
                /// <summary>
                /// 发票备注信息
                /// </summary>
                [JsonProperty("remark")]
                public string Remark { get; set; }
                /// <summary>
                /// 销方地址
                /// </summary>
                [JsonProperty("seller_address")]
                public string SellerAddress { get; set; }
                /// <summary>
                /// 销方银行账号
                /// </summary>
                [JsonProperty("seller_bank_account")]
                public string SellerBankAccount { get; set; }
                /// <summary>
                /// 销方银行名称
                /// </summary>
                [JsonProperty("seller_bank_name")]
                public string SellerBankName { get; set; }
                /// <summary>
                /// 销方名称
                /// </summary>
                [JsonProperty("seller_name")]
                public string SellerName { get; set; }
                /// <summary>
                /// 销方电话
                /// </summary>
                [JsonProperty("seller_phone_number")]
                public string SellerPhoneNumber { get; set; }
                /// <summary>
                /// 销方税号
                /// </summary>
                [JsonProperty("seller_tax_no")]
                public string SellerTaxNo { get; set; }
                /// <summary>
                /// 价税合计金额(放大100倍，单位分)
                /// </summary>
                [JsonProperty("total_amount")]
                public long? TotalAmount { get; set; }
                /// <summary>
                /// 合计金额（不含税，放大100倍，单位分）
                /// </summary>
                [JsonProperty("total_price")]
                public long? TotalPrice { get; set; }
                /// <summary>
                /// 合计税额(放大100倍，单位分)
                /// </summary>
                [JsonProperty("total_tax_amount")]
                public long? TotalTaxAmount { get; set; }
                public partial class InvoiceItemListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 价税合计(放大100倍,单位分)
                    /// </summary>
                    [JsonProperty("amount")]
                    public long? Amount { get; set; }
                    /// <summary>
                    /// 税收分类编码
                    /// </summary>
                    [JsonProperty("catalog_code")]
                    public string CatalogCode { get; set; }
                    /// <summary>
                    /// 商品名称
                    /// </summary>
                    [JsonProperty("goods_name")]
                    public string GoodsName { get; set; }
                    /// <summary>
                    /// 不含税金额(放大100倍，单位分)
                    /// </summary>
                    [JsonProperty("no_tax_amount")]
                    public long? NoTaxAmount { get; set; }
                    /// <summary>
                    /// 含税单价（放大1000000倍）
                    /// </summary>
                    [JsonProperty("price")]
                    public long? Price { get; set; }
                    /// <summary>
                    /// 数量（放大1000000倍）
                    /// </summary>
                    [JsonProperty("quantity")]
                    public long? Quantity { get; set; }
                    /// <summary>
                    /// 规格型号
                    /// </summary>
                    [JsonProperty("specification")]
                    public string Specification { get; set; }
                    /// <summary>
                    /// 税率
                    /// </summary>
                    [JsonProperty("tax_rate")]
                    public string TaxRate { get; set; }
                    /// <summary>
                    /// 总税额(放大100倍，单位分)
                    /// </summary>
                    [JsonProperty("total_tax")]
                    public long? TotalTax { get; set; }
                    /// <summary>
                    /// 单位
                    /// </summary>
                    [JsonProperty("unit")]
                    public string Unit { get; set; }
                    /// <summary>
                    /// 零税率标识，1：免税，2：不征税，3：普通零税率
                    /// </summary>
                    [JsonProperty("zero_tax_rate_flag")]
                    public int? ZeroTaxRateFlag { get; set; }

                }

            }

        }

    }

}
