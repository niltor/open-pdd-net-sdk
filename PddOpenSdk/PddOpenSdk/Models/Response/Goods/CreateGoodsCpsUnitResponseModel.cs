using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class CreateGoodsCpsUnitResponseModel : PddResponseModel
{
/// <summary>
/// 失败原因列表对象，创建成功则此参数为空
/// </summary>
[JsonProperty("failed_vos")]
public List<FailedVosResponseModel> FailedVos {get;set;}
public partial class FailedVosResponseModel : PddResponseModel
{
/// <summary>
/// 创建失败的商品id
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}
/// <summary>
/// 创建失败原因
/// </summary>
[JsonProperty("reason")]
public string Reason {get;set;}

}

}

}
