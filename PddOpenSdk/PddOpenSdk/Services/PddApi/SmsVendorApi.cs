
using PddOpenSdk.Models.Request.SmsVendor;
using PddOpenSdk.Models.Response.SmsVendor;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class SmsVendorApi : PddCommonApi
    {
        public SmsVendorApi() { }
        public SmsVendorApi(string accessToken) { AccessToken = accessToken; }
        /// <summary>
        /// 短信明细回执
        /// </summary>
        public async Task<PushSmsDetailbillResponseModel> PushSmsDetailbillAsync(PushSmsDetailbillRequestModel pushSmsDetailbill)
        {
            var result = await PostAsync<PushSmsDetailbillRequestModel, PushSmsDetailbillResponseModel>("pdd.sms.detailbill.push", pushSmsDetailbill);
            return result;
        }
        /// <summary>
        /// 投诉号码上传
        /// </summary>
        public async Task<CreateSmsVendorComplaintResponseModel> CreateSmsVendorComplaintAsync(CreateSmsVendorComplaintRequestModel createSmsVendorComplaint)
        {
            var result = await PostAsync<CreateSmsVendorComplaintRequestModel, CreateSmsVendorComplaintResponseModel>("pdd.sms.vendor.complaint.create", createSmsVendorComplaint);
            return result;
        }

    }
}
