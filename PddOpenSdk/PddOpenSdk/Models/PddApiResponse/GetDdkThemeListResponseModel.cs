using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetDdkThemeListResponseModel : PddResponseModel
    {
        /// <summary>
/// 主题列表返回对象
/// </summary>
[JsonProperty("theme_list_get_response")]
public object ThemeListGetResponse {get;set;}
/// <summary>
/// 返回的元素数量
/// </summary>
[JsonProperty("total")]
public int Total {get;set;}
/// <summary>
/// 返回的主题列表
/// </summary>
[JsonProperty("theme_list")]
public object ThemeList {get;set;}
/// <summary>
/// 主题ID
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
/// <summary>
/// 主题图片
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}
/// <summary>
/// 主题名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 主题包含的商品数量
/// </summary>
[JsonProperty("goods_num")]
public object GoodsNum {get;set;}

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
public object ThemeList {get;set;}

}

    public partial class ThemeListResponseModel : PddResponseModel
    {
        /// <summary>
/// 主题ID
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
/// <summary>
/// 主题图片
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}
/// <summary>
/// 主题名称
/// </summary>
[JsonProperty("name")]
public object Name {get;set;}
/// <summary>
/// 主题包含的商品数量
/// </summary>
[JsonProperty("goods_num")]
public object GoodsNum {get;set;}

}

}
}
