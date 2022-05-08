namespace PddOpenSdk.Models.Request.Stock;
public partial class QueryStockWareDetail
{

    /// <summary>
    /// 货品id
    /// </summary>
    [JsonPropertyName("ware_id")]
    public long WareId { get; set; }

}

