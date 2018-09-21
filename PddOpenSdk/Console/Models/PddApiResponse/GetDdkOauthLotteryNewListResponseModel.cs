using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkOauthLotteryNewListResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回列表
/// </summary>
[JsonProperty("list")]
public ListResponseModel List {get;set;}
/// <summary>
/// 每页数量
/// </summary>
[JsonProperty("page_num")]
public string PageNum {get;set;}
/// <summary>
/// 分页数
/// </summary>
[JsonProperty("page_size")]
public string PageSize {get;set;}
/// <summary>
/// 13
/// </summary>
[JsonProperty("total_count")]
public string TotalCount {get;set;}

    public partial class ListResponseModel : PddResponseModel
    {
        /// <summary>
/// 推广位
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("goods_thumb_url")]
public string GoodsThumbUrl {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public string GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 支付时间
/// </summary>
[JsonProperty("pay_time")]
public string PayTime {get;set;}
/// <summary>
/// 最后更新时间
/// </summary>
[JsonProperty("updated_at")]
public string UpdatedAt {get;set;}
/// <summary>
/// 审核时间
/// </summary>
[JsonProperty("verify_time")]
public string VerifyTime {get;set;}
/// <summary>
/// 订单状态： -1 未支付; 0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算；8-非多多进宝商品（无佣金订单）;10-已处罚
/// </summary>
[JsonProperty("status")]
public int Status {get;set;}
/// <summary>
/// 自定义参数，标志订单来源于哪个自定义参数
/// </summary>
[JsonProperty("custom_parameters")]
public string CustomParameters {get;set;}

}

}
}
