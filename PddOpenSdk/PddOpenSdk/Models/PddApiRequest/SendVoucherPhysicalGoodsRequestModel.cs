using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class SendVoucherPhysicalGoodsRequestModel : PddRequestModel
    {
        /// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 外部流水号
/// </summary>
[JsonProperty("out_biz_no")]
public object OutBizNo {get;set;}
/// <summary>
/// 优惠券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]
/// </summary>
[JsonProperty("voucher_list")]
public object VoucherList {get;set;}
/// <summary>
/// 物流方式  1  物流发货   2 自提
/// </summary>
[JsonProperty("logistics_type")]
public int LogisticsType {get;set;}
/// <summary>
/// 收件人
/// </summary>
[JsonProperty("recipient")]
public object Recipient {get;set;}
/// <summary>
/// 收件人电话
/// </summary>
[JsonProperty("recipient_mobile")]
public object RecipientMobile {get;set;}
/// <summary>
/// 收件人地址
/// </summary>
[JsonProperty("recipient_address")]
public object RecipientAddress {get;set;}
/// <summary>
/// 物流单号
/// </summary>
[JsonProperty("logistics_no")]
public object LogisticsNo {get;set;}
/// <summary>
/// 物流公司编号
/// </summary>
[JsonProperty("logistics_company_id")]
public object LogisticsCompanyId {get;set;}
/// <summary>
/// 物流公司名称
/// </summary>
[JsonProperty("logistics_company")]
public object LogisticsCompany {get;set;}
/// <summary>
/// 卡券ID
/// </summary>
[JsonProperty("voucher_id")]
public object VoucherId {get;set;}
/// <summary>
/// 卡券号
/// </summary>
[JsonProperty("voucher_no")]
public object VoucherNo {get;set;}

    public partial class VoucherListRequestModel : PddRequestModel
    {
        /// <summary>
/// 卡券ID
/// </summary>
[JsonProperty("voucher_id")]
public object VoucherId {get;set;}
/// <summary>
/// 卡券号
/// </summary>
[JsonProperty("voucher_no")]
public object VoucherNo {get;set;}

}

}
}
