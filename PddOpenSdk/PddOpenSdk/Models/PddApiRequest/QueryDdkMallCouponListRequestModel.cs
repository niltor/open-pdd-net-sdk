using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class QueryDdkMallCouponListRequestModel : PddRequestModel
    {
        /// <summary>
/// couponType只能传两种：224, "多多进宝店铺满减券";225, "多多进宝店铺折扣券"
/// </summary>
[JsonProperty("coupon_type")]
public int CouponType {get;set;}
/// <summary>
/// 店铺主营类目
/// </summary>
[JsonProperty("filter_cat_list")]
public object FilterCatList {get;set;}
/// <summary>
/// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店（未传为全部）
/// </summary>
[JsonProperty("filter_merchant_type")]
public int? FilterMerchantType {get;set;}
/// <summary>
/// 分页数
/// </summary>
[JsonProperty("page_number")]
public int PageNumber {get;set;}
/// <summary>
/// 每页优惠券数量
/// </summary>
[JsonProperty("page_size")]
public int PageSize {get;set;}

}
}
