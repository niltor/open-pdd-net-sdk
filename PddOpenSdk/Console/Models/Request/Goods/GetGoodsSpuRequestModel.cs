using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsSpuRequestModel : PddRequestModel
{
/// <summary>
/// 标品所在的类目ID
/// </summary>
[JsonProperty("cat_id")]
public string CatId {get;set;}
/// <summary>
/// 关键属性
/// </summary>
[JsonProperty("key_prop")]
public List<KeyPropRequestModel> KeyProp {get;set;}
public partial class KeyPropRequestModel : PddRequestModel
{
/// <summary>
/// 引用属性ID
/// </summary>
[JsonProperty("ref_pid")]
public long? RefPid {get;set;}
/// <summary>
/// 属性值单位
/// </summary>
[JsonProperty("value_unit")]
public string ValueUnit {get;set;}
/// <summary>
/// 关键属性值，和vid必须入参其一。
/// </summary>
[JsonProperty("value")]
public string Value {get;set;}
/// <summary>
/// 关键属性值ID，和value必须入参其一。
/// </summary>
[JsonProperty("vid")]
public long? Vid {get;set;}

}

}

}
