using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class RelationGoodsGetResponseModel : PddResponseModel
    {
        /// <summary>
/// 映射关系查询返回对象列表
/// </summary>
[JsonProperty("映射关系查询返回对象列表")]
public [] QueryGoodsRelationResponse {get;set;}
/// <summary>
/// 拼多多商品id
/// </summary>
[JsonProperty("拼多多商品id")]
public long PddGoodsId {get;set;}
/// <summary>
/// 外部平台枚举值， 淘宝/天猫 0，京东1，1688 2，唯品会3，苏宁4，亚马逊,5，网易6，其他7
/// </summary>
[JsonProperty("外部平台枚举值， 淘宝/天猫 0，京东1，1688 2，唯品会3，苏宁4，亚马逊,5，网易6，其他7")]
public integer OutGoodsPlatform {get;set;}
/// <summary>
/// 外部平台商品id
/// </summary>
[JsonProperty("外部平台商品id")]
public long OutGoodsId {get;set;}
}
}

    public partial class QueryGoodsRelationResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 拼多多商品id
/// </summary>
[JsonProperty("拼多多商品id")]
public long PddGoodsId {get;set;}
/// <summary>
/// 外部平台枚举值， 淘宝/天猫 0，京东1，1688 2，唯品会3，苏宁4，亚马逊,5，网易6，其他7
/// </summary>
[JsonProperty("外部平台枚举值， 淘宝/天猫 0，京东1，1688 2，唯品会3，苏宁4，亚马逊,5，网易6，其他7")]
public integer OutGoodsPlatform {get;set;}
/// <summary>
/// 外部平台商品id
/// </summary>
[JsonProperty("外部平台商品id")]
public long OutGoodsId {get;set;}
}


