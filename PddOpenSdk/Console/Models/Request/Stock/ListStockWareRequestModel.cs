using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Stock
{
public partial class ListStockWareRequestModel : PddRequestModel
{
/// <summary>
/// 货品id
/// </summary>
[JsonProperty("id")]
public long? Id {get;set;}
/// <summary>
/// 货品编码
/// </summary>
[JsonProperty("ware_sn")]
public string WareSn {get;set;}
/// <summary>
/// 货品名称
/// </summary>
[JsonProperty("ware_name")]
public string WareName {get;set;}
/// <summary>
/// 类型 0:单独货品。1:组合货品
/// </summary>
[JsonProperty("ware_type")]
public int? WareType {get;set;}
/// <summary>
/// 页数，从1开始
/// </summary>
[JsonProperty("page")]
public int Page {get;set;}
/// <summary>
/// 每页记录数
/// </summary>
[JsonProperty("size")]
public int Size {get;set;}

}

}
