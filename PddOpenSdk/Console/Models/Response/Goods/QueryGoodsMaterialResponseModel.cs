using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class QueryGoodsMaterialResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("material_list")]
public List<MaterialListResponseModel> MaterialList {get;set;}
public partial class MaterialListResponseModel : PddResponseModel
{
/// <summary>
/// 申诉审核信息
/// </summary>
[JsonProperty("appeal_check_comment")]
public string AppealCheckComment {get;set;}
/// <summary>
/// 审核信息
/// </summary>
[JsonProperty("check_comment")]
public string CheckComment {get;set;}
/// <summary>
/// 审核状态（1：待审核；2：通过；3：驳回；101：申诉待审核；102：申诉通过；103：申诉驳回）
/// </summary>
[JsonProperty("check_status")]
public int? CheckStatus {get;set;}
/// <summary>
/// 素材内容
/// </summary>
[JsonProperty("content")]
public string Content {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}
/// <summary>
/// 素材id
/// </summary>
[JsonProperty("material_id")]
public long? MaterialId {get;set;}
/// <summary>
/// 线上素材
/// </summary>
[JsonProperty("online_material")]
public string OnlineMaterial {get;set;}
/// <summary>
/// 素材类型（1：白底图；3：长图）
/// </summary>
[JsonProperty("type")]
public int? Type {get;set;}

}

}

}
