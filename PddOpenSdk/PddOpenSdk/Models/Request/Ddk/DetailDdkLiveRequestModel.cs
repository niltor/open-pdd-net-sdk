using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class DetailDdkLiveRequestModel : PddRequestModel
{
/// <summary>
/// 分页数
/// </summary>
[JsonProperty("goods_page")]
public int? GoodsPage {get;set;}
/// <summary>
/// 每页商品数量
/// </summary>
[JsonProperty("goods_page_size")]
public int? GoodsPageSize {get;set;}
/// <summary>
/// 是否返回商品信息，默认true
/// </summary>
[JsonProperty("need_goods_info")]
public bool? NeedGoodsInfo {get;set;}
/// <summary>
/// 直播间id
/// </summary>
[JsonProperty("room_id")]
public string RoomId {get;set;}

}

}
