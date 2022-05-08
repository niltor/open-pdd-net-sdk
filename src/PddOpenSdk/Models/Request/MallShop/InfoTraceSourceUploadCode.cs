namespace PddOpenSdk.Models.Request.MallShop;
public partial class InfoTraceSourceUploadCode
{

    /// <summary>
    /// 溯源码列表
    /// </summary>
    [JsonPropertyName("serial_num_list")]
    public List<SerialNumListModel> SerialNumList { get; set; }
    public partial class SerialNumListModel
    {

        /// <summary>
        /// 溯源码（处理后）
        /// </summary>
        [JsonPropertyName("encoded_serial_num")]
        public string EncodedSerialNum { get; set; }

        /// <summary>
        /// 溯源码
        /// </summary>
        [JsonPropertyName("serial_num")]
        public string SerialNum { get; set; }

    }

}

