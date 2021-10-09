namespace PddOpenSdk.Models.Request.Util;
public partial class BatchOpenKmsSearch
{

    /// <summary>
    /// 数据列表, 列表大小不超过100
    /// </summary>
    [JsonPropertyName("input_list")]
    public List<InputListModel> InputList { get; set; }
    public partial class InputListModel
    {

        /// <summary>
        /// 搜索内容
        /// </summary>
        [JsonPropertyName("input")]
        public string Input { get; set; }

        /// <summary>
        /// 敏感信息类型. id: 身份证号, phone: 手机号码, simple: 昵称, 地址等
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

    }

}

