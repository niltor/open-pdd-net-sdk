namespace PddOpenSdk.Models.Request.Ddk;
public partial class GenerateDdkGoodsPid
{

    /// <summary>
    /// 要生成的推广位数量，默认为10，范围为：1~100
    /// </summary>
    [JsonPropertyName("number")]
    public long Number { get; set; }

    /// <summary>
    /// 推广位名称，例如["1","2"]
    /// </summary>
    [JsonPropertyName("p_id_name_list")]
    public List<string> PIdNameList { get; set; }

    /// <summary>
    /// 媒体id
    /// </summary>
    [JsonPropertyName("media_id")]
    public long? MediaId { get; set; }

}

