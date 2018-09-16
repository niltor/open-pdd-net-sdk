using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetMallInfoResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("mall_info_get_response")]
public object MallInfoGetResponse {get;set;}
/// <summary>
/// 店铺logo
/// </summary>
[JsonProperty("logo")]
public object Logo {get;set;}
/// <summary>
/// 店铺名称
/// </summary>
[JsonProperty("mall_name")]
public object MallName {get;set;}
/// <summary>
/// 店铺描述
/// </summary>
[JsonProperty("mall_desc")]
public object MallDesc {get;set;}

    public partial class MallInfoGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 店铺logo
/// </summary>
[JsonProperty("logo")]
public object Logo {get;set;}
/// <summary>
/// 店铺名称
/// </summary>
[JsonProperty("mall_name")]
public object MallName {get;set;}
/// <summary>
/// 店铺描述
/// </summary>
[JsonProperty("mall_desc")]
public object MallDesc {get;set;}

}

}
}
