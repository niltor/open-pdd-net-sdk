using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class GenDdkWeappQrcodeUrlRequestModel : PddRequestModel
{
/// <summary>
/// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
/// </summary>
[JsonProperty("custom_parameters")]
public string CustomParameters {get;set;}
/// <summary>
/// 是否生成店铺收藏券推广链接
/// </summary>
[JsonProperty("generate_mall_collect_coupon")]
public bool? GenerateMallCollectCoupon {get;set;}
/// <summary>
/// 商品ID，仅支持单个查询
/// </summary>
[JsonProperty("goods_id_list")]
public List<long> GoodsIdList {get;set;}
/// <summary>
/// 推广位ID
/// </summary>
[JsonProperty("p_id")]
public string PId {get;set;}
/// <summary>
/// 招商多多客ID
/// </summary>
[JsonProperty("zs_duo_id")]
public long? ZsDuoId {get;set;}
/// <summary>
/// 直播间id列表，如果生成直播间推广链接该参数必填，goods_id_list填[1]
/// </summary>
[JsonProperty("room_id_list")]
public List<string> RoomIdList {get;set;}
/// <summary>
/// 直播预约id列表，如果生成直播间预约推广链接该参数必填，goods_id_list填[1]，room_id_list不填
/// </summary>
[JsonProperty("target_id_list")]
public List<string> TargetIdList {get;set;}

}

}
