using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Express
{
public partial class UpdateStockDepotPriorityRequestModel : PddRequestModel
{
/// <summary>
/// 示例：[{"depot_id":1,"province_id":12,"city_id":34,"district_id":56,"priority":5}]
/// </summary>
[JsonProperty("priority_list")]
public List<PriorityListRequestModel> PriorityList {get;set;}
public partial class PriorityListRequestModel : PddRequestModel
{
/// <summary>
/// 优先级 范围是1 - 999
/// </summary>
[JsonProperty("priority")]
public int Priority {get;set;}
/// <summary>
/// 区id
/// </summary>
[JsonProperty("district_id")]
public int DistrictId {get;set;}
/// <summary>
/// 市id
/// </summary>
[JsonProperty("city_id")]
public int CityId {get;set;}
/// <summary>
/// 省id
/// </summary>
[JsonProperty("province_id")]
public int ProvinceId {get;set;}
/// <summary>
/// 仓库id
/// </summary>
[JsonProperty("depot_id")]
public long DepotId {get;set;}

}

}

}
