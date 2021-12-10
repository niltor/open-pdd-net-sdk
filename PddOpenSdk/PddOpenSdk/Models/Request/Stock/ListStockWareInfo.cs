namespace PddOpenSdk.Models.Request.Stock;
public partial class ListStockWareInfo
{

    /// <summary>
    /// 货品编码集合
    /// </summary>
    [JsonPropertyName("ware_sn_list")]
    public List<string> WareSnList { get; set; }

}

