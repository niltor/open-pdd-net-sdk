using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetGoodsFabricRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.fabric.get
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}

}
}
