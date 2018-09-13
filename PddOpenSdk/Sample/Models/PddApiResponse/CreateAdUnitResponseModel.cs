using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CreateAdUnitResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_unit_create_response")]
public object AdUnitCreateResponse {get;set;}
/// <summary>
/// 单元id
/// </summary>
[JsonProperty("unit_id")]
public int UnitId {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

    public partial class AdUnitCreateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 单元id
/// </summary>
[JsonProperty("unit_id")]
public int UnitId {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

}

}
}
