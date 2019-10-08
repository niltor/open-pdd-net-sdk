using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
public partial class GetDdkMerchantListRequestModel : PddRequestModel
{
/// <summary>
/// 商品类目ID，使用pdd.goods.cats.get接口获取
/// </summary>
[JsonProperty("cat_id")]
public long? CatId {get;set;}
/// <summary>
/// 是否有店铺收藏券 （0 所有；1 必须有券）
/// </summary>
[JsonProperty("has_clt_cpn")]
public bool? HasCltCpn {get;set;}
/// <summary>
/// 是否有优惠券 （0 所有；1 必须有券。）
/// </summary>
[JsonProperty("has_coupon")]
public int? HasCoupon {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id_list")]
public List<long?> MallIdList {get;set;}
/// <summary>
/// 店铺类型
/// </summary>
[JsonProperty("merchant_type_list")]
public int? MerchantTypeList {get;set;}
/// <summary>
/// 每页数量
/// </summary>
[JsonProperty("page_number")]
public int? PageNumber {get;set;}
/// <summary>
/// 分页数
/// </summary>
[JsonProperty("page_size")]
public int? PageSize {get;set;}
/// <summary>
/// 查询范围0----商品拼团价格区间；1----商品券后价价格区间；2----佣金比例区间；3----优惠券金额区间；4----加入多多进宝时间区间；5----销量区间；6----佣金金额区间
/// </summary>
[JsonProperty("query_range_str")]
public int? QueryRangeStr {get;set;}
/// <summary>
/// 筛选范围
/// </summary>
[JsonProperty("range_vo_list")]
public string RangeVoList {get;set;}

}

}
