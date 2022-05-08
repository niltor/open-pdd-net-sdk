namespace PddOpenSdk.Models.Request.Ddk;
public partial class UpdateDdkCashgiftStatus
{

    /// <summary>
    /// 多多礼金ID
    /// </summary>
    [JsonPropertyName("cash_gift_id")]
    public long CashGiftId { get; set; }

    /// <summary>
    /// 礼金更新类型：0-停止礼金推广，1-恢复礼金推广
    /// </summary>
    [JsonPropertyName("update_type")]
    public int UpdateType { get; set; }

}

