using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class ComplainVoucherVoucherRequestModel : PddRequestModel
    {
        /// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 外部流水号
/// </summary>
[JsonProperty("out_biz_no")]
public string OutBizNo {get;set;}
/// <summary>
/// 优惠券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]
/// </summary>
[JsonProperty("voucher_list")]
public VoucherListRequestModel VoucherList {get;set;}
/// <summary>
/// 投诉人
/// </summary>
[JsonProperty("complain_user")]
public string ComplainUser {get;set;}
/// <summary>
/// 投诉人电话
/// </summary>
[JsonProperty("complain_user_mobile")]
public string ComplainUserMobile {get;set;}
/// <summary>
/// 投诉内容
/// </summary>
[JsonProperty("complain_content")]
public string ComplainContent {get;set;}
/// <summary>
/// ["http://testimg.yangkeduo.com/pdd_oms/2018-01-16/411068e948835ae053a86c13f8ebb5ee.jpg"]
/// </summary>
[JsonProperty("complain_attachment_list")]
public string ComplainAttachmentList {get;set;}
/// <summary>
/// 枚举值1、大闸蟹死蟹或者少蟹 ；2、大闸蟹重量不符；3、大闸蟹公母数量不符；4、大闸蟹产地不符；5、欺诈发货（收到的产品非大闸蟹）；6、蟹券无法提货; 7、其他质量问题
/// </summary>
[JsonProperty("complain_type")]
public int ComplainType {get;set;}

    public partial class VoucherListRequestModel : PddRequestModel
    {
        /// <summary>
/// 卡券ID
/// </summary>
[JsonProperty("voucher_id")]
public string VoucherId {get;set;}
/// <summary>
/// 卡券号
/// </summary>
[JsonProperty("voucher_no")]
public string VoucherNo {get;set;}

}

}
}
