using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class SmsSellSettingRecordCancelResponse
{
    public bool is_success { get; set; }
}


public class CancelSmsSellSettingRecordApiResult
{
    public SmsSellSettingRecordCancelResponse sms_sell_setting_record_cancel_response { get; set; }
}

}
