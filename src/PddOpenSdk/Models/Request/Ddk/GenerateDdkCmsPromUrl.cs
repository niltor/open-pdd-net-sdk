namespace PddOpenSdk.Models.Request.Ddk;
public partial class GenerateDdkCmsPromUrl
{

    /// <summary>
    /// 0, "1.9包邮"；1, "今日爆款"； 2, "品牌清仓"； 4,"PC端专属商城"；不传值为默认商城
    /// </summary>
    [JsonPropertyName("channel_type")]
    public int? ChannelType { get; set; }

    /// <summary>
    /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。（如果使用GET请求，请使用URLEncode处理参数）
    /// </summary>
    [JsonPropertyName("custom_parameters")]
    public string CustomParameters { get; set; }

    /// <summary>
    /// 是否生成手机跳转链接。true-是，false-否，默认false
    /// </summary>
    [JsonPropertyName("generate_mobile")]
    public bool? GenerateMobile { get; set; }

    /// <summary>
    /// 是否返回 schema URL
    /// </summary>
    [JsonPropertyName("generate_schema_url")]
    public bool? GenerateSchemaUrl { get; set; }

    /// <summary>
    /// 是否生成短链接，true-是，false-否
    /// </summary>
    [JsonPropertyName("generate_short_url")]
    public bool? GenerateShortUrl { get; set; }

    /// <summary>
    /// 是否生成拼多多福利券微信小程序推广信息
    /// </summary>
    [JsonPropertyName("generate_we_app")]
    public bool? GenerateWeApp { get; set; }

    /// <summary>
    /// 搜索关键词
    /// </summary>
    [JsonPropertyName("keyword")]
    public string Keyword { get; set; }

    /// <summary>
    /// 单人团多人团标志。true-多人团，false-单人团 默认false
    /// </summary>
    [JsonPropertyName("multi_group")]
    public bool? MultiGroup { get; set; }

    /// <summary>
    /// 推广位列表，例如：["60005_612"]
    /// </summary>
    [JsonPropertyName("p_id_list")]
    public List<string> PIdList { get; set; }

}

