namespace PddOpenSdk.Models.Request.Goods;
public partial class GetGoodsFileInfo
{

    /// <summary>
    /// url列表
    /// </summary>
    [JsonPropertyName("url_list")]
    public List<string> UrlList { get; set; }

}

