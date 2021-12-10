namespace PddOpenSdk.Models.Request.Stock;
public partial class GetExpressDepotList
{

    /// <summary>
    /// 分页数据size
    /// </summary>
    [JsonPropertyName("length")]
    public long Length { get; set; }

    /// <summary>
    /// 分页数据起始位置
    /// </summary>
    [JsonPropertyName("start")]
    public long Start { get; set; }

}

