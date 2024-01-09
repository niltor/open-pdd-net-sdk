namespace PddOpenSdk.Models.Request.Logistics;
public partial class GetConsoDwsData
{

    /// <summary>
    /// 获取DWS数据请求参数
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 运单号
        /// </summary>
        [JsonPropertyName("trckNo")]
        public string TrckNo { get; set; }

        /// <summary>
        /// 体积(单位：cm^3)
        /// </summary>
        [JsonPropertyName("volume")]
        public string Volume { get; set; }

        /// <summary>
        /// 设备供应商
        /// </summary>
        [JsonPropertyName("equipmentSupplier")]
        public string EquipmentSupplier { get; set; }

        /// <summary>
        /// 扫描时间戳(毫秒)
        /// </summary>
        [JsonPropertyName("scanTime")]
        public long ScanTime { get; set; }

        /// <summary>
        /// 体积-长(单位：cm)
        /// </summary>
        [JsonPropertyName("length")]
        public string Length { get; set; }

        /// <summary>
        /// 体积-宽(单位：cm)
        /// </summary>
        [JsonPropertyName("width")]
        public string Width { get; set; }

        /// <summary>
        /// 称重重量(单位：g)
        /// </summary>
        [JsonPropertyName("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// 体积重
        /// </summary>
        [JsonPropertyName("volumeWeight")]
        public string VolumeWeight { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonPropertyName("equipmentId")]
        public string EquipmentId { get; set; }

        /// <summary>
        /// 体积-高(单位：cm)
        /// </summary>
        [JsonPropertyName("height")]
        public string Height { get; set; }

    }

}

