using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsSellSettingDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_sell_setting_detail_query_response")]
public SmsSellSettingDetailQueryResponseResponseModel SmsSellSettingDetailQueryResponse {get;set;}

    public partial class SmsSellSettingDetailQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 模板id
/// </summary>
[JsonProperty("template_id")]
public string TemplateId {get;set;}
/// <summary>
/// 模版内容
/// </summary>
[JsonProperty("template_content")]
public string TemplateContent {get;set;}
/// <summary>
/// 发送时间
/// </summary>
[JsonProperty("send_time")]
public string SendTime {get;set;}
/// <summary>
/// 是否开启 1-开启 0-关闭
/// </summary>
[JsonProperty("open")]
public int Open {get;set;}
/// <summary>
/// 实际发送记录
/// </summary>
[JsonProperty("send_num")]
public int SendNum {get;set;}
/// <summary>
/// 人群id
/// </summary>
[JsonProperty("crowd_id")]
public string CrowdId {get;set;}
/// <summary>
/// 人群
/// </summary>
[JsonProperty("crowd")]
public CrowdResponseModel Crowd {get;set;}
/// <summary>
/// 任务id
/// </summary>
[JsonProperty("id")]
public string Id {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public string MallId {get;set;}
/// <summary>
/// 设置类型
/// </summary>
[JsonProperty("scene")]
public int Scene {get;set;}
/// <summary>
/// 触发状态
/// </summary>
[JsonProperty("trigger_condition")]
public int TriggerCondition {get;set;}
/// <summary>
/// 目标
/// </summary>
[JsonProperty("target")]
public TargetResponseModel Target {get;set;}

    public partial class CrowdResponseModel : PddResponseModel
    {
        /// <summary>
/// 人群名称
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}
/// <summary>
/// 人群数量
/// </summary>
[JsonProperty("people_num")]
public int PeopleNum {get;set;}
/// <summary>
/// 人群
/// </summary>
[JsonProperty("crowd")]
public CrowdResponseModel Crowd {get;set;}

    public partial class CrowdResponseModel : PddResponseModel
    {
        /// <summary>
/// 定位类型
/// </summary>
[JsonProperty("location_type")]
public int LocationType {get;set;}
/// <summary>
/// 选自定义的时候列表存省代表的id
/// </summary>
[JsonProperty("location")]
public int Location {get;set;}
/// <summary>
/// 性别
/// </summary>
[JsonProperty("gender")]
public int Gender {get;set;}
/// <summary>
/// 店铺有购买天数
/// </summary>
[JsonProperty("purchase_days")]
public int PurchaseDays {get;set;}
/// <summary>
/// 店铺无购买天数
/// </summary>
[JsonProperty("none_purchase_days")]
public int NonePurchaseDays {get;set;}
/// <summary>
/// 商品收藏天数
/// </summary>
[JsonProperty("goods_favor_days")]
public int GoodsFavorDays {get;set;}
/// <summary>
/// 店铺收藏天数
/// </summary>
[JsonProperty("mall_favor_days")]
public int MallFavorDays {get;set;}
/// <summary>
/// 历史订单最小成交次数
/// </summary>
[JsonProperty("min_order_count")]
public int MinOrderCount {get;set;}
/// <summary>
/// 历史订单最大成交次数
/// </summary>
[JsonProperty("max_order_count")]
public int MaxOrderCount {get;set;}
/// <summary>
/// 首次购买开始时间
/// </summary>
[JsonProperty("first_buy_start_time")]
public int FirstBuyStartTime {get;set;}
/// <summary>
/// 首次购买结束时间
/// </summary>
[JsonProperty("first_buy_end_time")]
public int FirstBuyEndTime {get;set;}
/// <summary>
/// 店铺有访问天数
/// </summary>
[JsonProperty("mall_visit_days")]
public int MallVisitDays {get;set;}
/// <summary>
/// 店铺无访问天数
/// </summary>
[JsonProperty("mall_none_visit_days")]
public int MallNoneVisitDays {get;set;}

}

}

    public partial class TargetResponseModel : PddResponseModel
    {
        /// <summary>
/// 实付金额最低价
/// </summary>
[JsonProperty("min_pay_amount")]
public int MinPayAmount {get;set;}
/// <summary>
/// 实付金额最高价
/// </summary>
[JsonProperty("max_pay_amount")]
public int MaxPayAmount {get;set;}
/// <summary>
/// 是否不限
/// </summary>
[JsonProperty("pay_amount_limit")]
public int PayAmountLimit {get;set;}
/// <summary>
/// 性别
/// </summary>
[JsonProperty("sex")]
public int Sex {get;set;}
/// <summary>
/// 收获地区
/// </summary>
[JsonProperty("region")]
public string Region {get;set;}
/// <summary>
/// 地区类型
/// </summary>
[JsonProperty("region_type")]
public int RegionType {get;set;}
/// <summary>
/// 订单开始时间
/// </summary>
[JsonProperty("order_start_time")]
public int OrderStartTime {get;set;}
/// <summary>
/// 订单结束时间
/// </summary>
[JsonProperty("order_end_time")]
public int OrderEndTime {get;set;}
/// <summary>
/// 订单时间类型
/// </summary>
[JsonProperty("order_time_type")]
public int OrderTimeType {get;set;}
/// <summary>
/// 预计发送人数
/// </summary>
[JsonProperty("people_num")]
public int PeopleNum {get;set;}

}

}

}
}
