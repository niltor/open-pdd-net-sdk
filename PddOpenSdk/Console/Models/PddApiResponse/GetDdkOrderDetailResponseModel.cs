using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkOrderDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
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
/// 商品缩略图
/// </summary>
[JsonProperty("goods_thumbnail_url")]
public object GoodsThumbnailUrl {get;set;}
/// <summary>
/// 商品数量
/// </summary>
[JsonProperty("goods_quantity")]
public int GoodsQuantity {get;set;}
/// <summary>
/// 商品价格（分）
/// </summary>
[JsonProperty("goods_price")]
public int GoodsPrice {get;set;}
/// <summary>
/// 订单价格（分）
/// </summary>
[JsonProperty("order_amount")]
public int OrderAmount {get;set;}
/// <summary>
/// 佣金比例 千分比
/// </summary>
[JsonProperty("promotion_rate")]
public object PromotionRate {get;set;}
/// <summary>
/// 佣金（分）
/// </summary>
[JsonProperty("promotion_amount")]
public int PromotionAmount {get;set;}
/// <summary>
/// 结算批次号
/// </summary>
[JsonProperty("batch_no")]
public int BatchNo {get;set;}
/// <summary>
/// 订单状态
/// </summary>
[JsonProperty("order_status")]
public int OrderStatus {get;set;}
/// <summary>
/// 订单状态描述（ -1 未支付; 0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算；8-非多多进宝商品（无佣金订单）;10-已处罚）
/// </summary>
[JsonProperty("order_status_desc")]
public object OrderStatusDesc {get;set;}
/// <summary>
/// 订单创建时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_create_time")]
public int OrderCreateTime {get;set;}
/// <summary>
/// 订单支付时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_pay_time")]
public int OrderPayTime {get;set;}
/// <summary>
/// 订单成团时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_group_success_time")]
public int OrderGroupSuccessTime {get;set;}
/// <summary>
/// 订单确认收货时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_receive_time")]
public int OrderReceiveTime {get;set;}
/// <summary>
/// 订单审核时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_verify_time")]
public int OrderVerifyTime {get;set;}
/// <summary>
/// 订单结算时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_settle_time")]
public int OrderSettleTime {get;set;}
/// <summary>
/// 订单最后更新时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_modify_at")]
public int OrderModifyAt {get;set;}
/// <summary>
/// 订单来源 ：0 ：关联，5 ：直接下单页RPC请求
/// </summary>
[JsonProperty("match_channel")]
public int MatchChannel {get;set;}
/// <summary>
/// 订单类型：0：领券页面， 1： 红包页， 2：领券页， 3： 题页
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}
/// <summary>
/// 成团编号
/// </summary>
[JsonProperty("group_id")]
public object GroupId {get;set;}
/// <summary>
/// 多多客工具id
/// </summary>
[JsonProperty("auth_duo_id")]
public object AuthDuoId {get;set;}
/// <summary>
/// 招商多多客id
/// </summary>
[JsonProperty("zs_duo_id")]
public object ZsDuoId {get;set;}
/// <summary>
/// 自定义参数
/// </summary>
[JsonProperty("custom_parameters")]
public object CustomParameters {get;set;}
/// <summary>
/// CPS_Sign
/// </summary>
[JsonProperty("cps_sign")]
public object CpsSign {get;set;}
/// <summary>
/// 链接最后一次生产时间
/// </summary>
[JsonProperty("url_last_generate_time")]
public object UrlLastGenerateTime {get;set;}
/// <summary>
/// 打点时间
/// </summary>
[JsonProperty("point_time")]
public object PointTime {get;set;}
/// <summary>
/// 售后状态：0：无，1：售后中，2：售后完成
/// </summary>
[JsonProperty("return_status")]
public object ReturnStatus {get;set;}
/// <summary>
/// 推广位id
/// </summary>
[JsonProperty("pid")]
public object Pid {get;set;}

}
}
