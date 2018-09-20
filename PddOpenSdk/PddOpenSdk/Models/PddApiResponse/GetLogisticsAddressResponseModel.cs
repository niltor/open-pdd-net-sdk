using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetLogisticsAddressResponseModel : PddResponseModel
    {
        /// <summary>
/// 地址对象列表
/// </summary>
[JsonProperty("address_list")]
public AddressListResponseModel AddressList {get;set;}

    public partial class AddressListResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否有效，0-无效，1-有效
/// </summary>
[JsonProperty("is_enabled")]
public int IsEnabled {get;set;}
/// <summary>
/// 地区邮编
/// </summary>
[JsonProperty("national_code")]
public int NationalCode {get;set;}
/// <summary>
/// 地区层级，1-省份，2-市级，3-区级
/// </summary>
[JsonProperty("region_type")]
public int RegionType {get;set;}
/// <summary>
/// 地区名称
/// </summary>
[JsonProperty("region_name")]
public string RegionName {get;set;}
/// <summary>
/// 父地区ID，顶点id为0
/// </summary>
[JsonProperty("parent_idv")]
public int ParentIdv {get;set;}
/// <summary>
/// 地区ID
/// </summary>
[JsonProperty("id")]
public int Id {get;set;}

}

}
}
