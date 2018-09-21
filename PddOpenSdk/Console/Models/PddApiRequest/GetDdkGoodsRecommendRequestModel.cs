using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetDdkGoodsRecommendRequestModel : PddRequestModel
    {
        /// <summary>
/// 从多少位置开始请求；默认值 ： 0
/// </summary>
[JsonProperty("offset")]
public object Offset {get;set;}
/// <summary>
/// 请求数量；默认值 ： 400
/// </summary>
[JsonProperty("limit")]
public object Limit {get;set;}
/// <summary>
/// 频道类型；0, "1.9包邮", 1, "今日爆款", 2, "品牌清仓", 3, "默认商城", 非必填 ,默认是1
/// </summary>
[JsonProperty("channel_type")]
public int? ChannelType {get;set;}

}
}
