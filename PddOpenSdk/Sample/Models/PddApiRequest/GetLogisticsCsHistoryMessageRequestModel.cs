using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetLogisticsCsHistoryMessageRequestModel : PddRequestModel
    {
        /// <summary>
/// pdd会话id
/// </summary>
[JsonProperty("session_id")]
public string(64) SessionId {get;set;}
}
}

