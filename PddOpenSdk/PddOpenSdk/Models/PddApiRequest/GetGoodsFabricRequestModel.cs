using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetGoodsFabricRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.fabric.get
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}

}
}
