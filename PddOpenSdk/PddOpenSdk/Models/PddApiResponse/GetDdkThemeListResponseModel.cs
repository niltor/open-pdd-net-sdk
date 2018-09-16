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
public object ThemeListGetResponse {get;set;}

    public partial class ThemeListGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
