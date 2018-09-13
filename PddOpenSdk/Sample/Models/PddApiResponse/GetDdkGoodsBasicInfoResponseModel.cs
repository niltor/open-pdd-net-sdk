using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetDdkGoodsBasicInfoResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("goods_basic_detail_response")]
public object GoodsBasicDetailResponse {get;set;}
/// <summary>
/// list
/// </summary>
[JsonProperty("goods_list")]
public object GoodsList {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 最小单买价格，单位分
/// </summary>
[JsonProperty("min_normal_price")]
public int MinNormalPrice {get;set;}
/// <summary>
/// 最小成团价格，单位分
/// </summary>
[JsonProperty("min_group_price")]
public int MinGroupPrice {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("goods_pic")]
public object GoodsPic {get;set;}
/// <summary>
/// 商品标题
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}

    public partial class GoodsBasicDetailResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// list
/// </summary>
[JsonProperty("goods_list")]
public object GoodsList {get;set;}

}

    public partial class GoodsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 最小单买价格，单位分
/// </summary>
[JsonProperty("min_normal_price")]
public int MinNormalPrice {get;set;}
/// <summary>
/// 最小成团价格，单位分
/// </summary>
[JsonProperty("min_group_price")]
public int MinGroupPrice {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("goods_pic")]
public object GoodsPic {get;set;}
/// <summary>
/// 商品标题
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}

}

}
}
