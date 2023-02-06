
using PddOpenSdk.Models.Request.SmsVendor;
using PddOpenSdk.Models.Response.SmsVendor;
namespace PddOpenSdk.Services.PddApi;
public class SmsVendorApi : PddCommonApi
{
    public SmsVendorApi() { }
    public SmsVendorApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 短信明细回执
    /// </summary>
    public async Task<PushSmsDetailbillResponse> PushSmsDetailbillAsync(PushSmsDetailbill pushSmsDetailbill)
    {
        var result = await PostAsync<PushSmsDetailbill, PushSmsDetailbillResponse>("pdd.sms.detailbill.push", pushSmsDetailbill);
        return result;
    }

    /// <summary>
    /// 投诉号码上传
    /// </summary>
    public async Task<CreateSmsVendorComplaintResponse> CreateSmsVendorComplaintAsync(CreateSmsVendorComplaint createSmsVendorComplaint)
    {
        var result = await PostAsync<CreateSmsVendorComplaint, CreateSmsVendorComplaintResponse>("pdd.sms.vendor.complaint.create", createSmsVendorComplaint);
        return result;
    }

}
