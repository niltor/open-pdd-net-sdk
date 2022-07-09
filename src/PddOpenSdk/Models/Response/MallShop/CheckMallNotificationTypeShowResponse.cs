namespace PddOpenSdk.Models.Response.MallShop;
public partial class CheckMallNotificationTypeShowResponse : PddResponseModel
{

    /// <summary>
    /// 是否展示通知：true-展示,false-不展示
    /// </summary>
    [JsonPropertyName("result")]
    public bool? Result { get; set; }

}

