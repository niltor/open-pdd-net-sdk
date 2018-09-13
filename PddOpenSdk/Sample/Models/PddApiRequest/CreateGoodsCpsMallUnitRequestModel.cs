using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class CreateGoodsCpsMallUnitRequestModel : PddRequestModel
    {
        /// <summary>
/// 佣金比（千分比）
/// </summary>
[JsonProperty("rate")]
public int Rate {get;set;}
}
}

