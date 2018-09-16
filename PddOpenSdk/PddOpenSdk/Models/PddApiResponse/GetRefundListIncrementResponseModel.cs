using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetRefundListIncrementResponseModel : PddResponseModel
    {
        /// <summary>
/// 售后增量订单列表对象
/// </summary>
[JsonProperty("refund_increment_get_response")]
public object RefundIncrementGetResponse {get;set;}
/// <summary>
/// 返回的售后订单列表总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}
/// <summary>
/// 售后列表对象
/// </summary>
[JsonProperty("refund_list")]
public object RefundList {get;set;}
/// <summary>
/// 售后编号
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 成团时间
/// </summary>
[JsonProperty("confirm_time")]
public object ConfirmTime {get;set;}
/// <summary>
/// 售后原因
/// </summary>
[JsonProperty("after_sale_reason")]
public object AfterSaleReason {get;set;}
/// <summary>
/// 售后状态
/// </summary>
[JsonProperty("after_sales_status")]
public int AfterSalesStatus {get;set;}
/// <summary>
/// 售后类型
/// </summary>
[JsonProperty("after_sales_type")]
public int AfterSalesType {get;set;}
/// <summary>
/// 订单金额（元）
/// </summary>
[JsonProperty("order_amount")]
public int OrderAmount {get;set;}
/// <summary>
/// 退款金额（元）
/// </summary>
[JsonProperty("refund_amount")]
public int RefundAmount {get;set;}
/// <summary>
/// 商品规格ID
/// </summary>
[JsonProperty("sku_id")]
public int SkuId {get;set;}
/// <summary>
/// 商家外部编码（sku）
/// </summary>
[JsonProperty("outer_id")]
public object OuterId {get;set;}
/// <summary>
/// 商家外部编码（商品）
/// </summary>
[JsonProperty("outer_goods_id")]
public object OuterGoodsId {get;set;}
/// <summary>
/// 订单折扣金额（元）
/// </summary>
[JsonProperty("discount_amount")]
public int DiscountAmount {get;set;}
/// <summary>
/// 商品单价
/// </summary>
[JsonProperty("goods_price")]
public int GoodsPrice {get;set;}
/// <summary>
/// 商品数量
/// </summary>
[JsonProperty("goods_number")]
public int GoodsNumber {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 商品图片
/// </summary>
[JsonProperty("good_image")]
public object GoodImage {get;set;}
/// <summary>
/// 快递运单号
/// </summary>
[JsonProperty("tracking_number")]
public object TrackingNumber {get;set;}
/// <summary>
/// 创建时间
/// </summary>
[JsonProperty("created_time")]
public object CreatedTime {get;set;}
/// <summary>
/// 更新时间
/// </summary>
[JsonProperty("updated_time")]
public object UpdatedTime {get;set;}

    public partial class RefundIncrementGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回的售后订单列表总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}
/// <summary>
/// 售后列表对象
/// </summary>
[JsonProperty("refund_list")]
public object RefundList {get;set;}

}

    public partial class RefundListResponseModel : PddResponseModel
    {
        /// <summary>
/// 售后编号
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 成团时间
/// </summary>
[JsonProperty("confirm_time")]
public object ConfirmTime {get;set;}
/// <summary>
/// 售后原因
/// </summary>
[JsonProperty("after_sale_reason")]
public object AfterSaleReason {get;set;}
/// <summary>
/// 售后状态
/// </summary>
[JsonProperty("after_sales_status")]
public int AfterSalesStatus {get;set;}
/// <summary>
/// 售后类型
/// </summary>
[JsonProperty("after_sales_type")]
public int AfterSalesType {get;set;}
/// <summary>
/// 订单金额（元）
/// </summary>
[JsonProperty("order_amount")]
public int OrderAmount {get;set;}
/// <summary>
/// 退款金额（元）
/// </summary>
[JsonProperty("refund_amount")]
public int RefundAmount {get;set;}
/// <summary>
/// 商品规格ID
/// </summary>
[JsonProperty("sku_id")]
public int SkuId {get;set;}
/// <summary>
/// 商家外部编码（sku）
/// </summary>
[JsonProperty("outer_id")]
public object OuterId {get;set;}
/// <summary>
/// 商家外部编码（商品）
/// </summary>
[JsonProperty("outer_goods_id")]
public object OuterGoodsId {get;set;}
/// <summary>
/// 订单折扣金额（元）
/// </summary>
[JsonProperty("discount_amount")]
public int DiscountAmount {get;set;}
/// <summary>
/// 商品单价
/// </summary>
[JsonProperty("goods_price")]
public int GoodsPrice {get;set;}
/// <summary>
/// 商品数量
/// </summary>
[JsonProperty("goods_number")]
public int GoodsNumber {get;set;}
/// <summary>
/// 商品编码
/// </summary>
[JsonProperty("goods_id")]
public int GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 商品图片
/// </summary>
[JsonProperty("good_image")]
public object GoodImage {get;set;}
/// <summary>
/// 快递运单号
/// </summary>
[JsonProperty("tracking_number")]
public object TrackingNumber {get;set;}
/// <summary>
/// 创建时间
/// </summary>
[JsonProperty("created_time")]
public object CreatedTime {get;set;}
/// <summary>
/// 更新时间
/// </summary>
[JsonProperty("updated_time")]
public object UpdatedTime {get;set;}

}

}
}
