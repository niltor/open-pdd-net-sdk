using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CancelSmsSellSettingRecordResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_sell_setting_record_cancel_response")]
public object SmsSellSettingRecordCancelResponse {get;set;}

    public partial class SmsSellSettingRecordCancelResponseResponseModel : PddResponseModel
    {
        
}

}
}
