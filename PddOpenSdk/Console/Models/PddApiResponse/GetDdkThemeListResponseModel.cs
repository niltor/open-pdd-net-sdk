using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkThemeListResponseModel : PddResponseModel
    {
        /// <summary>
/// 主题列表返回对象
/// </summary>
[JsonProperty("theme_list_get_response")]
public ThemeListGetResponseResponseModel ThemeListGetResponse {get;set;}

    public partial class ThemeListGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回的元素数量
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 返回的主题列表
/// </summary>
[JsonProperty("theme_list")]
public ThemeListResponseModel ThemeList {get;set;}

    public partial class ThemeListResponseModel : PddResponseModel
    {
        
}

}

}
}
