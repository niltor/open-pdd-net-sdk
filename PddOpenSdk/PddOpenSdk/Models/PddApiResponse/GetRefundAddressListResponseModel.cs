using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetRefundAddressListResponseModel : PddResponseModel
    {
        /// <summary>
/// 退货地址列表
/// </summary>
[JsonProperty("refund_address_list")]
public object RefundAddressList {get;set;}
/// <summary>
/// 退货地址ID
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 退货地址
/// </summary>
[JsonProperty("refund_address")]
public object RefundAddress {get;set;}
/// <summary>
/// 退货收件人名字
/// </summary>
[JsonProperty("refund_name")]
public object RefundName {get;set;}
/// <summary>
/// 退货收件人手机号
/// </summary>
[JsonProperty("refund_phone")]
public object RefundPhone {get;set;}
/// <summary>
/// 店铺ID
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 是否为默认退货地址
/// </summary>
[JsonProperty("is_default")]
public object IsDefault {get;set;}
/// <summary>
/// 退货收件人固定电话
/// </summary>
[JsonProperty("refund_tel")]
public object RefundTel {get;set;}
/// <summary>
/// 退货地址所在省份ID
/// </summary>
[JsonProperty("province_id")]
public object ProvinceId {get;set;}
/// <summary>
/// 退货地址所在省份名字
/// </summary>
[JsonProperty("province_name")]
public object ProvinceName {get;set;}
/// <summary>
/// 退货地址所在城市ID
/// </summary>
[JsonProperty("city_id")]
public object CityId {get;set;}
/// <summary>
/// 退货地址所在城市名字
/// </summary>
[JsonProperty("city_name")]
public object CityName {get;set;}
/// <summary>
/// 退货地址所在区ID
/// </summary>
[JsonProperty("district_id")]
public object DistrictId {get;set;}
/// <summary>
/// 退货地址所在区名字
/// </summary>
[JsonProperty("district_name")]
public object DistrictName {get;set;}
/// <summary>
/// 退货地址是否合法
/// </summary>
[JsonProperty("is_legal")]
public object IsLegal {get;set;}
/// <summary>
/// 退货地址是否有效
/// </summary>
[JsonProperty("is_validated")]
public object IsValidated {get;set;}

    public partial class RefundAddressListResponseModel : PddResponseModel
    {
        /// <summary>
/// 退货地址ID
/// </summary>
[JsonProperty("id")]
public object Id {get;set;}
/// <summary>
/// 退货地址
/// </summary>
[JsonProperty("refund_address")]
public object RefundAddress {get;set;}
/// <summary>
/// 退货收件人名字
/// </summary>
[JsonProperty("refund_name")]
public object RefundName {get;set;}
/// <summary>
/// 退货收件人手机号
/// </summary>
[JsonProperty("refund_phone")]
public object RefundPhone {get;set;}
/// <summary>
/// 店铺ID
/// </summary>
[JsonProperty("mall_id")]
public object MallId {get;set;}
/// <summary>
/// 是否为默认退货地址
/// </summary>
[JsonProperty("is_default")]
public object IsDefault {get;set;}
/// <summary>
/// 退货收件人固定电话
/// </summary>
[JsonProperty("refund_tel")]
public object RefundTel {get;set;}
/// <summary>
/// 退货地址所在省份ID
/// </summary>
[JsonProperty("province_id")]
public object ProvinceId {get;set;}
/// <summary>
/// 退货地址所在省份名字
/// </summary>
[JsonProperty("province_name")]
public object ProvinceName {get;set;}
/// <summary>
/// 退货地址所在城市ID
/// </summary>
[JsonProperty("city_id")]
public object CityId {get;set;}
/// <summary>
/// 退货地址所在城市名字
/// </summary>
[JsonProperty("city_name")]
public object CityName {get;set;}
/// <summary>
/// 退货地址所在区ID
/// </summary>
[JsonProperty("district_id")]
public object DistrictId {get;set;}
/// <summary>
/// 退货地址所在区名字
/// </summary>
[JsonProperty("district_name")]
public object DistrictName {get;set;}
/// <summary>
/// 退货地址是否合法
/// </summary>
[JsonProperty("is_legal")]
public object IsLegal {get;set;}
/// <summary>
/// 退货地址是否有效
/// </summary>
[JsonProperty("is_validated")]
public object IsValidated {get;set;}

}

}
}
