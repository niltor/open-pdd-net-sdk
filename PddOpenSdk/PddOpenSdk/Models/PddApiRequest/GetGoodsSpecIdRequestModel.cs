using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetGoodsSpecIdRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.spec.id.get，配合pdd.goods.spec.get接口获取对应要发布的商品所属叶子类目所需的规格id，通过此接口生成对应的规格名称，例如叶子类目下某规格id为0，对应规格名称为颜色，通过此接口可以新建颜色规格下颜色、白色等。
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}
/// <summary>
/// 拼多多标准规格ID，可以通过pdd.goods.spec.get接口获取
/// </summary>
[JsonProperty("parent_spec_id")]
public int ParentSpecId {get;set;}
/// <summary>
/// 商家编辑的规格值，如颜色规格下设置白色属性
/// </summary>
[JsonProperty("spec_name")]
public string SpecName {get;set;}

}
}
