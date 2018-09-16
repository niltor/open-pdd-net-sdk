using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QuerySmsCrowdsPeopleNumberResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_crows_people_number_query_response")]
public object SmsCrowsPeopleNumberQueryResponse {get;set;}
/// <summary>
/// 筛选人数
/// </summary>
[JsonProperty("object_num")]
public int ObjectNum {get;set;}
/// <summary>
/// 短信余量
/// </summary>
[JsonProperty("remain")]
public int Remain {get;set;}

    public partial class SmsCrowsPeopleNumberQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 筛选人数
/// </summary>
[JsonProperty("object_num")]
public int ObjectNum {get;set;}
/// <summary>
/// 短信余量
/// </summary>
[JsonProperty("remain")]
public int Remain {get;set;}

}

}
}
