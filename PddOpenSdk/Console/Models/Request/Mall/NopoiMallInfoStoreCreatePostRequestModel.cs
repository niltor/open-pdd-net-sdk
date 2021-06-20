using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Mall
{
public partial class NopoiMallInfoStoreCreatePostRequestModel : PddRequestModel
{
/// <summary>
/// 门店营业状态
/// </summary>
[JsonProperty("business_status")]
public int BusinessStatus {get;set;}
/// <summary>
/// 一周营业时间
/// </summary>
[JsonProperty("business_week_list")]
public List<int> BusinessWeekList {get;set;}
/// <summary>
/// 市
/// </summary>
[JsonProperty("city")]
public string City {get;set;}
/// <summary>
/// 区
/// </summary>
[JsonProperty("district")]
public string District {get;set;}
/// <summary>
/// 结束营业时间
/// </summary>
[JsonProperty("end_business_hour")]
public string EndBusinessHour {get;set;}
/// <summary>
/// 门店纬度
/// </summary>
[JsonProperty("poi_latitude")]
public double PoiLatitude {get;set;}
/// <summary>
/// 门店经度
/// </summary>
[JsonProperty("poi_longitude")]
public double PoiLongitude {get;set;}
/// <summary>
/// 省
/// </summary>
[JsonProperty("province")]
public string Province {get;set;}
/// <summary>
/// 起始营业时间
/// </summary>
[JsonProperty("start_business_hour")]
public string StartBusinessHour {get;set;}
/// <summary>
/// 详细地址
/// </summary>
[JsonProperty("store_address")]
public string StoreAddress {get;set;}
/// <summary>
/// 门店名称
/// </summary>
[JsonProperty("store_name")]
public string StoreName {get;set;}
/// <summary>
/// 门店自有编号
/// </summary>
[JsonProperty("store_number")]
public string StoreNumber {get;set;}
/// <summary>
/// 门店电话
/// </summary>
[JsonProperty("store_phone")]
public string StorePhone {get;set;}
/// <summary>
/// 门店行业类型（1-男女装，2-运动户外，3-服饰配件，4-厨具电器，5-汽车，8-全屋定制）
/// </summary>
[JsonProperty("trade_type")]
public int TradeType {get;set;}

}

}
