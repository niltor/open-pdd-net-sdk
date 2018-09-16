using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsSellRecordListResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_sell_record_list_query_response")]
public object SmsSellRecordListQueryResponse {get;set;}

    public partial class SmsSellRecordListQueryResponseResponseModel : PddResponseModel
    {
        
}

}
}
