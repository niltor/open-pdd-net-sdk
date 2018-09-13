using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class SetGoodsRelationRequestModel : PddRequestModel
    {
        /// <summary>
/// 拼多多商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 外部平台商品id
/// </summary>
[JsonProperty("out_goods_id")]
public int OutGoodsId {get;set;}
/// <summary>
/// 外部平台商品url
/// </summary>
[JsonProperty("out_detail_url")]
public object OutDetailUrl {get;set;}
/// <summary>
/// 外部平台商品最低价，单位：分
/// </summary>
[JsonProperty("out_low_goods_price")]
public int OutLowGoodsPrice {get;set;}
/// <summary>
/// 外部平台商品最高价，单位：分
/// </summary>
[JsonProperty("out_high_goods_price")]
public int OutHighGoodsPrice {get;set;}
/// <summary>
/// 外部平台枚举值， 淘宝/天猫 0，京东1，1688 2，唯品会3，苏宁4，亚马逊,5，网易6，其他7
/// </summary>
[JsonProperty("source_type")]
public int SourceType {get;set;}
/// <summary>
/// 邮费
/// </summary>
[JsonProperty("postage")]
public int Postage {get;set;}

}
}
