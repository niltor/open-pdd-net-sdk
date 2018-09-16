using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class VerificationVoucherVirtualCardResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("voucher_voucher_info_verify_response")]
public object VoucherVoucherInfoVerifyResponse {get;set;}
/// <summary>
/// 拼多多订单号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 商品属性id
/// </summary>
[JsonProperty("sku_id")]
public object SkuId {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}
/// <summary>
/// 券信息数组
/// </summary>
[JsonProperty("voucher_list")]
public object VoucherList {get;set;}
/// <summary>
/// 卡号
/// </summary>
[JsonProperty("card_no")]
public object CardNo {get;set;}
/// <summary>
/// 卡密
/// </summary>
[JsonProperty("card_code")]
public object CardCode {get;set;}
/// <summary>
/// 标准密码
/// </summary>
[JsonProperty("mark_password")]
public object MarkPassword {get;set;}
/// <summary>
/// 状态
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 返回状态
/// </summary>
[JsonProperty("refund_status")]
public object RefundStatus {get;set;}
/// <summary>
/// 验证处
/// </summary>
[JsonProperty("verification_at")]
public object VerificationAt {get;set;}

    public partial class VoucherVoucherInfoVerifyResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 拼多多订单号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public object GoodsId {get;set;}
/// <summary>
/// 商品属性id
/// </summary>
[JsonProperty("sku_id")]
public object SkuId {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}
/// <summary>
/// 券信息数组
/// </summary>
[JsonProperty("voucher_list")]
public object VoucherList {get;set;}

}

    public partial class VoucherListResponseModel : PddResponseModel
    {
        /// <summary>
/// 卡号
/// </summary>
[JsonProperty("card_no")]
public object CardNo {get;set;}
/// <summary>
/// 卡密
/// </summary>
[JsonProperty("card_code")]
public object CardCode {get;set;}
/// <summary>
/// 标准密码
/// </summary>
[JsonProperty("mark_password")]
public object MarkPassword {get;set;}
/// <summary>
/// 状态
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 返回状态
/// </summary>
[JsonProperty("refund_status")]
public object RefundStatus {get;set;}
/// <summary>
/// 验证处
/// </summary>
[JsonProperty("verification_at")]
public object VerificationAt {get;set;}

}

}
}
