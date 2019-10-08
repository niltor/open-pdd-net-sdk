using PddOpenSdk.Models.Request.Smsdetailbill;
using PddOpenSdk.Models.Response.Smsdetailbill;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class SmsdetailbillApi : PddCommonApi
    {
        /// <summary>
        /// 短信明细回执
        /// </summary>
        public async Task<PushSmsDetailbillResponseModel> PushSmsDetailbillAsync(PushSmsDetailbillRequestModel pushSmsDetailbill)
        {
            var result = await PostAsync<PushSmsDetailbillRequestModel, PushSmsDetailbillResponseModel>("pdd.sms.detailbill.push", pushSmsDetailbill);
            return result;
        }

    }
}
