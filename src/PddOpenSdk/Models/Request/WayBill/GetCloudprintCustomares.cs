namespace PddOpenSdk.Models.Request.WayBill;
public partial class GetCloudprintCustomares
{

    /// <summary>
    /// 即pdd.cloudprint.stdtemplates.get接口返回的standard_template_id
    /// </summary>
    [JsonPropertyName("template_id")]
    public int TemplateId { get; set; }

}

