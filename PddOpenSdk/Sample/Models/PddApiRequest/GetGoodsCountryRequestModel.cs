using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetGoodsCountryRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.country.get
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}
}
}

