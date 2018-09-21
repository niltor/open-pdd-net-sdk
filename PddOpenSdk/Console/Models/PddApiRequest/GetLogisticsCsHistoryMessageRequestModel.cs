using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetLogisticsCsHistoryMessageRequestModel : PddRequestModel
    {
        /// <summary>
/// pdd会话id
/// </summary>
[JsonProperty("session_id")]
public string SessionId {get;set;}

}
}
