namespace PddOpenSdk.Models.Request.Oversea;
public partial class SignOverseaCustomsClearanceGet
{

    /// <summary>
    /// 业务单证名称
    /// </summary>
    [JsonPropertyName("ceb_name")]
    public string CebName { get; set; }

    /// <summary>
    /// 报关商海关注册编码
    /// </summary>
    [JsonPropertyName("company_customs_code")]
    public string CompanyCustomsCode { get; set; }

    /// <summary>
    /// 拼多多订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 要加签的数据,完整的xml报关报文字符串
    /// </summary>
    [JsonPropertyName("original_data_to_sign")]
    public string OriginalDataToSign { get; set; }

}

