namespace PddOpenSdk.Models.Request.Logistics;
public partial class GetLogisticsOrdertrace
{

    /// <summary>
    /// 1
    /// </summary>
    [JsonPropertyName("company_code")]
    public string CompanyCode { get; set; }

    /// <summary>
    /// 1
    /// </summary>
    [JsonPropertyName("mail_no")]
    public string MailNo { get; set; }

}

