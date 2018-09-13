using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class VerificationVoucherVirtualCardRequestModel : PddRequestModel
    {
        /// <summary>
/// 拼多多订单号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 券信息列表
/// </summary>
[JsonProperty("voucher_data_list")]
public object VoucherDataList {get;set;}
/// <summary>
/// 流水号
/// </summary>
[JsonProperty("out_trans_no")]
public object OutTransNo {get;set;}
/// <summary>
/// 券状态更改时间
/// </summary>
[JsonProperty("voucher_time")]
public int VoucherTime {get;set;}
/// <summary>
/// 券状态 1：已核销；2：已销毁
/// </summary>
[JsonProperty("voucher_status")]
public int VoucherStatus {get;set;}
/// <summary>
/// 券号
/// </summary>
[JsonProperty("voucher_no")]
public object VoucherNo {get;set;}

    public partial class VoucherDataListRequestModel : PddRequestModel
    {
        /// <summary>
/// 流水号
/// </summary>
[JsonProperty("out_trans_no")]
public object OutTransNo {get;set;}
/// <summary>
/// 券状态更改时间
/// </summary>
[JsonProperty("voucher_time")]
public int VoucherTime {get;set;}
/// <summary>
/// 券状态 1：已核销；2：已销毁
/// </summary>
[JsonProperty("voucher_status")]
public int VoucherStatus {get;set;}
/// <summary>
/// 券号
/// </summary>
[JsonProperty("voucher_no")]
public object VoucherNo {get;set;}

}

}
}
