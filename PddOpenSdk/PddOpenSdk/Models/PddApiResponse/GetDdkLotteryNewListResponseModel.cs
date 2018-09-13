using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetDdkLotteryNewListResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回列表
/// </summary>
[JsonProperty("list")]
public object List {get;set;}
/// <summary>
/// 每页订单数量
/// </summary>
[JsonProperty("page_num")]
public object PageNum {get;set;}
/// <summary>
/// 分页数
/// </summary>
[JsonProperty("page_size")]
public object PageSize {get;set;}
/// <summary>
/// 返回总数量
/// </summary>
[JsonProperty("total_count")]
public object TotalCount {get;set;}
/// <summary>
/// 推广位
/// </summary>
[JsonProperty("pid")]
public object Pid {get;set;}
/// <summary>
/// 拉新订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("goods_thumb_url")]
public object GoodsThumbUrl {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 支付时间
/// </summary>
[JsonProperty("pay_time")]
public object PayTime {get;set;}
/// <summary>
/// 最后更新时间
/// </summary>
[JsonProperty("updated_at")]
public object UpdatedAt {get;set;}
/// <summary>
/// 审核时间
/// </summary>
[JsonProperty("verify_time")]
public object VerifyTime {get;set;}
/// <summary>
/// 订单状态： -1 未支付; 0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算；8-非多多进宝商品（无佣金订单）;10-已处罚
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。
/// </summary>
[JsonProperty("custom_parameters")]
public object CustomParameters {get;set;}

    public partial class ListResponseModel : PddResponseModel
    {
        /// <summary>
/// 推广位
/// </summary>
[JsonProperty("pid")]
public object Pid {get;set;}
/// <summary>
/// 拉新订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("goods_thumb_url")]
public object GoodsThumbUrl {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 支付时间
/// </summary>
[JsonProperty("pay_time")]
public object PayTime {get;set;}
/// <summary>
/// 最后更新时间
/// </summary>
[JsonProperty("updated_at")]
public object UpdatedAt {get;set;}
/// <summary>
/// 审核时间
/// </summary>
[JsonProperty("verify_time")]
public object VerifyTime {get;set;}
/// <summary>
/// 订单状态： -1 未支付; 0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算；8-非多多进宝商品（无佣金订单）;10-已处罚
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。
/// </summary>
[JsonProperty("custom_parameters")]
public object CustomParameters {get;set;}

}

}
}
