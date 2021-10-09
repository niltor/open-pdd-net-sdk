namespace PddOpenSdk.Models.Request.Stock;
public partial class ListStockWare
{

    /// <summary>
    /// 货品id
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// 货品编码
    /// </summary>
    [JsonPropertyName("ware_sn")]
    public string WareSn { get; set; }

    /// <summary>
    /// 货品名称
    /// </summary>
    [JsonPropertyName("ware_name")]
    public string WareName { get; set; }

    /// <summary>
    /// 类型 0:单独货品。1:组合货品
    /// </summary>
    [JsonPropertyName("ware_type")]
    public int? WareType { get; set; }

    /// <summary>
    /// 页数，从1开始
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// 每页记录数
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }

}

