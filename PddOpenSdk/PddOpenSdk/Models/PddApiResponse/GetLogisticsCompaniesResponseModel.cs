using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetLogisticsCompaniesResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回的快递公司列表对象
/// </summary>
[JsonProperty("logistics_companies_get_response")]
public object LogisticsCompaniesGetResponse {get;set;}
/// <summary>
/// 快递公司列表对象
/// </summary>
[JsonProperty("logistics_companies")]
public object LogisticsCompanies {get;set;}
/// <summary>
/// 是否有效，0-当前不支持的快递公司，1-支持的快递公司，注意：发货时必须入参支持的快递公司id，否则会报错
/// </summary>
[JsonProperty("available")]
public int Available {get;set;}
/// <summary>
/// 快递公司编码
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 快递公司名称
/// </summary>
[JsonProperty("logistics_company")]
public object LogisticsCompany {get;set;}

    public partial class LogisticsCompaniesGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 快递公司列表对象
/// </summary>
[JsonProperty("logistics_companies")]
public object LogisticsCompanies {get;set;}

}

    public partial class LogisticsCompaniesResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否有效，0-当前不支持的快递公司，1-支持的快递公司，注意：发货时必须入参支持的快递公司id，否则会报错
/// </summary>
[JsonProperty("available")]
public int Available {get;set;}
/// <summary>
/// 快递公司编码
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 快递公司名称
/// </summary>
[JsonProperty("logistics_company")]
public object LogisticsCompany {get;set;}

}

}
}
