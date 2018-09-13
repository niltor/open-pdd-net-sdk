using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class SendVoucherVoucherInfoRequestModel : PddRequestModel
    {
        /// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public String OrderSn {get;set;}
/// <summary>
/// 外部流水号
/// </summary>
[JsonProperty("out_biz_no")]
public String OutBizNo {get;set;}
/// <summary>
/// 卡券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]
/// </summary>
[JsonProperty("voucher_list")]
public list VoucherList {get;set;}
/// <summary>
/// 卡券ID
/// </summary>
[JsonProperty("voucher_id")]
public String VoucherId {get;set;}
/// <summary>
/// 卡券号
/// </summary>
[JsonProperty("voucher_no")]
public String VoucherNo {get;set;}
}
}

    public partial class VoucherListRequestModel : PddRequestModel
    {
        /// <summary>
/// 卡券ID
/// </summary>
[JsonProperty("voucher_id")]
public String VoucherId {get;set;}
/// <summary>
/// 卡券号
/// </summary>
[JsonProperty("voucher_no")]
public String VoucherNo {get;set;}
}


