using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class QueryGoodsCpsUnitResponseModel : PddResponseModel
    {
        /// <summary>
/// 单品推广计划单元id
/// </summary>
[JsonProperty("单品推广计划单元id")]
public string UnitId {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("商品id")]
public string GoodsId {get;set;}
/// <summary>
/// 佣金比例（千分比）
/// </summary>
[JsonProperty("佣金比例（千分比）")]
public int Rate {get;set;}
/// <summary>
/// 修改后第二天生效的佣金费率（千分比）
/// </summary>
[JsonProperty("修改后第二天生效的佣金费率（千分比）")]
public int RateToBe {get;set;}
/// <summary>
/// 商品状态，1-推广中，2-暂停，3-删除
/// </summary>
[JsonProperty("商品状态，1-推广中，2-暂停，3-删除")]
public string Status {get;set;}
/// <summary>
/// 修改后第二天生效的状态，1-推广中，2-暂停，3-删除
/// </summary>
[JsonProperty("修改后第二天生效的状态，1-推广中，2-暂停，3-删除")]
public string StatusToBe {get;set;}
/// <summary>
/// 计划使用的优惠券信息。商品没有优惠券将返回null，有优惠券将返回优惠券信息，包括优惠券起始结束时间，优惠券数量，剩余数量，金额等
/// </summary>
[JsonProperty("计划使用的优惠券信息。商品没有优惠券将返回null，有优惠券将返回优惠券信息，包括优惠券起始结束时间，优惠券数量，剩余数量，金额等")]
public string CouponVo {get;set;}
}
}

