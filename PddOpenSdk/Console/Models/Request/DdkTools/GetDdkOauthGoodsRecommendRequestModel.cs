using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.DdkTools
{
public partial class GetDdkOauthGoodsRecommendRequestModel : PddRequestModel
{
/// <summary>
/// 活动商品标记数组，例：[4,7]，4-秒杀，7-百亿补贴，10851-千万补贴，10913-招商礼金商品，31-品牌黑标，10564-精选爆品-官方直推爆款，10584-精选爆品-团长推荐，24-品牌高佣，其他的值请忽略
/// </summary>
[JsonProperty("activity_tags")]
public List<int?> ActivityTags {get;set;}
/// <summary>
/// 猜你喜欢场景的商品类目，20100-百货，20200-母婴，20300-食品，20400-女装，20500-电器，20600-鞋包，20700-内衣，20800-美妆，20900-男装，21000-水果，21100-家纺，21200-文具,21300-运动,21400-虚拟,21500-汽车,21600-家装,21700-家具,21800-医药;
/// </summary>
[JsonProperty("cat_id")]
public long? CatId {get;set;}
/// <summary>
/// 进宝频道推广商品: 1-今日销量榜,3-相似商品推荐,4-猜你喜欢(和进宝网站精选一致),5-实时热销榜,6-实时收益榜。默认值5
/// </summary>
[JsonProperty("channel_type")]
public int? ChannelType {get;set;}
/// <summary>
/// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 为用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 为上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。
/// </summary>
[JsonProperty("custom_parameters")]
public string CustomParameters {get;set;}
/// <summary>
/// 是否使用工具商专属推广计划，默认为false
/// </summary>
[JsonProperty("force_auth_duo_id")]
public bool? ForceAuthDuoId {get;set;}
/// <summary>
/// 商品goodsSign列表，相似商品推荐场景时必传，仅取数组的第一位，例如：["c9r2omogKFFAc7WBwvbZU1ikIb16_J3CTa8HNN"]。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
/// </summary>
[JsonProperty("goods_sign_list")]
public List<string> GoodsSignList {get;set;}
/// <summary>
/// 一页请求数量；默认值 ： 20
/// </summary>
[JsonProperty("limit")]
public int? Limit {get;set;}
/// <summary>
/// 翻页时建议填写前页返回的list_id值
/// </summary>
[JsonProperty("list_id")]
public string ListId {get;set;}
/// <summary>
/// 从多少位置开始请求；默认值 ： 0
/// </summary>
[JsonProperty("offset")]
public int? Offset {get;set;}
/// <summary>
/// 推广位id
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}

}

}
