using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CreateGoodsCpsUnitResponseModel : PddResponseModel
    {
        /// <summary>
/// 失败原因列表对象，创建成功则此参数为空
/// </summary>
[JsonProperty("失败原因列表对象，创建成功则此参数为空")]
public List<FailedVos> FailedVos {get;set;}
/// <summary>
/// 创建失败的商品id
/// </summary>
[JsonProperty("创建失败的商品id")]
public string GoodsId {get;set;}
/// <summary>
/// 创建失败原因
/// </summary>
[JsonProperty("创建失败原因")]
public string Reason {get;set;}
}
}

    public partial class FailedVosResponseModel : PddResponseModel
    {
        /// <summary>
/// 创建失败的商品id
/// </summary>
[JsonProperty("创建失败的商品id")]
public string GoodsId {get;set;}
/// <summary>
/// 创建失败原因
/// </summary>
[JsonProperty("创建失败原因")]
public string Reason {get;set;}
}


