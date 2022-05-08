namespace PddOpenSdk.Models.Response.Goods;
public partial class ChangeGoodsCpsUnitResponse : PddResponseModel
{

    /// <summary>
    /// 是否修改成功
    /// </summary>
    [JsonPropertyName("is_change_success")]
    public bool? IsChangeSuccess { get; set; }

}

