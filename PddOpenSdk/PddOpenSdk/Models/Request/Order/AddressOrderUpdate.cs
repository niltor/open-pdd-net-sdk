namespace PddOpenSdk.Models.Request.Order;
public partial class AddressOrderUpdate
{

    /// <summary>
    /// 收件详细地址
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; }

    /// <summary>
    /// 收件地城市
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// 城市编码
    /// </summary>
    [JsonPropertyName("city_id")]
    public int CityId { get; set; }

    /// <summary>
    /// 订单编号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 收件地省份
    /// </summary>
    [JsonPropertyName("province")]
    public string Province { get; set; }

    /// <summary>
    /// 省份编码
    /// </summary>
    [JsonPropertyName("province_id")]
    public int ProvinceId { get; set; }

    /// <summary>
    /// 收件人姓名
    /// </summary>
    [JsonPropertyName("receiver_name")]
    public string ReceiverName { get; set; }

    /// <summary>
    /// 收件人电话，明文
    /// </summary>
    [JsonPropertyName("receiver_phone")]
    public string ReceiverPhone { get; set; }

    /// <summary>
    /// 收件地区县
    /// </summary>
    [JsonPropertyName("town")]
    public string Town { get; set; }

    /// <summary>
    /// 区县编码
    /// </summary>
    [JsonPropertyName("town_id")]
    public int TownId { get; set; }

}

