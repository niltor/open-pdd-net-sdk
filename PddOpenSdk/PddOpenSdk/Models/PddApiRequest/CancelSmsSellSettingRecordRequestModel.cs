using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class CancelSmsSellSettingRecordRequestModel : PddRequestModel
    {
        /// <summary>
/// 任务id
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}

}
}
