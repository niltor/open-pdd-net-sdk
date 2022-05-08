namespace PddOpenSdk.Models.Response.Goods;
public partial class CreateGoodsCpsMallUnitResponse : PddResponseModel
{

    /// <summary>
    /// 是否创建成功
    /// </summary>
    [JsonPropertyName("is_create_success")]
    public bool? IsCreateSuccess { get; set; }

}

