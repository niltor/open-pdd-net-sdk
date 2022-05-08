namespace PddOpenSdk.Models.Request.Virtual;
public partial class QueryVirtualGameServer
{

    /// <summary>
    /// 游戏CODE
    /// </summary>
    [JsonPropertyName("goods_config_code")]
    public string GoodsConfigCode { get; set; }

}

