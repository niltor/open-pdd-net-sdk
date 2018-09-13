using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GenDdkGoodsZsUnitUrlRequestModel : PddRequestModel
    {
        /// <summary>
/// 需转链的推广链接
/// </summary>
[JsonProperty("source_url")]
public object SourceUrl {get;set;}
/// <summary>
/// 推广位id
/// </summary>
[JsonProperty("pid")]
public object Pid {get;set;}

}
}
