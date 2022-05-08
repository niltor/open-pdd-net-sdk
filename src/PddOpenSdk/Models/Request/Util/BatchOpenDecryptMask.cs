namespace PddOpenSdk.Models.Request.Util;
public partial class BatchOpenDecryptMask
{

    /// <summary>
    /// 数据列表, 默认列表大小不超过100
    /// </summary>
    [JsonPropertyName("data_list")]
    public List<DataListModel> DataList { get; set; }
    public partial class DataListModel
    {

        /// <summary>
        /// 解密tag，对于订单数据是订单号
        /// </summary>
        [JsonPropertyName("data_tag")]
        public string DataTag { get; set; }

        /// <summary>
        /// 密文
        /// </summary>
        [JsonPropertyName("encrypted_data")]
        public string EncryptedData { get; set; }

    }

}

