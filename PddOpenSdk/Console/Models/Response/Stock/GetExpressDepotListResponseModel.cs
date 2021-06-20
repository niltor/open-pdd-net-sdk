using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Stock
{
public partial class GetExpressDepotListResponseModel : PddResponseModel
{
/// <summary>
/// 返回结果
/// </summary>
[JsonProperty("open_api_response")]
public OpenApiResponseResponseModel OpenApiResponse {get;set;}
public partial class OpenApiResponseResponseModel : PddResponseModel
{
/// <summary>
/// 仓库数量
/// </summary>
[JsonProperty("count")]
public int? Count {get;set;}
/// <summary>
/// 仓库列表
/// </summary>
[JsonProperty("depot_list")]
public List<DepotListResponseModel> DepotList {get;set;}
public partial class DepotListResponseModel : PddResponseModel
{
/// <summary>
/// 仓库详细地址
/// </summary>
[JsonProperty("address")]
public string Address {get;set;}
/// <summary>
/// 仓库别名
/// </summary>
[JsonProperty("alias")]
public string Alias {get;set;}
/// <summary>
/// 仓库所在市
/// </summary>
[JsonProperty("city")]
public int? City {get;set;}
/// <summary>
/// 仓库编码
/// </summary>
[JsonProperty("code")]
public string Code {get;set;}
/// <summary>
/// 联系人名字
/// </summary>
[JsonProperty("contact_name")]
public string ContactName {get;set;}
/// <summary>
/// 联系人电话
/// </summary>
[JsonProperty("contact_tel")]
public string ContactTel {get;set;}
/// <summary>
/// 仓库Id
/// </summary>
[JsonProperty("depot_id")]
public long? DepotId {get;set;}
/// <summary>
/// 仓库所在区
/// </summary>
[JsonProperty("district")]
public int? District {get;set;}
/// <summary>
/// 仓库Id2
/// </summary>
[JsonProperty("id_str")]
public string IdStr {get;set;}
/// <summary>
/// 仓库名称
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}
/// <summary>
/// 仓库所在省
/// </summary>
[JsonProperty("province")]
public int? Province {get;set;}
/// <summary>
/// 覆盖信息,key是覆盖的省id;value中1表示局部，2表示全部覆盖
/// </summary>
[JsonProperty("province_map")]
public Dictionary<string, object> ProvinceMap {get;set;}
/// <summary>
/// 仓库类型
/// </summary>
[JsonProperty("type")]
public int? Type {get;set;}
/// <summary>
/// 邮编
/// </summary>
[JsonProperty("zip")]
public string Zip {get;set;}
public partial class ProvinceMapResponseModel : PddResponseModel
{
/// <summary>
/// 省份id
/// </summary>
[JsonProperty("key")]
public string Key {get;set;}
/// <summary>
/// 1表示局部，2表示全部覆盖
/// </summary>
[JsonProperty("value")]
public int? Value {get;set;}

}

}

}

}

}
