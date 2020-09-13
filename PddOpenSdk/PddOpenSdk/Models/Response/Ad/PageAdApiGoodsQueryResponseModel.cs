using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class PageAdApiGoodsQueryResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("response")]
public ResponseResponseModel Response {get;set;}
public partial class ResponseResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("errorCode")]
public int? ErrorCode {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("errorMsg")]
public string ErrorMsg {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("result")]
public ResultResponseModel Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("success")]
public bool? Success {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 
/// </summary>
[JsonProperty("result")]
public List<ResultResponseModel> Result {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("total")]
public long? Total {get;set;}
public partial class ResultResponseModel : PddResponseModel
{
/// <summary>
/// 商品类目Id
/// </summary>
[JsonProperty("catId")]
public long? CatId {get;set;}
/// <summary>
/// 商品类目名称
/// </summary>
[JsonProperty("catName")]
public string CatName {get;set;}
/// <summary>
/// 商品Id
/// </summary>
[JsonProperty("goodsId")]
public long? GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goodsName")]
public string GoodsName {get;set;}
/// <summary>
/// 商品最小团购价
/// </summary>
[JsonProperty("minGroupPrice")]
public long? MinGroupPrice {get;set;}
/// <summary>
/// 商品库存
/// </summary>
[JsonProperty("quantity")]
public long? Quantity {get;set;}
/// <summary>
/// 商品销量
/// </summary>
[JsonProperty("soldQuantity")]
public long? SoldQuantity {get;set;}
/// <summary>
/// 商品图片链接
/// </summary>
[JsonProperty("thumbUrl")]
public string ThumbUrl {get;set;}

}

}

}

}

}
