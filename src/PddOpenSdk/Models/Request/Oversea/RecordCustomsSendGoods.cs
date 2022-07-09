namespace PddOpenSdk.Models.Request.Oversea;
public partial class RecordCustomsSendGoods
{

    /// <summary>
    /// 上传备案商品请求
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 备案商品列表
        /// </summary>
        [JsonPropertyName("goods_list")]
        public List<GoodsListModel> GoodsList { get; set; }
        public partial class GoodsListModel
        {

            /// <summary>
            /// 条形码
            /// </summary>
            [JsonPropertyName("bar_code")]
            public string BarCode { get; set; }

            /// <summary>
            /// 保税仓名称
            /// </summary>
            [JsonPropertyName("bonded_warehouse_name")]
            public string BondedWarehouseName { get; set; }

            /// <summary>
            /// 品牌中文名称
            /// </summary>
            [JsonPropertyName("brand_chinese_name")]
            public string BrandChineseName { get; set; }

            /// <summary>
            /// 品牌英文名称
            /// </summary>
            [JsonPropertyName("brand_english_name")]
            public string BrandEnglishName { get; set; }

            /// <summary>
            /// 品类
            /// </summary>
            [JsonPropertyName("category")]
            public string Category { get; set; }

            /// <summary>
            /// 消费税率，单位%
            /// </summary>
            [JsonPropertyName("consumption_tax_rate")]
            public double? ConsumptionTaxRate { get; set; }

            /// <summary>
            /// 成本价（RMB）
            /// </summary>
            [JsonPropertyName("cost_price")]
            public double? CostPrice { get; set; }

            /// <summary>
            /// 海关关区代码
            /// </summary>
            [JsonPropertyName("customs_code")]
            public string CustomsCode { get; set; }

            /// <summary>
            /// 备案电商企业的海关注册登记名称(备案的电商企业名称)
            /// </summary>
            [JsonPropertyName("ebc_name")]
            public string EbcName { get; set; }

            /// <summary>
            /// 账册编号
            /// </summary>
            [JsonPropertyName("ems_no")]
            public string EmsNo { get; set; }

            /// <summary>
            /// 保质期
            /// </summary>
            [JsonPropertyName("expiration_date")]
            public string ExpirationDate { get; set; }

            /// <summary>
            /// 毛重（KG）
            /// </summary>
            [JsonPropertyName("gross_weight")]
            public double? GrossWeight { get; set; }

            /// <summary>
            /// 海关HS code
            /// </summary>
            [JsonPropertyName("hs_code")]
            public string HsCode { get; set; }

            /// <summary>
            /// 备案商品图片链接
            /// </summary>
            [JsonPropertyName("img_url")]
            public string ImgUrl { get; set; }

            /// <summary>
            /// 电商企业的商品编号(skuId非pdd skuId)
            /// </summary>
            [JsonPropertyName("item_no")]
            public string ItemNo { get; set; }

            /// <summary>
            /// 物料号
            /// </summary>
            [JsonPropertyName("item_record_no")]
            public string ItemRecordNo { get; set; }

            /// <summary>
            /// 生产企业名称
            /// </summary>
            [JsonPropertyName("manufacturing_company_name")]
            public string ManufacturingCompanyName { get; set; }

            /// <summary>
            /// 生产企业注册号
            /// </summary>
            [JsonPropertyName("manufacturing_company_registration_no")]
            public string ManufacturingCompanyRegistrationNo { get; set; }

            /// <summary>
            /// 生产厂家地址（奶制品必填）
            /// </summary>
            [JsonPropertyName("manufacturing_factory_address")]
            public string ManufacturingFactoryAddress { get; set; }

            /// <summary>
            /// 净重（KG）
            /// </summary>
            [JsonPropertyName("net_weight")]
            public double? NetWeight { get; set; }

            /// <summary>
            /// 海关口岸代码
            /// </summary>
            [JsonPropertyName("port_code")]
            public string PortCode { get; set; }

            /// <summary>
            /// 生产国代码
            /// </summary>
            [JsonPropertyName("producing_country")]
            public string ProducingCountry { get; set; }

            /// <summary>
            /// 产品国检备案编号
            /// </summary>
            [JsonPropertyName("product_record_no")]
            public string ProductRecordNo { get; set; }

            /// <summary>
            /// 法定第一数量
            /// </summary>
            [JsonPropertyName("qty1")]
            public double? Qty1 { get; set; }

            /// <summary>
            /// 法定第二数量
            /// </summary>
            [JsonPropertyName("qty2")]
            public double? Qty2 { get; set; }

            /// <summary>
            /// 备案商品中文名称
            /// </summary>
            [JsonPropertyName("record_chinese_name")]
            public string RecordChineseName { get; set; }

            /// <summary>
            /// 备案商品英文名称
            /// </summary>
            [JsonPropertyName("record_english_name")]
            public string RecordEnglishName { get; set; }

            /// <summary>
            /// 商品规格型号(报文gmodel)
            /// </summary>
            [JsonPropertyName("record_model")]
            public string RecordModel { get; set; }

            /// <summary>
            /// 型号
            /// </summary>
            [JsonPropertyName("specification")]
            public string Specification { get; set; }

            /// <summary>
            /// 库存数量
            /// </summary>
            [JsonPropertyName("stock")]
            public long? Stock { get; set; }

            /// <summary>
            /// 库存时间
            /// </summary>
            [JsonPropertyName("stock_time")]
            public string StockTime { get; set; }

            /// <summary>
            /// 关税税率,单位%
            /// </summary>
            [JsonPropertyName("tariff_rate")]
            public double? TariffRate { get; set; }

            /// <summary>
            /// 申报单位代码
            /// </summary>
            [JsonPropertyName("unit")]
            public string Unit { get; set; }

            /// <summary>
            /// 法定第一单位代码
            /// </summary>
            [JsonPropertyName("unit1")]
            public string Unit1 { get; set; }

            /// <summary>
            /// 法定第二单位代码
            /// </summary>
            [JsonPropertyName("unit2")]
            public string Unit2 { get; set; }

            /// <summary>
            /// 单价（RMB）
            /// </summary>
            [JsonPropertyName("unit_price")]
            public double? UnitPrice { get; set; }

            /// <summary>
            /// 增值税率，单位%
            /// </summary>
            [JsonPropertyName("value_added_tax_rate")]
            public double? ValueAddedTaxRate { get; set; }

            /// <summary>
            /// 供应商名称
            /// </summary>
            [JsonPropertyName("vendor_name")]
            public string VendorName { get; set; }

            /// <summary>
            /// 备案仓储企业代码
            /// </summary>
            [JsonPropertyName("wc_code")]
            public string WcCode { get; set; }

            /// <summary>
            /// 备案仓储企业的海关注册登记名称
            /// </summary>
            [JsonPropertyName("wc_name")]
            public string WcName { get; set; }

            /// <summary>
            /// 网络链接
            /// </summary>
            [JsonPropertyName("website")]
            public string Website { get; set; }

            /// <summary>
            /// 包装方式
            /// </summary>
            [JsonPropertyName("wrap_type")]
            public string WrapType { get; set; }

        }

    }

}

