using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class VoucherApiRequest : PddRequest {
        /// <summary>
/// 卡券预约提货接口
/// </summary>
/// <param name="OrderSn">订单号</param>
/// <param name="OutBizNo">外部流水号</param>
/// <param name="VoucherList">优惠券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]</param>
/// <param name="LogisticsType">物流方式  1  物流发货   2 自提</param>
/// <param name="AppointmentTime">预约时间, 距离格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总毫秒数</param>
/// <param name="VoucherId">卡券ID</param>
/// <param name="VoucherNo">卡券号</param>
public async Task<SendVoucherAppointmentInfoApiResult> SendVoucherAppointmentInfoAsync(string OrderSn,string OutBizNo,list VoucherList,number LogisticsType,number AppointmentTime,string VoucherId,string VoucherNo)
{
    var dic = new Dictionary<string, string>();
    dic.Add("order_sn",Order Sn);
dic.Add("out_biz_no",Out Biz No);
dic.Add("voucher_list",Voucher List);
dic.Add("logistics_type",Logistics Type);
dic.Add("appointment_time",Appointment Time);
dic.Add("voucher_id",Voucher Id);
dic.Add("voucher_no",Voucher No);
    
    var result = Post<SendVoucherAppointmentInfoApiResult>(pdd.voucher.appointment.info.send,);
    return JsonConvert.DeserializeObject<SendVoucherAppointmentInfoApiResult>(result);
}/// <summary>
/// 卡券发货（实物）接口
/// </summary>
/// <param name="OrderSn">订单号</param>
/// <param name="OutBizNo">外部流水号</param>
/// <param name="VoucherList">优惠券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]</param>
/// <param name="LogisticsType">物流方式  1  物流发货   2 自提</param>
/// <param name="Recipient">收件人</param>
/// <param name="RecipientMobile">收件人电话</param>
/// <param name="RecipientAddress">收件人地址</param>
/// <param name="LogisticsNo">物流单号</param>
/// <param name="LogisticsCompanyId">物流公司编号</param>
/// <param name="LogisticsCompany">物流公司名称</param>
/// <param name="VoucherId">卡券ID</param>
/// <param name="VoucherNo">卡券号</param>
public async Task<SendVoucherPhysicalGoodsApiResult> SendVoucherPhysicalGoodsAsync(string OrderSn,string OutBizNo,list VoucherList,number LogisticsType,string Recipient,string RecipientMobile,string RecipientAddress,string LogisticsNo,string LogisticsCompanyId,string LogisticsCompany,string VoucherId,string VoucherNo)
{
    var dic = new Dictionary<string, string>();
    dic.Add("order_sn",Order Sn);
dic.Add("out_biz_no",Out Biz No);
dic.Add("voucher_list",Voucher List);
dic.Add("logistics_type",Logistics Type);
dic.Add("recipient",Recipient);
dic.Add("recipient_mobile",Recipient Mobile);
dic.Add("recipient_address",Recipient Address);
dic.Add("logistics_no",Logistics No);
dic.Add("logistics_company_id",Logistics Company Id);
dic.Add("logistics_company",Logistics Company);
dic.Add("voucher_id",Voucher Id);
dic.Add("voucher_no",Voucher No);
    
    var result = Post<SendVoucherPhysicalGoodsApiResult>(pdd.voucher.physical.goods.send,);
    return JsonConvert.DeserializeObject<SendVoucherPhysicalGoodsApiResult>(result);
}/// <summary>
/// 卡券（电子）核销接口
/// </summary>
/// <param name="OrderSn">拼多多订单号</param>
/// <param name="VoucherDataList">券信息列表</param>
/// <param name="OutTransNo">流水号</param>
/// <param name="VoucherTime">券状态更改时间</param>
/// <param name="VoucherStatus">券状态 1：已核销；2：已销毁</param>
/// <param name="VoucherNo">券号</param>
public async Task<VerificationVoucherVirtualCardApiResult> VerificationVoucherVirtualCardAsync(string OrderSn,list VoucherDataList,string OutTransNo,number VoucherTime,number VoucherStatus,string VoucherNo)
{
    var dic = new Dictionary<string, string>();
    dic.Add("order_sn",Order Sn);
dic.Add("voucher_data_list",Voucher Data List);
dic.Add("out_trans_no",Out Trans No);
dic.Add("voucher_time",Voucher Time);
dic.Add("voucher_status",Voucher Status);
dic.Add("voucher_no",Voucher No);
    
    var result = Post<VerificationVoucherVirtualCardApiResult>(pdd.voucher.virtual.card.verification,);
    return JsonConvert.DeserializeObject<VerificationVoucherVirtualCardApiResult>(result);
}/// <summary>
/// 卡券投诉接口
/// </summary>
/// <param name="OrderSn">订单号</param>
/// <param name="OutBizNo">外部流水号</param>
/// <param name="ComplainUser">投诉人</param>
/// <param name="ComplainUserMobile">投诉人电话</param>
/// <param name="ComplainContent">投诉内容</param>
/// <param name="ComplainAttachmentList">["http://testimg.yangkeduo.com/pdd_oms/2018-01-16/411068e948835ae053a86c13f8ebb5ee.jpg"]</param>
/// <param name="ComplainType">枚举值1、大闸蟹死蟹或者少蟹 ；2、大闸蟹重量不符；3、大闸蟹公母数量不符；4、大闸蟹产地不符；5、欺诈发货（收到的产品非大闸蟹）；6、蟹券无法提货
7、其他质量问题</param>
/// <param name="VoucherList">优惠券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]</param>
/// <param name="VoucherId">卡券ID</param>
/// <param name="VoucherNo">卡券号</param>
public async Task<ComplainVoucherVoucherApiResult> ComplainVoucherVoucherAsync(string OrderSn,string OutBizNo,string ComplainUser,string ComplainUserMobile,string ComplainContent,string ComplainAttachmentList,number ComplainType,list VoucherList,string VoucherId,string VoucherNo)
{
    var dic = new Dictionary<string, string>();
    dic.Add("order_sn",Order Sn);
dic.Add("out_biz_no",Out Biz No);
dic.Add("complain_user",Complain User);
dic.Add("complain_user_mobile",Complain User Mobile);
dic.Add("complain_content",Complain Content);
dic.Add("complain_attachment_list",Complain Attachment List);
dic.Add("complain_type",Complain Type);
dic.Add("voucher_list",Voucher List);
dic.Add("voucher_id",Voucher Id);
dic.Add("voucher_no",Voucher No);
    
    var result = Post<ComplainVoucherVoucherApiResult>(pdd.voucher.voucher.complain,);
    return JsonConvert.DeserializeObject<ComplainVoucherVoucherApiResult>(result);
}/// <summary>
/// 卡券信息发送接口
/// </summary>
/// <param name="OrderSn">订单号</param>
/// <param name="OutBizNo">外部流水号</param>
/// <param name="VoucherList">卡券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]</param>
/// <param name="VoucherId">卡券ID</param>
/// <param name="VoucherNo">卡券号</param>
public async Task<SendVoucherVoucherInfoApiResult> SendVoucherVoucherInfoAsync(string OrderSn,string OutBizNo,list VoucherList,string VoucherId,string VoucherNo)
{
    var dic = new Dictionary<string, string>();
    dic.Add("order_sn",Order Sn);
dic.Add("out_biz_no",Out Biz No);
dic.Add("voucher_list",Voucher List);
dic.Add("voucher_id",Voucher Id);
dic.Add("voucher_no",Voucher No);
    
    var result = Post<SendVoucherVoucherInfoApiResult>(pdd.voucher.voucher.info.send,);
    return JsonConvert.DeserializeObject<SendVoucherVoucherInfoApiResult>(result);
}
    }
}
