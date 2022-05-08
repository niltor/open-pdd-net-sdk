namespace PddOpenSdk.Models.Request.Order;
public partial class GetOrderPromiseInfo
{

    /// <summary>
    /// 承诺id
    /// </summary>
    [JsonPropertyName("promise_id")]
    public long PromiseId { get; set; }

}

