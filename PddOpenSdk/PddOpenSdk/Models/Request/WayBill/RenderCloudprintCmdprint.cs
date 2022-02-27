namespace PddOpenSdk.Models.Request.WayBill;
public partial class RenderCloudprintCmdprint
{

    /// <summary>
    /// request
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 客户端id
        /// </summary>
        [JsonPropertyName("client_side_id")]
        public string ClientSideId { get; set; }

        /// <summary>
        /// 客户端类型
        /// </summary>
        [JsonPropertyName("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 返回值编码方式，枚举值：gzip(默认值)、gzip_byte(推荐值)
        /// </summary>
        [JsonPropertyName("cmd_encoding")]
        public string CmdEncoding { get; set; }

        /// <summary>
        /// 打印配置
        /// </summary>
        [JsonPropertyName("config")]
        public ConfigModel Config { get; set; }

        /// <summary>
        /// 需要打印的文档，包括模板地址，打印数据
        /// </summary>
        [JsonPropertyName("document")]
        public DocumentModel Document { get; set; }

        /// <summary>
        /// 枚举值：CPCL、TSPL
        /// </summary>
        [JsonPropertyName("print_command_type")]
        public string PrintCommandType { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [JsonPropertyName("printer_name")]
        public string PrinterName { get; set; }
        public partial class ConfigModel
        {

            /// <summary>
            /// 水平偏移
            /// </summary>
            [JsonPropertyName("horizontal_offset")]
            public double? HorizontalOffset { get; set; }

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

            /// <summary>
            /// 垂直偏移
            /// </summary>
            [JsonPropertyName("vertical_offset")]
            public double? VerticalOffset { get; set; }

        }
        public partial class DocumentModel
        {

            /// <summary>
            /// 包含的区域列表。对于有自定义区的文档，content会包含两条，即第一条是标准模板区域内容、第二条是自定义区域内容
            /// </summary>
            [JsonPropertyName("contents")]
            public List<ContentsModel> Contents { get; set; }
            public partial class ContentsModel
            {

                /// <summary>
                /// 附加数据（用于修改数据）例如：{ sender:{ address:{ detail:蒋村街道西溪诚园小区2-1-101 } } }
                /// </summary>
                [JsonPropertyName("add_data")]
                public string AddData { get; set; }

                /// <summary>
                /// 是否获取加密数据
                /// </summary>
                [JsonPropertyName("encrypted")]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// 打印数据
                /// </summary>
                [JsonPropertyName("print_data")]
                public string PrintData { get; set; }

                /// <summary>
                /// 数据签名
                /// </summary>
                [JsonPropertyName("signature")]
                public string Signature { get; set; }

                /// <summary>
                /// 模板url
                /// </summary>
                [JsonPropertyName("template_url")]
                public string TemplateUrl { get; set; }

                /// <summary>
                /// 加密数据使用秘钥版本
                /// </summary>
                [JsonPropertyName("ver")]
                public string Ver { get; set; }

            }

        }

    }

}

