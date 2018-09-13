using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsMallTemplateResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("response")]
public string MallTemplateGetResponse {get;set;}
/// <summary>
/// 模块
/// </summary>
[JsonProperty("模块")]
public string Modules {get;set;}
/// <summary>
/// 属性
/// </summary>
[JsonProperty("属性")]
public string Propertys {get;set;}
/// <summary>
/// 模板模块id
/// </summary>
[JsonProperty("模板模块id")]
public int Id {get;set;}
/// <summary>
/// 属性值可填最小范围
/// </summary>
[JsonProperty("属性值可填最小范围")]
public int MinValue {get;set;}
/// <summary>
/// 属性值可填最大范围
/// </summary>
[JsonProperty("属性值可填最大范围")]
public int MaxValue {get;set;}
/// <summary>
/// control_type=1、3时校验选择数目是否超过最大值
/// </summary>
[JsonProperty("control_type=1、3时校验选择数目是否超过最大值")]
public int ChooseMaxNum {get;set;}
/// <summary>
/// 值输入类型（0-文本、1-数值、4-绝对时间、5-相对时间）
/// </summary>
[JsonProperty("值输入类型（0-文本、1-数值、4-绝对时间、5-相对时间）")]
public int ValueType {get;set;}
/// <summary>
/// 控件类型（0-可输入、1-可勾选、3-可输入又可勾选、5-单项时间选择器-年月日、6-双项时间选择器-年月日、7-单项时间选择器-年月、8-双项时间选择器-年月）
/// </summary>
[JsonProperty("控件类型（0-可输入、1-可勾选、3-可输入又可勾选、5-单项时间选择器-年月日、6-双项时间选择器-年月日、7-单项时间选择器-年月、8-双项时间选择器-年月）")]
public int ControlType {get;set;}
/// <summary>
/// 属性名称
/// </summary>
[JsonProperty("属性名称")]
public string NameAlias {get;set;}
/// <summary>
/// 是否必填true/false
/// </summary>
[JsonProperty("是否必填true/false")]
public bool Required {get;set;}
/// <summary>
/// 模板属性id
/// </summary>
[JsonProperty("模板属性id")]
public int Id {get;set;}
/// <summary>
/// 属性id
/// </summary>
[JsonProperty("属性id")]
public int Pid {get;set;}
/// <summary>
/// 属性单位
/// </summary>
[JsonProperty("属性单位")]
public string ValueUnit {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("属性值")]
public string Values {get;set;}
/// <summary>
/// 内容
/// </summary>
[JsonProperty("内容")]
public string Content {get;set;}
/// <summary>
/// id
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
/// <summary>
/// 属性值id
/// </summary>
[JsonProperty("属性值id")]
public int Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("属性值")]
public string Value {get;set;}
}
}

    public partial class MallTemplateGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 模块
/// </summary>
[JsonProperty("模块")]
public string Modules {get;set;}
}


    public partial class ModulesResponseModel : PddResponseModel
    {
        /// <summary>
/// 属性
/// </summary>
[JsonProperty("属性")]
public string Propertys {get;set;}
/// <summary>
/// 模板模块id
/// </summary>
[JsonProperty("模板模块id")]
public int Id {get;set;}
}


    public partial class PropertysResponseModel : PddResponseModel
    {
        /// <summary>
/// 属性值可填最小范围
/// </summary>
[JsonProperty("属性值可填最小范围")]
public int MinValue {get;set;}
/// <summary>
/// 属性值可填最大范围
/// </summary>
[JsonProperty("属性值可填最大范围")]
public int MaxValue {get;set;}
/// <summary>
/// control_type=1、3时校验选择数目是否超过最大值
/// </summary>
[JsonProperty("control_type=1、3时校验选择数目是否超过最大值")]
public int ChooseMaxNum {get;set;}
/// <summary>
/// 值输入类型（0-文本、1-数值、4-绝对时间、5-相对时间）
/// </summary>
[JsonProperty("值输入类型（0-文本、1-数值、4-绝对时间、5-相对时间）")]
public int ValueType {get;set;}
/// <summary>
/// 控件类型（0-可输入、1-可勾选、3-可输入又可勾选、5-单项时间选择器-年月日、6-双项时间选择器-年月日、7-单项时间选择器-年月、8-双项时间选择器-年月）
/// </summary>
[JsonProperty("控件类型（0-可输入、1-可勾选、3-可输入又可勾选、5-单项时间选择器-年月日、6-双项时间选择器-年月日、7-单项时间选择器-年月、8-双项时间选择器-年月）")]
public int ControlType {get;set;}
/// <summary>
/// 属性名称
/// </summary>
[JsonProperty("属性名称")]
public string NameAlias {get;set;}
/// <summary>
/// 是否必填true/false
/// </summary>
[JsonProperty("是否必填true/false")]
public bool Required {get;set;}
/// <summary>
/// 模板属性id
/// </summary>
[JsonProperty("模板属性id")]
public int Id {get;set;}
/// <summary>
/// 属性id
/// </summary>
[JsonProperty("属性id")]
public int Pid {get;set;}
/// <summary>
/// 属性单位
/// </summary>
[JsonProperty("属性单位")]
public string ValueUnit {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("属性值")]
public string Values {get;set;}
}


    public partial class ValuesResponseModel : PddResponseModel
    {
        /// <summary>
/// 内容
/// </summary>
[JsonProperty("内容")]
public string Content {get;set;}
}


    public partial class ContentResponseModel : PddResponseModel
    {
        /// <summary>
/// id
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}
/// <summary>
/// 属性值id
/// </summary>
[JsonProperty("属性值id")]
public int Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("属性值")]
public string Value {get;set;}
}


