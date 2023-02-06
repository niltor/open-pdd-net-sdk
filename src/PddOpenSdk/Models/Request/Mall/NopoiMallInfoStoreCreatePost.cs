namespace PddOpenSdk.Models.Request.Mall;
public partial class NopoiMallInfoStoreCreatePost
{

    /// <summary>
    /// 门店营业状态（0:营业中 1:暂停营业）
    /// </summary>
    [JsonPropertyName("business_status")]
    public int BusinessStatus { get; set; }

    /// <summary>
    /// 一周营业时间，例：[1,2,3,4,5,6,7]
    /// </summary>
    [JsonPropertyName("business_week_list")]
    public List<int> BusinessWeekList { get; set; }

    /// <summary>
    /// 市
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// 区
    /// </summary>
    [JsonPropertyName("district")]
    public string District { get; set; }

    /// <summary>
    /// 结束营业时间，例："19:00"
    /// </summary>
    [JsonPropertyName("end_business_hour")]
    public string EndBusinessHour { get; set; }

    /// <summary>
    /// 门店纬度
    /// </summary>
    [JsonPropertyName("poi_latitude")]
    public double PoiLatitude { get; set; }

    /// <summary>
    /// 门店经度
    /// </summary>
    [JsonPropertyName("poi_longitude")]
    public double PoiLongitude { get; set; }

    /// <summary>
    /// 省
    /// </summary>
    [JsonPropertyName("province")]
    public string Province { get; set; }

    /// <summary>
    /// 起始营业时间，例："07:00"
    /// </summary>
    [JsonPropertyName("start_business_hour")]
    public string StartBusinessHour { get; set; }

    /// <summary>
    /// 详细地址
    /// </summary>
    [JsonPropertyName("store_address")]
    public string StoreAddress { get; set; }

    /// <summary>
    /// 门店名称
    /// </summary>
    [JsonPropertyName("store_name")]
    public string StoreName { get; set; }

    /// <summary>
    /// 门店自有编号
    /// </summary>
    [JsonPropertyName("store_number")]
    public string StoreNumber { get; set; }

    /// <summary>
    /// 门店电话
    /// </summary>
    [JsonPropertyName("store_phone")]
    public string StorePhone { get; set; }

    /// <summary>
    /// 门店行业类型（1-男女装，2-运动户外，3-服饰配件，4-厨具电器，5-汽车，8-全屋定制）
    /// </summary>
    [JsonPropertyName("trade_type")]
    public int TradeType { get; set; }

}

