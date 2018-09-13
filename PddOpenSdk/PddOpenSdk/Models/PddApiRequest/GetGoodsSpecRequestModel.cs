using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetGoodsSpecRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.spec.get
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}
/// <summary>
/// 叶子类目ID，必须入参level=3时的cat_id,否则无法返回正确的参数
/// </summary>
[JsonProperty("cat_id")]
public object CatId {get;set;}

}
}
