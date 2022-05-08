namespace PddOpenSdk.Models.Request.Goods;
public partial class DeleteGoodsMaterial
{

    /// <summary>
    /// 素材id
    /// </summary>
    [JsonPropertyName("material_id")]
    public long MaterialId { get; set; }

}

