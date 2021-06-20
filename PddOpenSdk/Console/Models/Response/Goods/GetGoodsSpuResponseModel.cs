using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
public partial class GetGoodsSpuResponseModel : PddResponseModel
{
/// <summary>
/// 标品详情查询结果
/// </summary>
[JsonProperty("spu_get_response")]
public SpuGetResponseResponseModel SpuGetResponse {get;set;}
public partial class SpuGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 绑定属性，商品属性中对应的引用属性的属性值需要和绑定属性值相同。
/// </summary>
[JsonProperty("bind_prop")]
public List<BindPropResponseModel> BindProp {get;set;}
/// <summary>
/// 商品轮播图
/// </summary>
[JsonProperty("carousel_gallery")]
public List<string> CarouselGallery {get;set;}
/// <summary>
/// 标品所在的类目ID。若非叶子类目，表示该标品可用于该类目下的任何叶子类目。
/// </summary>
[JsonProperty("cat_id")]
public long? CatId {get;set;}
/// <summary>
/// 商品详情图
/// </summary>
[JsonProperty("detail_gallery")]
public List<string> DetailGallery {get;set;}
/// <summary>
/// 商品标题
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 关键属性
/// </summary>
[JsonProperty("key_prop")]
public List<KeyPropResponseModel> KeyProp {get;set;}
/// <summary>
/// 商品前缀标题，若有返回值，则表示发布该标品对应的商品时，商品标题的开头需要包含这部分字符串。
/// </summary>
[JsonProperty("pre_title")]
public string PreTitle {get;set;}
/// <summary>
/// 销售属性，商品属性中对应的引用属性的属性值需要是销售属性值的子集。
/// </summary>
[JsonProperty("sale_prop")]
public List<SalePropResponseModel> SaleProp {get;set;}
/// <summary>
/// 标品标题
/// </summary>
[JsonProperty("spu_name")]
public string SpuName {get;set;}
public partial class BindPropResponseModel : PddResponseModel
{
/// <summary>
/// 属性名
/// </summary>
[JsonProperty("pname")]
public string Pname {get;set;}
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
/// 属性值
/// </summary>
[JsonProperty("value")]
public string Value {get;set;}
/// <summary>
/// 属性值ID
/// </summary>
[JsonProperty("vid")]
public long? Vid {get;set;}

}
public partial class KeyPropResponseModel : PddResponseModel
{
/// <summary>
/// 属性名
/// </summary>
[JsonProperty("pname")]
public string Pname {get;set;}
/// <summary>
/// 引用属性id
/// </summary>
[JsonProperty("ref_pid")]
public long? RefPid {get;set;}
/// <summary>
/// 属性值单位
/// </summary>
[JsonProperty("value_unit")]
public string ValueUnit {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public string Value {get;set;}
/// <summary>
/// 属性值ID
/// </summary>
[JsonProperty("vid")]
public long? Vid {get;set;}

}
public partial class SalePropResponseModel : PddResponseModel
{
/// <summary>
/// 组ID
/// </summary>
[JsonProperty("group_id")]
public int? GroupId {get;set;}
/// <summary>
/// 父规格ID
/// </summary>
[JsonProperty("parent_spec_id")]
public long? ParentSpecId {get;set;}
/// <summary>
/// 属性名
/// </summary>
[JsonProperty("pname")]
public string Pname {get;set;}
/// <summary>
/// 引用属性ID
/// </summary>
[JsonProperty("ref_pid")]
public long? RefPid {get;set;}
/// <summary>
/// 规格ID
/// </summary>
[JsonProperty("spec_id")]
public long? SpecId {get;set;}
/// <summary>
/// 属性值单位
/// </summary>
[JsonProperty("value_unit")]
public string ValueUnit {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public string Value {get;set;}
/// <summary>
/// 属性值ID
/// </summary>
[JsonProperty("vid")]
public long? Vid {get;set;}

}

}

}

}
