using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class CreateGoodsLogisticsTemplateRequestModel : PddRequestModel
{
/// <summary>
/// 非包邮模版列表
/// </summary>
[JsonProperty("cost_template_list")]
public List<CostTemplateListRequestModel> CostTemplateList {get;set;}
/// <summary>
/// 包邮地区
/// </summary>
[JsonProperty("free_province_list")]
public List<FreeProvinceListRequestModel> FreeProvinceList {get;set;}
/// <summary>
/// 计费方式，0-按件计费，1-按重量计费
/// </summary>
[JsonProperty("cost_type")]
public int CostType {get;set;}
/// <summary>
/// 运费模板名称
/// </summary>
[JsonProperty("template_name")]
public string TemplateName {get;set;}
/// <summary>
/// 发货地省份id
/// </summary>
[JsonProperty("province_id")]
public int? ProvinceId {get;set;}
/// <summary>
/// 发货地城市id
/// </summary>
[JsonProperty("city_id")]
public int? CityId {get;set;}
/// <summary>
/// 发货地区id
/// </summary>
[JsonProperty("district_id")]
public int? DistrictId {get;set;}
public partial class CostTemplateListRequestModel : PddRequestModel
{
/// <summary>
/// 首件
/// </summary>
[JsonProperty("first_standard")]
public long FirstStandard {get;set;}
/// <summary>
/// 首件或首重价格，单位为分
/// </summary>
[JsonProperty("first_cost")]
public long FirstCost {get;set;}
/// <summary>
/// 续重或续件
/// </summary>
[JsonProperty("add_standard")]
public long AddStandard {get;set;}
/// <summary>
/// 续件或续重价格，单位为分
/// </summary>
[JsonProperty("add_cost")]
public long AddCost {get;set;}
/// <summary>
/// 对不包邮地区，true-若要包邮须满足件数包邮，false-不开启满足件数包邮
/// </summary>
[JsonProperty("is_have_free_min_count")]
public bool IsHaveFreeMinCount {get;set;}
/// <summary>
/// 对不包邮地区，满足指定件数包邮，该值为商家设置的指定件数，若为-1则商家没有开启满足件数包邮
/// </summary>
[JsonProperty("have_free_min_count")]
public int HaveFreeMinCount {get;set;}
/// <summary>
/// 对不包邮地区，true-若要包邮须满足指定价格则可以包邮，false-不开启满足指定价格包邮
/// </summary>
[JsonProperty("is_have_free_min_amount")]
public bool IsHaveFreeMinAmount {get;set;}
/// <summary>
/// 对不包邮地区，满足指定价格包邮，该值为商家设置的指定订单金额，若为-1则商家没有开启满足指定价格包邮，注意，单位为分
/// </summary>
[JsonProperty("have_free_min_amount")]
public long HaveFreeMinAmount {get;set;}
/// <summary>
/// 省份列表
/// </summary>
[JsonProperty("cost_province_list")]
public List<CostProvinceListRequestModel> CostProvinceList {get;set;}
public partial class CostProvinceListRequestModel : PddRequestModel
{
/// <summary>
/// 省份ID
/// </summary>
[JsonProperty("province_id")]
public int ProvinceId {get;set;}

}

}
public partial class FreeProvinceListRequestModel : PddRequestModel
{
/// <summary>
/// 省份ID
/// </summary>
[JsonProperty("province_id")]
public int ProvinceId {get;set;}

}

}

}
