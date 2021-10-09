namespace PddOpenSdk.Models.Response.WayBill;
public partial class RenderCloudprintCmdprintResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("cloudprint_cmdprint_render_response")]
    public CloudprintCmdprintRenderResponseResponse CloudprintCmdprintRenderResponse { get; set; }
    public partial class CloudprintCmdprintRenderResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 指令集内容串
        /// </summary>
        [JsonPropertyName("cmd_content")]
        public string CmdContent { get; set; }

        /// <summary>
        /// 指令集编码方式枚举。origin: 原串；gzip: 打印指令string(utf-8编码)采用gzip压缩后再使用base64编码；gzip_type: 打印指令字节数组采用gzip压缩后再使用base64编码。
        /// </summary>
        [JsonPropertyName("cmd_encoding")]
        public string CmdEncoding { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

