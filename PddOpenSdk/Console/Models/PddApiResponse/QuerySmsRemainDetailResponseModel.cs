using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsRemainDetailResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_remain_detail_query_response")]
public SmsRemainDetailQueryResponseResponseModel SmsRemainDetailQueryResponse {get;set;}

    public partial class SmsRemainDetailQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 剩余金额
/// </summary>
[JsonProperty("remain_money")]
public int RemainMoney {get;set;}
/// <summary>
/// 剩余数量
/// </summary>
[JsonProperty("remain_number")]
public int RemainNumber {get;set;}

}

}
}
