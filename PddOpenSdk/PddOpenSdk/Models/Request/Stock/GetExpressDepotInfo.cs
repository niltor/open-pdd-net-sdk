namespace PddOpenSdk.Models.Request.Stock;
public partial class GetExpressDepotInfo
{

    /// <summary>
    /// 仓库id
    /// </summary>
    [JsonPropertyName("depot_id")]
    public long DepotId { get; set; }

}

