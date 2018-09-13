using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GenDdkOauthGoodsZsUnitUrlRequestModel : PddRequestModel
    {
        /// <summary>
/// 需转链的链接
/// </summary>
[JsonProperty("source_url")]
public object SourceUrl {get;set;}
/// <summary>
/// 渠道id
/// </summary>
[JsonProperty("pid")]
public object Pid {get;set;}

}
}
