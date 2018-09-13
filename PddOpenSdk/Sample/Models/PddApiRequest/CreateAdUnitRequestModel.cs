using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class CreateAdUnitRequestModel : PddRequestModel
    {
        /// <summary>
/// 0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）
/// </summary>
[JsonProperty("scene_type")]
public int SceneType {get;set;}
/// <summary>
/// 计划id
/// </summary>
[JsonProperty("plan_id")]
public string PlanId {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// [{"word":"test","bid":200}]
/// </summary>
[JsonProperty("keywords")]
public string Keywords {get;set;}
/// <summary>
/// 关键字出价（厘）范围需在0.10~99.0元区间内
/// </summary>
[JsonProperty("bid")]
public int Bid {get;set;}
/// <summary>
/// 关键词
/// </summary>
[JsonProperty("word")]
public string Word {get;set;}
}
}

    public partial class KeywordsRequestModel : PddRequestModel
    {
        /// <summary>
/// 关键字出价（厘）范围需在0.10~99.0元区间内
/// </summary>
[JsonProperty("bid")]
public int Bid {get;set;}
/// <summary>
/// 关键词
/// </summary>
[JsonProperty("word")]
public string Word {get;set;}
}


