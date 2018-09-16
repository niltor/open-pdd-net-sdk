using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class ChangeGoodsCpsUnitRequestModel : PddRequestModel
    {
        /// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 佣金比例（千分比）
/// </summary>
[JsonProperty("rate")]
public int Rate {get;set;}
/// <summary>
/// 优惠券id
/// </summary>
[JsonProperty("coupon_id")]
public int? CouponId {get;set;}
/// <summary>
/// 优惠券开始时间（unix时间戳）
/// </summary>
[JsonProperty("coupon_start_time")]
public object CouponStartTime {get;set;}
/// <summary>
/// 优惠券结束时间（unix时间戳）
/// </summary>
[JsonProperty("coupon_end_time")]
public object CouponEndTime {get;set;}
/// <summary>
/// 优惠券面额（单位为分）
/// </summary>
[JsonProperty("discount")]
public int? Discount {get;set;}
/// <summary>
/// 设置的优惠券张数
/// </summary>
[JsonProperty("init_quantity")]
public int? InitQuantity {get;set;}
/// <summary>
/// 优惠券剩余数量
/// </summary>
[JsonProperty("remain_quantity")]
public int? RemainQuantity {get;set;}

}
}
