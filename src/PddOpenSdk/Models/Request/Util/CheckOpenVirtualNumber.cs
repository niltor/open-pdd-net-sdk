namespace PddOpenSdk.Models.Request.Util;
public partial class CheckOpenVirtualNumber
{

    /// <summary>
    /// 分机号，非必填，4位数字字符
    /// </summary>
    [JsonPropertyName("identify_number")]
    public string IdentifyNumber { get; set; }

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 虚拟号，11位数字字符
    /// </summary>
    [JsonPropertyName("virtual_number")]
    public string VirtualNumber { get; set; }

}

