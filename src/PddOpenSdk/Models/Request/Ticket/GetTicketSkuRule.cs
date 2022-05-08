namespace PddOpenSdk.Models.Request.Ticket;
public partial class GetTicketSkuRule
{

    /// <summary>
    /// 商户履约规则 id
    /// </summary>
    [JsonPropertyName("out_rule_id")]
    public string OutRuleId { get; set; }

    /// <summary>
    /// 上传商品的上传序列 ID
    /// </summary>
    [JsonPropertyName("rule_id")]
    public string RuleId { get; set; }

}

