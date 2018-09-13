using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class QuerySmsShortStatisticRequestModel : PddRequestModel
    {
        /// <summary>
/// 任务id
/// </summary>
[JsonProperty("setting_id")]
public int SettingId {get;set;}

}
}
