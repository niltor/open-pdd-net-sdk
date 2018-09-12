using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class SmsApiRequest : PddRequest {
        /// <summary>
/// 查询人群数量
/// </summary>
/// <param name="CrowdId">人群id</param>
/// <param name="LocationType">//0-全部 1-江浙沪 2-自定义</param>
/// <param name="Location">[1,34] //  //选自定义的时候列表存省代表的id</param>
/// <param name="Gender">//0-全部 1-男 2-女</param>
/// <param name="PurchaseDays">店铺有购买天数</param>
/// <param name="NonePurchaseDays">店铺无购买天数</param>
/// <param name="GoodsFavorDays">收藏物品天数</param>
/// <param name="MallFavorDays">收藏店铺天数</param>
/// <param name="MinOrderCount">历史订单成交次数</param>
/// <param name="MaxOrderCount">历史订单成交次数</param>
/// <param name="FirstBuyStartTime">第一次购买时间</param>
/// <param name="FirstBuyEndTime">最后一次购买时间</param>
/// <param name="MallVisitDays">店铺有访问天数</param>
public async Task<QuerySmsCrowdsPeopleNumberApiResult> QuerySmsCrowdsPeopleNumberAsync(int CrowdId,int LocationType,string Location,int Gender,int PurchaseDays,int NonePurchaseDays,int GoodsFavorDays,int MallFavorDays,int MinOrderCount,int MaxOrderCount,string FirstBuyStartTime,string FirstBuyEndTime,int MallVisitDays)
{
    var dic = new Dictionary<string, string>();
    dic.Add("crowd_id",CrowdId);
dic.Add("location_type",LocationType);
dic.Add("location",Location);
dic.Add("gender",Gender);
dic.Add("purchase_days",PurchaseDays);
dic.Add("none_purchase_days",NonePurchaseDays);
dic.Add("goods_favor_days",GoodsFavorDays);
dic.Add("mall_favor_days",MallFavorDays);
dic.Add("min_order_count",MinOrderCount);
dic.Add("max_order_count",MaxOrderCount);
dic.Add("first_buy_start_time",FirstBuyStartTime);
dic.Add("first_buy_end_time",FirstBuyEndTime);
dic.Add("mall_visit_days",MallVisitDays);
    
    var result = Post<QuerySmsCrowdsPeopleNumberApiResult>("pdd.sms.crowds.people.number.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsCrowdsPeopleNumberApiResult>(result);
}/// <summary>
/// 查询人群列表
/// </summary>
/// <param name="CrowsType">//人群类型选择  1-推荐人群（官方）  2-自定义人群  不传-全部</param>
/// <param name="PageNumber">页码</param>
/// <param name="PageSize">每页条目数</param>
public async Task<QuerySmsCrowdsApiResult> QuerySmsCrowdsAsync(int CrowsType,int PageNumber,int PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("crows_type",CrowsType);
dic.Add("page_number",PageNumber);
dic.Add("page_size",PageSize);
    
    var result = Post<QuerySmsCrowdsApiResult>("pdd.sms.crowds.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsCrowdsApiResult>(result);
}/// <summary>
/// 指定号码短信发送设置（自定义）
/// </summary>
/// <param name="TemplateId">模板id</param>
/// <param name="Phones">待发送手机号，["15671551276"]</param>
/// <param name="SendTime">发送时间</param>
/// <param name="TemplateType">//短信模版类型， 1-官方模版，2-自定义模版</param>
public async Task<SettingSmsCustomApiResult> SettingSmsCustomAsync(int TemplateId,int Phones,string SendTime,int TemplateType)
{
    var dic = new Dictionary<string, string>();
    dic.Add("template_id",TemplateId);
dic.Add("phones",Phones);
dic.Add("send_time",SendTime);
dic.Add("template_type",TemplateType);
    
    var result = Post<SettingSmsCustomApiResult>("pdd.sms.custom.setting",dic);
    return JsonConvert.DeserializeObject<SettingSmsCustomApiResult>(result);
}/// <summary>
/// 自定义模板查询
/// </summary>
/// <param name="Status">//1-审核中  2-审核驳回  3-审核通过</param>
/// <param name="OrderByStatus">true or false//审核通过的排前面，在模版选择的时候调用</param>
/// <param name="PageNumber">页码</param>
/// <param name="PageSize">每页大小</param>
/// <param name="TemplateType">/**
     * 自定义模板类型
     * 0,正常模板
     * 1,需要带优惠券类型的模板
     */</param>
public async Task<QuerySmsCustomTemplateApiResult> QuerySmsCustomTemplateAsync(int Status,boolean OrderByStatus,int PageNumber,int PageSize,int TemplateType)
{
    var dic = new Dictionary<string, string>();
    dic.Add("status",Status);
dic.Add("order_by_status",OrderByStatus);
dic.Add("page_number",PageNumber);
dic.Add("page_size",PageSize);
dic.Add("template_type",TemplateType);
    
    var result = Post<QuerySmsCustomTemplateApiResult>("pdd.sms.custom.template.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsCustomTemplateApiResult>(result);
}/// <summary>
/// 查询余量
/// </summary>
public async Task<QuerySmsRemainDetailApiResult> QuerySmsRemainDetailAsync()
{
    var dic = new Dictionary<string, string>();
        
    var result = Post<QuerySmsRemainDetailApiResult>("pdd.sms.remain.detail.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsRemainDetailApiResult>(result);
}/// <summary>
/// 提醒买家付款的任务设置
/// </summary>
/// <param name="Open">该提醒任务是否处于处于打开状态，0-关闭，此时提醒任务被关闭，1-打开，此时提醒任务打开</param>
/// <param name="Scene">该任务对应的场景//1-提醒付款 3-召唤买家成团</param>
/// <param name="OperateType">operate_type// 1-开启任务   2-编辑</param>
/// <param name="UnpaidDuration">买家未付款时间，单位为分钟。例，unpaid_duration=3，买家下单后3分钟未付款，即发送短信提醒买家付款</param>
/// <param name="TemplateId">指定的短信任务的模板id</param>
public async Task<SettingSmsRemainApiResult> SettingSmsRemainAsync(int Open,int Scene,int OperateType,int UnpaidDuration,int TemplateId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("open",Open);
dic.Add("scene",Scene);
dic.Add("operate_type",OperateType);
dic.Add("unpaid_duration",UnpaidDuration);
dic.Add("template_id",TemplateId);
    
    var result = Post<SettingSmsRemainApiResult>("pdd.sms.remain.setting",dic);
    return JsonConvert.DeserializeObject<SettingSmsRemainApiResult>(result);
}/// <summary>
/// 提醒类短信设置详情
/// </summary>
/// <param name="Scene">//1：提醒付款 ；  3：召唤买家成团</param>
public async Task<QuerySmsRemainSettingDetailApiResult> QuerySmsRemainSettingDetailAsync(int Scene)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene",Scene);
    
    var result = Post<QuerySmsRemainSettingDetailApiResult>("pdd.sms.remain.setting.detail.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsRemainSettingDetailApiResult>(result);
}/// <summary>
/// 删除任务
/// </summary>
/// <param name="Id">任务id</param>
public async Task<DeletingSmsSellApiResult> DeletingSmsSellAsync(int Id)
{
    var dic = new Dictionary<string, string>();
    dic.Add("id",Id);
    
    var result = Post<DeletingSmsSellApiResult>("pdd.sms.sell.deleting",dic);
    return JsonConvert.DeserializeObject<DeletingSmsSellApiResult>(result);
}/// <summary>
/// 查询短信发送任务列表
/// </summary>
/// <param name="Status">全部不传status
待发送 status 1
已发送 status2
已取消 status3</param>
/// <param name="OrderBySendTime">//排序  1-升序 2-倒序</param>
/// <param name="PageNumber">页码数</param>
/// <param name="PageSize">单页条目数</param>
public async Task<QuerySmsSellRecordListApiResult> QuerySmsSellRecordListAsync(int Status,int OrderBySendTime,int PageNumber,int PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("status",Status);
dic.Add("order_by_send_time",OrderBySendTime);
dic.Add("page_number",PageNumber);
dic.Add("page_size",PageSize);
    
    var result = Post<QuerySmsSellRecordListApiResult>("pdd.sms.sell.record.list.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsSellRecordListApiResult>(result);
}/// <summary>
/// 营销短信设置详情
/// </summary>
/// <param name="Id">任务id</param>
public async Task<QuerySmsSellSettingDetailApiResult> QuerySmsSellSettingDetailAsync(int Id)
{
    var dic = new Dictionary<string, string>();
    dic.Add("id",Id);
    
    var result = Post<QuerySmsSellSettingDetailApiResult>("pdd.sms.sell.setting.detail.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsSellSettingDetailApiResult>(result);
}/// <summary>
/// 取消任务
/// </summary>
/// <param name="Id">任务id</param>
public async Task<CancelSmsSellSettingRecordApiResult> CancelSmsSellSettingRecordAsync(int Id)
{
    var dic = new Dictionary<string, string>();
    dic.Add("id",Id);
    
    var result = Post<CancelSmsSellSettingRecordApiResult>("pdd.sms.sell.setting.record.cancel",dic);
    return JsonConvert.DeserializeObject<CancelSmsSellSettingRecordApiResult>(result);
}/// <summary>
/// 短信发送记录列表
/// </summary>
/// <param name="StartTime">开始时间 2018-08-09 15:20:12</param>
/// <param name="EndTime">结束时间 2018-08-09 15:20:12</param>
/// <param name="Scene">场景id,见前面枚举值用户关怀传[1,3]  ,智能营销[4, 5, 6, 8，9] 不传的话全部</param>
/// <param name="Status">1-成功 2-失败 全部-不传</param>
/// <param name="PageNumber">页码</param>
/// <param name="PageSize">每页数量</param>
public async Task<QuerySmsSendRecordListApiResult> QuerySmsSendRecordListAsync(string StartTime,string EndTime,list Scene,int Status,int PageNumber,int PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("start_time",StartTime);
dic.Add("end_time",EndTime);
dic.Add("scene",Scene);
dic.Add("status",Status);
dic.Add("page_number",PageNumber);
dic.Add("page_size",PageSize);
    
    var result = Post<QuerySmsSendRecordListApiResult>("pdd.sms.send.record.list.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsSendRecordListApiResult>(result);
}/// <summary>
/// 查看任务数据
/// </summary>
/// <param name="SettingId">任务id</param>
public async Task<QuerySmsShortStatisticApiResult> QuerySmsShortStatisticAsync(int SettingId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("setting_id",SettingId);
    
    var result = Post<QuerySmsShortStatisticApiResult>("pdd.sms.short.statistic.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsShortStatisticApiResult>(result);
}/// <summary>
/// 查询官方模板
/// </summary>
/// <param name="Scene">0, "优惠券", 
1, "提醒付款", 
2, "活动营销", 
3, "召唤买家成团", 
4, "新客转化", 
5, "老客召回", 
6, "流失唤醒", 
7, "用户自定义", 
8, "个性化营销", 
9, "精准客户推送"</param>
public async Task<QuerySmsTemplateApiResult> QuerySmsTemplateAsync(int Scene)
{
    var dic = new Dictionary<string, string>();
    dic.Add("scene",Scene);
    
    var result = Post<QuerySmsTemplateApiResult>("pdd.sms.template.query",dic);
    return JsonConvert.DeserializeObject<QuerySmsTemplateApiResult>(result);
}
    }
}
