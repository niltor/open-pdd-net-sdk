namespace PddOpenSdk.Models.Request.MallShop;
public partial class BatchOpenKmsEncrypt
{

    /// <summary>
    /// 要加密的数据列表, 列表大小不超过100
    /// </summary>
    [JsonPropertyName("data_list")]
    public List<DataListModel> DataList { get; set; }
    public partial class DataListModel
    {

        /// <summary>
        /// 明文数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 是否支持搜索
        /// </summary>
        [JsonPropertyName("search")]
        public bool Search { get; set; }

        /// <summary>
        /// 敏感信息类型. id: 身份证号, phone: 手机号码, simple: 昵称, 地址等
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

    }

}

