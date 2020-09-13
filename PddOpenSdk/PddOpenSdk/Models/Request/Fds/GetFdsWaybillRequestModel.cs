using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Fds
{
public partial class GetFdsWaybillRequestModel : PddRequestModel
{
/// <summary>
/// 入参信息
/// </summary>
[JsonProperty("param_fds_waybill_get_request")]
public ParamFdsWaybillGetRequestRequestModel ParamFdsWaybillGetRequest {get;set;}
public partial class ParamFdsWaybillGetRequestRequestModel : PddRequestModel
{
/// <summary>
/// 发货人信息
/// </summary>
[JsonProperty("sender")]
public SenderRequestModel Sender {get;set;}
/// <summary>
/// 取号列表
/// </summary>
[JsonProperty("trade_order_info_dtos")]
public List<TradeOrderInfoDtosRequestModel> TradeOrderInfoDtos {get;set;}
/// <summary>
/// 物流公司 Code ，枚举： YTO- 圆通，ZTO-中通，YUNDA-韵达，STO-申通
/// </summary>
[JsonProperty("wp_code")]
public string WpCode {get;set;}
public partial class SenderRequestModel : PddRequestModel
{
/// <summary>
/// 发货地址，需要入参与 search 接口中的发货人地址信息一致
/// </summary>
[JsonProperty("address")]
public AddressRequestModel Address {get;set;}
/// <summary>
/// 手机号码
/// </summary>
[JsonProperty("mobile")]
public string Mobile {get;set;}
/// <summary>
/// 姓名
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}
/// <summary>
/// 固定电话
/// </summary>
[JsonProperty("phone")]
public string Phone {get;set;}
public partial class AddressRequestModel : PddRequestModel
{
/// <summary>
/// 市
/// </summary>
[JsonProperty("city")]
public string City {get;set;}
/// <summary>
/// 国家/地区
/// </summary>
[JsonProperty("country")]
public string Country {get;set;}
/// <summary>
/// 详细地址
/// </summary>
[JsonProperty("detail")]
public string Detail {get;set;}
/// <summary>
/// 区
/// </summary>
[JsonProperty("district")]
public string District {get;set;}
/// <summary>
/// 省
/// </summary>
[JsonProperty("province")]
public string Province {get;set;}
/// <summary>
/// 街道
/// </summary>
[JsonProperty("town")]
public string Town {get;set;}

}

}
public partial class TradeOrderInfoDtosRequestModel : PddRequestModel
{
/// <summary>
/// 物流服务内容链接
/// </summary>
[JsonProperty("logistics_services")]
public string LogisticsServices {get;set;}
/// <summary>
/// 请求id
/// </summary>
[JsonProperty("object_id")]
public string ObjectId {get;set;}
/// <summary>
/// 订单信息
/// </summary>
[JsonProperty("order_info")]
public OrderInfoRequestModel OrderInfo {get;set;}
/// <summary>
/// 包裹信息
/// </summary>
[JsonProperty("package_info")]
public PackageInfoRequestModel PackageInfo {get;set;}
/// <summary>
/// 标准模板模板URL
/// </summary>
[JsonProperty("template_url")]
public string TemplateUrl {get;set;}
/// <summary>
/// 使用者ID
/// </summary>
[JsonProperty("user_id")]
public long UserId {get;set;}
public partial class OrderInfoRequestModel : PddRequestModel
{
/// <summary>
/// 订单渠道平台编码
/// </summary>
[JsonProperty("order_channels_type")]
public string OrderChannelsType {get;set;}
/// <summary>
/// 订单列表，限制100个
/// </summary>
[JsonProperty("trade_order_list")]
public List<TradeOrderListRequestModel> TradeOrderList {get;set;}
public partial class TradeOrderListRequestModel : PddRequestModel
{
/// <summary>
/// 代打店铺id
/// </summary>
[JsonProperty("mall_mask_id")]
public string MallMaskId {get;set;}
/// <summary>
/// 代打订单号
/// </summary>
[JsonProperty("order_mask_sn")]
public string OrderMaskSn {get;set;}

}

}
public partial class PackageInfoRequestModel : PddRequestModel
{
/// <summary>
/// 快运货品描述
/// </summary>
[JsonProperty("goods_description")]
public string GoodsDescription {get;set;}
/// <summary>
/// 包裹id,拆合单使用
/// </summary>
[JsonProperty("id")]
public string Id {get;set;}
/// <summary>
/// 商品信息,数量限制为100
/// </summary>
[JsonProperty("items")]
public List<ItemsRequestModel> Items {get;set;}
/// <summary>
/// 快运包装方式描述
/// </summary>
[JsonProperty("packaging_description")]
public string PackagingDescription {get;set;}
/// <summary>
/// 子母件总包裹数
/// </summary>
[JsonProperty("total_packages_count")]
public string TotalPackagesCount {get;set;}
/// <summary>
/// 体积, 单位 ml
/// </summary>
[JsonProperty("volume")]
public int? Volume {get;set;}
/// <summary>
/// 重量,单位 g
/// </summary>
[JsonProperty("weight")]
public int? Weight {get;set;}
public partial class ItemsRequestModel : PddRequestModel
{
/// <summary>
/// 数量
/// </summary>
[JsonProperty("count")]
public int Count {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("name")]
public string Name {get;set;}

}

}

}

}

}

}
