using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsCountryResponseModel : PddResponseModel
    {
        /// <summary>
/// 国家或地区对象列表
/// </summary>
[JsonProperty("country_list")]
public object CountryList {get;set;}
/// <summary>
/// 国家或地区对应的ID
/// </summary>
[JsonProperty("country_id")]
public int CountryId {get;set;}
/// <summary>
/// 对应ID下的国家或地区名称
/// </summary>
[JsonProperty("country_name")]
public object CountryName {get;set;}

    public partial class CountryListResponseModel : PddResponseModel
    {
        /// <summary>
/// 国家或地区对应的ID
/// </summary>
[JsonProperty("country_id")]
public int CountryId {get;set;}
/// <summary>
/// 对应ID下的国家或地区名称
/// </summary>
[JsonProperty("country_name")]
public object CountryName {get;set;}

}

}
}
