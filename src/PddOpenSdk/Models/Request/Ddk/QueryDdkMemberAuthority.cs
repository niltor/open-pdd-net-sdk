namespace PddOpenSdk.Models.Request.Ddk;
public partial class QueryDdkMemberAuthority
{

    /// <summary>
    /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。（如果使用GET请求，请使用URLEncode处理参数）
    /// </summary>
    [JsonPropertyName("custom_parameters")]
    public string CustomParameters { get; set; }

    /// <summary>
    /// 推广位id
    /// </summary>
    [JsonPropertyName("pid")]
    public string Pid { get; set; }

}

