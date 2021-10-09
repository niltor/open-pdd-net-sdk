namespace PddOpenSdk.Models.Request.WayBill;
public partial class WaybillcodeWaybillQueryBy
{

    /// <summary>
    /// 系统自动生成
    /// </summary>
    [JsonPropertyName("param_list")]
    public List<ParamListModel> ParamList { get; set; }
    public partial class ParamListModel
    {

        /// <summary>
        /// 请求id
        /// </summary>
        [JsonPropertyName("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 电子面单号
        /// </summary>
        [JsonPropertyName("waybill_code")]
        public string WaybillCode { get; set; }

        /// <summary>
        /// 快递公司code
        /// </summary>
        [JsonPropertyName("wp_code")]
        public string WpCode { get; set; }

    }

}

