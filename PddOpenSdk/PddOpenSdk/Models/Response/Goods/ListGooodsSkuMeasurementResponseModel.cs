using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class ListGooodsSkuMeasurementResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("gooods_sku_measurement_list_response")]
public GooodsSkuMeasurementListResponseResponseModel GooodsSkuMeasurementListResponse {get;set;}
public partial class GooodsSkuMeasurementListResponseResponseModel : PddResponseModel
{
/// <summary>
/// 列表
/// </summary>
[JsonProperty("measurement_list")]
public List<MeasurementListResponseModel> MeasurementList {get;set;}
public partial class MeasurementListResponseModel : PddResponseModel
{
/// <summary>
/// 描述
/// </summary>
[JsonProperty("desc")]
public string Desc {get;set;}
/// <summary>
/// 编码
/// </summary>
[JsonProperty("code")]
public string Code {get;set;}

}

}

}

}
