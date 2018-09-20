using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SearchDdkThemeGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 主题列表返回对象
/// </summary>
[JsonProperty("theme_list_get_response")]
public ThemeListGetResponseResponseModel ThemeListGetResponse {get;set;}

    public partial class ThemeListGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回商品总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}
/// <summary>
/// 商品列表对象
/// </summary>
[JsonProperty("goods_list")]
public GoodsListResponseModel GoodsList {get;set;}

    public partial class GoodsListResponseModel : PddResponseModel
    {
        
}

}

}
}
