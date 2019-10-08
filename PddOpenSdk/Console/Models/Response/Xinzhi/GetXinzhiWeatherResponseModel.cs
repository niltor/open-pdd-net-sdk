using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Xinzhi
{
public partial class GetXinzhiWeatherResponseModel : PddResponseModel
{
/// <summary>
/// results
/// </summary>
[JsonProperty("results")]
public List<ResultsResponseModel> Results {get;set;}
public partial class ResultsResponseModel : PddResponseModel
{
/// <summary>
/// 位置信息
/// </summary>
[JsonProperty("location")]
public LocationResponseModel Location {get;set;}
/// <summary>
/// now
/// </summary>
[JsonProperty("now")]
public NowResponseModel Now {get;set;}
/// <summary>
/// 数据更新时间（该城市的本地时间）
/// </summary>
[JsonProperty("last_update")]
public string LastUpdate {get;set;}
public partial class LocationResponseModel : PddResponseModel
{
/// <summary>
/// id
/// </summary>
[JsonProperty("id")]
public string Id {get;set;}
/// <summary>
/// 地名
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}
/// <summary>
/// 国家
/// </summary>
[JsonProperty("country")]
public string Country {get;set;}
/// <summary>
/// 地点
/// </summary>
[JsonProperty("path")]
public string Path {get;set;}
/// <summary>
/// 时间
/// </summary>
[JsonProperty("timezone")]
public string Timezone {get;set;}
/// <summary>
/// 时间
/// </summary>
[JsonProperty("timezone_offset")]
public string TimezoneOffset {get;set;}

}
public partial class NowResponseModel : PddResponseModel
{
/// <summary>
/// 天气现象文字
/// </summary>
[JsonProperty("text")]
public string Text {get;set;}
/// <summary>
/// 天气现象代码
/// </summary>
[JsonProperty("code")]
public string Code {get;set;}
/// <summary>
/// 温度，单位为c摄氏度或f华氏度
/// </summary>
[JsonProperty("temperature")]
public string Temperature {get;set;}
/// <summary>
/// 体感温度，单位为c摄氏度或f华氏度
/// </summary>
[JsonProperty("feels_like")]
public string FeelsLike {get;set;}
/// <summary>
/// 压，单位为mb百帕或in英寸
/// </summary>
[JsonProperty("pressure")]
public string Pressure {get;set;}
/// <summary>
/// 相对湿度，0~100，单位为百分比
/// </summary>
[JsonProperty("humidity")]
public string Humidity {get;set;}
/// <summary>
/// 能见度，单位为km公里或mi英里
/// </summary>
[JsonProperty("visibility")]
public string Visibility {get;set;}
/// <summary>
/// 风向文字
/// </summary>
[JsonProperty("wind_direction")]
public string WindDirection {get;set;}
/// <summary>
/// 风向角度，范围0~360，0为正北，90为正东，180为正南，270为正西
/// </summary>
[JsonProperty("wind_direction_degree")]
public string WindDirectionDegree {get;set;}
/// <summary>
/// 风速，单位为km/h公里每小时或mph英里每小时
/// </summary>
[JsonProperty("wind_speed")]
public string WindSpeed {get;set;}
/// <summary>
/// 风力等级，请参考：http://baike.baidu.com/view/465076.htm
/// </summary>
[JsonProperty("wind_scale")]
public string WindScale {get;set;}
/// <summary>
/// 云量，单位%，范围0~100，天空被云覆盖的百分比 #目前不支持中国城市#
/// </summary>
[JsonProperty("clouds")]
public string Clouds {get;set;}
/// <summary>
/// 露点温度，请参考：http://baike.baidu.com/view/118348.htm #目前不支持中国城市#
/// </summary>
[JsonProperty("dew_point")]
public string DewPoint {get;set;}

}

}

}

}
