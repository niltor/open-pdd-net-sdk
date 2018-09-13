using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class QuerySmsSellSettingDetailRequestModel : PddRequestModel
    {
        /// <summary>
/// 任务id
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
}
}

