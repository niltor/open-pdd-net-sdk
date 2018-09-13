using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetGoodsFabricContentRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.fabric.content.get
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}
}
}

