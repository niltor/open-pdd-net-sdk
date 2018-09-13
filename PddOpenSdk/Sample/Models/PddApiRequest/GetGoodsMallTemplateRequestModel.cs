using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetGoodsMallTemplateRequestModel : PddRequestModel
    {
        /// <summary>
/// 类目id
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}
}
}

