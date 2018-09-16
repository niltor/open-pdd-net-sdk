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
public object SmsSellSettingDetailQueryResponse {get;set;}

    public partial class SmsSellSettingDetailQueryResponseResponseModel : PddResponseModel
    {
        
}

}
}
