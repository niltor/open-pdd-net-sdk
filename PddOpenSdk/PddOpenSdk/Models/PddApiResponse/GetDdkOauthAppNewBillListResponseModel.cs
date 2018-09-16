using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkOauthAppNewBillListResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多客拉新的奖励账单返回对象
/// </summary>
[JsonProperty("app_new_bill_list_response")]
public object AppNewBillListResponse {get;set;}
/// <summary>
/// 账单列表对象
/// </summary>
[JsonProperty("list")]
public object List {get;set;}
/// <summary>
/// 请求到的结果数
/// </summary>
[JsonProperty("total_count")]
public object TotalCount {get;set;}
/// <summary>
/// 推广位ID
/// </summary>
[JsonProperty("pid")]
public object Pid {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public int OrderSn {get;set;}
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
/// 商品名
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 奖励金额
/// </summary>
[JsonProperty("money")]
public object Money {get;set;}
/// <summary>
/// 结算时间
/// </summary>
[JsonProperty("pay_time")]
public int PayTime {get;set;}
/// <summary>
/// 更新时间
/// </summary>
[JsonProperty("updated_at")]
public int UpdatedAt {get;set;}
/// <summary>
/// 审核时间
/// </summary>
[JsonProperty("verify_time")]
public int VerifyTime {get;set;}
/// <summary>
/// 状态：0-未审核、1-审核通过、2-审核失败、3-已结算
/// </summary>
[JsonProperty("status")]
public object Status {get;set;}
/// <summary>
/// 自定义参数
/// </summary>
[JsonProperty("custom_parameters")]
public object CustomParameters {get;set;}

    public partial class AppNewBillListResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 账单列表对象
/// </summary>
[JsonProperty("list")]
public object List {get;set;}
/// <summary>
/// 请求到的结果数
/// </summary>
[JsonProperty("total_count")]
public object TotalCount {get;set;}

}

    public partial class ListResponseModel : PddResponseModel
    {
        /// <summary>
/// 推广位ID
/// </summary>
[JsonProperty("pid")]
public object Pid {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public int OrderSn {get;set;}
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
/// 商品名
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 奖励金额
/// </summary>
[JsonProperty("money")]
public object Money {get;set;}
/// <summary>
/// 结算时间
/// </summary>
[JsonProperty("pay_time")]
public int PayTime {get;set;}
/// <summary>
/// 更新时间
/// </summary>
[JsonProperty("updated_at")]
public int UpdatedAt {get;set;}
/// <summary>
/// 审核时间
/// </summary>
[JsonProperty("verify_time")]
public int VerifyTime {get;set;}
/// <summary>
/// 状态：0-未审核、1-审核通过、2-审核失败、3-已结算
/// </summary>
[JsonProperty("status")]
public object Status {get;set;}
/// <summary>
/// 自定义参数
/// </summary>
[JsonProperty("custom_parameters")]
public object CustomParameters {get;set;}

}

}
}
