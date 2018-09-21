using System.Threading.Tasks;
using PddOpenSdk.Models.PddApiRequest;
using PddOpenSdk.Models.PddApiResponse;
namespace PddOpenSdk.Services.PddApi
{
    public class SmsApi : PddCommonApi
    {
        /// <summary>
        /// 新增人群
        /// </summary>
        public async Task<CrowdSmsAddResponseModel> CrowdSmsAddAsync(CrowdSmsAddRequestModel crowdSmsAdd)
        {
            var result = await PostAsync<CrowdSmsAddRequestModel, CrowdSmsAddResponseModel>("pdd.sms.add.crowd", crowdSmsAdd);
            return result;
        }
        /// <summary>
        /// 创建自定义模板
        /// </summary>
        public async Task<TemplateSmsCreateCustomResponseModel> TemplateSmsCreateCustomAsync(TemplateSmsCreateCustomRequestModel templateSmsCreateCustom)
        {
            var result = await PostAsync<TemplateSmsCreateCustomRequestModel, TemplateSmsCreateCustomResponseModel>("pdd.sms.create.custom.template", templateSmsCreateCustom);
            return result;
        }
        /// <summary>
        /// 查询人群数量
        /// </summary>
        public async Task<QuerySmsCrowdsPeopleNumberResponseModel> QuerySmsCrowdsPeopleNumberAsync(QuerySmsCrowdsPeopleNumberRequestModel querySmsCrowdsPeopleNumber)
        {
            var result = await PostAsync<QuerySmsCrowdsPeopleNumberRequestModel, QuerySmsCrowdsPeopleNumberResponseModel>("pdd.sms.crowds.people.number.query", querySmsCrowdsPeopleNumber);
            return result;
        }
        /// <summary>
        /// 查询人群列表
        /// </summary>
        public async Task<QuerySmsCrowdsResponseModel> QuerySmsCrowdsAsync(QuerySmsCrowdsRequestModel querySmsCrowds)
        {
            var result = await PostAsync<QuerySmsCrowdsRequestModel, QuerySmsCrowdsResponseModel>("pdd.sms.crowds.query", querySmsCrowds);
            return result;
        }
        /// <summary>
        /// 指定号码短信发送设置（自定义）
        /// </summary>
        public async Task<SettingSmsCustomResponseModel> SettingSmsCustomAsync(SettingSmsCustomRequestModel settingSmsCustom)
        {
            var result = await PostAsync<SettingSmsCustomRequestModel, SettingSmsCustomResponseModel>("pdd.sms.custom.setting", settingSmsCustom);
            return result;
        }
        /// <summary>
        /// 自定义模板查询
        /// </summary>
        public async Task<QuerySmsCustomTemplateResponseModel> QuerySmsCustomTemplateAsync(QuerySmsCustomTemplateRequestModel querySmsCustomTemplate)
        {
            var result = await PostAsync<QuerySmsCustomTemplateRequestModel, QuerySmsCustomTemplateResponseModel>("pdd.sms.custom.template.query", querySmsCustomTemplate);
            return result;
        }
        /// <summary>
        /// 查询余量
        /// </summary>
        public async Task<QuerySmsRemainDetailResponseModel> QuerySmsRemainDetailAsync(QuerySmsRemainDetailRequestModel querySmsRemainDetail)
        {
            var result = await PostAsync<QuerySmsRemainDetailRequestModel, QuerySmsRemainDetailResponseModel>("pdd.sms.remain.detail.query", querySmsRemainDetail);
            return result;
        }
        /// <summary>
        /// 提醒买家付款的任务设置
        /// </summary>
        public async Task<SettingSmsRemainResponseModel> SettingSmsRemainAsync(SettingSmsRemainRequestModel settingSmsRemain)
        {
            var result = await PostAsync<SettingSmsRemainRequestModel, SettingSmsRemainResponseModel>("pdd.sms.remain.setting", settingSmsRemain);
            return result;
        }
        /// <summary>
        /// 提醒类短信设置详情
        /// </summary>
        public async Task<QuerySmsRemainSettingDetailResponseModel> QuerySmsRemainSettingDetailAsync(QuerySmsRemainSettingDetailRequestModel querySmsRemainSettingDetail)
        {
            var result = await PostAsync<QuerySmsRemainSettingDetailRequestModel, QuerySmsRemainSettingDetailResponseModel>("pdd.sms.remain.setting.detail.query", querySmsRemainSettingDetail);
            return result;
        }
        /// <summary>
        /// 删除任务
        /// </summary>
        public async Task<DeletingSmsSellResponseModel> DeletingSmsSellAsync(DeletingSmsSellRequestModel deletingSmsSell)
        {
            var result = await PostAsync<DeletingSmsSellRequestModel, DeletingSmsSellResponseModel>("pdd.sms.sell.deleting", deletingSmsSell);
            return result;
        }
        /// <summary>
        /// 查询短信发送任务列表
        /// </summary>
        public async Task<QuerySmsSellRecordListResponseModel> QuerySmsSellRecordListAsync(QuerySmsSellRecordListRequestModel querySmsSellRecordList)
        {
            var result = await PostAsync<QuerySmsSellRecordListRequestModel, QuerySmsSellRecordListResponseModel>("pdd.sms.sell.record.list.query", querySmsSellRecordList);
            return result;
        }
        /// <summary>
        /// 营销短信设置详情
        /// </summary>
        public async Task<QuerySmsSellSettingDetailResponseModel> QuerySmsSellSettingDetailAsync(QuerySmsSellSettingDetailRequestModel querySmsSellSettingDetail)
        {
            var result = await PostAsync<QuerySmsSellSettingDetailRequestModel, QuerySmsSellSettingDetailResponseModel>("pdd.sms.sell.setting.detail.query", querySmsSellSettingDetail);
            return result;
        }
        /// <summary>
        /// 取消任务
        /// </summary>
        public async Task<CancelSmsSellSettingRecordResponseModel> CancelSmsSellSettingRecordAsync(CancelSmsSellSettingRecordRequestModel cancelSmsSellSettingRecord)
        {
            var result = await PostAsync<CancelSmsSellSettingRecordRequestModel, CancelSmsSellSettingRecordResponseModel>("pdd.sms.sell.setting.record.cancel", cancelSmsSellSettingRecord);
            return result;
        }
        /// <summary>
        /// 短信发送记录列表
        /// </summary>
        public async Task<QuerySmsSendRecordListResponseModel> QuerySmsSendRecordListAsync(QuerySmsSendRecordListRequestModel querySmsSendRecordList)
        {
            var result = await PostAsync<QuerySmsSendRecordListRequestModel, QuerySmsSendRecordListResponseModel>("pdd.sms.send.record.list.query", querySmsSendRecordList);
            return result;
        }
        /// <summary>
        /// 查看任务数据
        /// </summary>
        public async Task<QuerySmsShortStatisticResponseModel> QuerySmsShortStatisticAsync(QuerySmsShortStatisticRequestModel querySmsShortStatistic)
        {
            var result = await PostAsync<QuerySmsShortStatisticRequestModel, QuerySmsShortStatisticResponseModel>("pdd.sms.short.statistic.query", querySmsShortStatistic);
            return result;
        }
        /// <summary>
        /// 查询官方模板
        /// </summary>
        public async Task<QuerySmsTemplateResponseModel> QuerySmsTemplateAsync(QuerySmsTemplateRequestModel querySmsTemplate)
        {
            var result = await PostAsync<QuerySmsTemplateRequestModel, QuerySmsTemplateResponseModel>("pdd.sms.template.query", querySmsTemplate);
            return result;
        }

    }
}
