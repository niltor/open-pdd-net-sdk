namespace PddOpenSdk.Models.Request.Pmc;
public partial class PermitPmcUser
{

    /// <summary>
    /// 消息主题列表，用半角逗号分隔。当用户订阅的topic是应用订阅的子集时才需要设置，不设置表示继承应用所订阅的所有topic，一般情况建议不要设置。
    /// </summary>
    [JsonPropertyName("topics")]
    public string Topics { get; set; }

}

