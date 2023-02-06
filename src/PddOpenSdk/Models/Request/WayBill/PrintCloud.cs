namespace PddOpenSdk.Models.Request.WayBill;
public partial class PrintCloud
{

    /// <summary>
    /// 云打印请求
    /// </summary>
    [JsonPropertyName("cloud_print_request")]
    public CloudPrintRequestModel CloudPrintRequest { get; set; }
    public partial class CloudPrintRequestModel
    {

        /// <summary>
        /// 打印数据列表
        /// </summary>
        [JsonPropertyName("print_data_list")]
        public List<PrintDataListModel> PrintDataList { get; set; }

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonPropertyName("printer_id")]
        public string PrinterId { get; set; }

        /// <summary>
        /// 打印机设置
        /// </summary>
        [JsonPropertyName("printer_setting")]
        public PrinterSettingModel PrinterSetting { get; set; }

        /// <summary>
        /// 共享码
        /// </summary>
        [JsonPropertyName("share_code")]
        public string ShareCode { get; set; }
        public partial class PrintDataListModel
        {

            /// <summary>
            /// 自定区打印数据
            /// </summary>
            [JsonPropertyName("custom_area_print_data")]
            public CustomAreaPrintDataModel CustomAreaPrintData { get; set; }

            /// <summary>
            /// 面单打印数据
            /// </summary>
            [JsonPropertyName("waybill_printer_data")]
            public WaybillPrinterDataModel WaybillPrinterData { get; set; }
            public partial class CustomAreaPrintDataModel
            {

                /// <summary>
                /// 打印数据
                /// </summary>
                [JsonPropertyName("data")]
                public string Data { get; set; }

                /// <summary>
                /// 模板url
                /// </summary>
                [JsonPropertyName("template_url")]
                public string TemplateUrl { get; set; }

            }
            public partial class WaybillPrinterDataModel
            {

                /// <summary>
                /// 追加数据,例如：{\"sender\":{\"address\":{\"province\":\"辽宁\",\"city\":\"沈阳市\",\"district\":\"铁西区\",\"detail\":\"xxx\"},\"name\":\"xxx\",\"mobile\":\"139xxxx032\"}}
                /// </summary>
                [JsonPropertyName("add_data")]
                public string AddData { get; set; }

                /// <summary>
                /// 打印数据
                /// </summary>
                [JsonPropertyName("data")]
                public string Data { get; set; }

                /// <summary>
                /// 是否加密
                /// </summary>
                [JsonPropertyName("encrypted")]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// 签名
                /// </summary>
                [JsonPropertyName("signature")]
                public string Signature { get; set; }

                /// <summary>
                /// 模板url
                /// </summary>
                [JsonPropertyName("template_url")]
                public string TemplateUrl { get; set; }

                /// <summary>
                /// 版本
                /// </summary>
                [JsonPropertyName("ver")]
                public string Ver { get; set; }

            }

        }
        public partial class PrinterSettingModel
        {

            /// <summary>
            /// 是否打印下联logo
            /// </summary>
            [JsonPropertyName("need_bottom_logo")]
            public bool? NeedBottomLogo { get; set; }

            /// <summary>
            /// 是否打印中联logo
            /// </summary>
            [JsonPropertyName("need_middle_logo")]
            public bool? NeedMiddleLogo { get; set; }

            /// <summary>
            /// 是否打印上联logo
            /// </summary>
            [JsonPropertyName("need_top_logo")]
            public bool? NeedTopLogo { get; set; }

            /// <summary>
            /// 打印方向 normal-正常 reverse-翻转
            /// </summary>
            [JsonPropertyName("orientation")]
            public string Orientation { get; set; }

        }

    }

}

