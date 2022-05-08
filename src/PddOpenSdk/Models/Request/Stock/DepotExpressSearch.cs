namespace PddOpenSdk.Models.Request.Stock;
public partial class DepotExpressSearch
{

    /// <summary>
    /// 仓库编码
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    /// 10 分页数据size
    /// </summary>
    [JsonPropertyName("length")]
    public int Length { get; set; }

    /// <summary>
    /// 仓库名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// 0 分页数据起始位置
    /// </summary>
    [JsonPropertyName("start")]
    public int Start { get; set; }

}

