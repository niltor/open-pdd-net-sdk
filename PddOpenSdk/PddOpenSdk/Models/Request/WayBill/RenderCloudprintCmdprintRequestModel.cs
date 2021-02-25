using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.WayBill
{
    public partial class RenderCloudprintCmdprintRequestModel : PddRequestModel
    {
        /// <summary>
        /// request
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestModel Request { get; set; }
        public partial class RequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 客户端id
            /// </summary>
            [JsonProperty("client_side_id")]
            public string ClientSideId { get; set; }
            /// <summary>
            /// 客户端类型
            /// </summary>
            [JsonProperty("client_type")]
            public string ClientType { get; set; }
            /// <summary>
            /// 打印配置
            /// </summary>
            [JsonProperty("config")]
            public ConfigRequestModel Config { get; set; }
            /// <summary>
            /// 需要打印的文档，包括模板地址，打印数据
            /// </summary>
            [JsonProperty("document")]
            public DocumentRequestModel Document { get; set; }
            /// <summary>
            /// 打印机名称
            /// </summary>
            [JsonProperty("printer_name")]
            public string PrinterName { get; set; }
            /// <summary>
            /// 枚举值：CPCL、TSPL
            /// </summary>
            [JsonProperty("print_command_type")]
            public string PrintCommandType { get; set; }
            public partial class ConfigRequestModel : PddRequestModel
            {
                /// <summary>
                /// 水平偏移
                /// </summary>
                [JsonProperty("horizontal_offset")]
                public double? HorizontalOffset { get; set; }
                /// <summary>
                /// 是否打印下联logo
                /// </summary>
                [JsonProperty("need_bottom_logo")]
                public bool? NeedBottomLogo { get; set; }
                /// <summary>
                /// 是否打印中联logo
                /// </summary>
                [JsonProperty("need_middle_logo")]
                public bool? NeedMiddleLogo { get; set; }
                /// <summary>
                /// 是否打印上联logo
                /// </summary>
                [JsonProperty("need_top_logo")]
                public bool? NeedTopLogo { get; set; }
                /// <summary>
                /// 打印方向 normal-正常 reverse-翻转
                /// </summary>
                [JsonProperty("orientation")]
                public string Orientation { get; set; }
                /// <summary>
                /// 垂直偏移
                /// </summary>
                [JsonProperty("vertical_offset")]
                public double? VerticalOffset { get; set; }

            }
            public partial class DocumentRequestModel : PddRequestModel
            {
                /// <summary>
                /// 包含的区域列表。对于有自定义区的文档，content会包含两条，即第一条是标准模板区域内容、第二条是自定义区域内容
                /// </summary>
                [JsonProperty("contents")]
                public List<ContentsRequestModel> Contents { get; set; }
                public partial class ContentsRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 附加数据（用于修改数据）例如：{ sender:{ address:{ detail:蒋村街道西溪诚园小区2-1-101 } } }
                    /// </summary>
                    [JsonProperty("add_data")]
                    public string AddData { get; set; }
                    /// <summary>
                    /// 是否获取加密数据
                    /// </summary>
                    [JsonProperty("encrypted")]
                    public bool? Encrypted { get; set; }
                    /// <summary>
                    /// 打印数据
                    /// </summary>
                    [JsonProperty("print_data")]
                    public string PrintData { get; set; }
                    /// <summary>
                    /// 数据签名
                    /// </summary>
                    [JsonProperty("signature")]
                    public string Signature { get; set; }
                    /// <summary>
                    /// 模板url
                    /// </summary>
                    [JsonProperty("template_url")]
                    public string TemplateUrl { get; set; }
                    /// <summary>
                    /// 加密数据使用秘钥版本
                    /// </summary>
                    [JsonProperty("ver")]
                    public string Ver { get; set; }

                }

            }

        }

    }

}
