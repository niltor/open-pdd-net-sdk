using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
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
public async Task<SendVoucherAppointmentInfoApiResult> SendVoucherAppointmentInfoAsync(string OrderSn,string OutBizNo,list VoucherList,int LogisticsType,int AppointmentTime,string VoucherId,string VoucherNo)
{
    var dic = new Dictionary<string, object>();
    dic.Add("order_sn",OrderSn);
dic.Add("out_biz_no",OutBizNo);
dic.Add("voucher_list",VoucherList);
dic.Add("logistics_type",LogisticsType);
dic.Add("appointment_time",AppointmentTime);
dic.Add("voucher_id",VoucherId);
dic.Add("voucher_no",VoucherNo);
    
    var result = await PostAsync<SendVoucherAppointmentInfoApiResult>("pdd.voucher.appointment.info.send",dic);
    return result;
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
public async Task<SendVoucherPhysicalGoodsApiResult> SendVoucherPhysicalGoodsAsync(string OrderSn,string OutBizNo,list VoucherList,int LogisticsType,string Recipient,string RecipientMobile,string RecipientAddress,string LogisticsNo,string LogisticsCompanyId,string LogisticsCompany,string VoucherId,string VoucherNo)
{
    var dic = new Dictionary<string, object>();
    dic.Add("order_sn",OrderSn);
dic.Add("out_biz_no",OutBizNo);
dic.Add("voucher_list",VoucherList);
dic.Add("logistics_type",LogisticsType);
dic.Add("recipient",Recipient);
dic.Add("recipient_mobile",RecipientMobile);
dic.Add("recipient_address",RecipientAddress);
dic.Add("logistics_no",LogisticsNo);
dic.Add("logistics_company_id",LogisticsCompanyId);
dic.Add("logistics_company",LogisticsCompany);
dic.Add("voucher_id",VoucherId);
dic.Add("voucher_no",VoucherNo);
    
    var result = await PostAsync<SendVoucherPhysicalGoodsApiResult>("pdd.voucher.physical.goods.send",dic);
    return result;
}/// <summary>
/// 卡券（电子）核销接口
/// </summary>
/// <param name="OrderSn">拼多多订单号</param>
/// <param name="VoucherDataList">券信息列表</param>
/// <param name="OutTransNo">流水号</param>
/// <param name="VoucherTime">券状态更改时间</param>
/// <param name="VoucherStatus">券状态 1：已核销；2：已销毁</param>
/// <param name="VoucherNo">券号</param>
public async Task<VerificationVoucherVirtualCardApiResult> VerificationVoucherVirtualCardAsync(string OrderSn,list VoucherDataList,string OutTransNo,int VoucherTime,int VoucherStatus,string VoucherNo)
{
    var dic = new Dictionary<string, object>();
    dic.Add("order_sn",OrderSn);
dic.Add("voucher_data_list",VoucherDataList);
dic.Add("out_trans_no",OutTransNo);
dic.Add("voucher_time",VoucherTime);
dic.Add("voucher_status",VoucherStatus);
dic.Add("voucher_no",VoucherNo);
    
    var result = await PostAsync<VerificationVoucherVirtualCardApiResult>("pdd.voucher.virtual.card.verification",dic);
    return result;
}/// <summary>
/// 卡券投诉接口
/// </summary>
/// <param name="OrderSn">订单号</param>
/// <param name="OutBizNo">外部流水号</param>
/// <param name="ComplainUser">投诉人</param>
/// <param name="ComplainUserMobile">投诉人电话</param>
/// <param name="ComplainContent">投诉内容</param>
/// <param name="ComplainAttachmentList">["http://testimg.yangkeduo.com/pdd_oms/2018-01-16/411068e948835ae053a86c13f8ebb5ee.jpg"]</param>
/// <param name="ComplainType">枚举值1、大闸蟹死蟹或者少蟹 ；2、大闸蟹重量不符；3、大闸蟹公母数量不符；4、大闸蟹产地不符；5、欺诈发货（收到的产品非大闸蟹）；6、蟹券无法提货; 7、其他质量问题</param>
/// <param name="VoucherList">优惠券信息列表,例子[{"voucher_id":"test voucher_id","voucher_no":"test voucher_no"}]</param>
/// <param name="VoucherId">卡券ID</param>
/// <param name="VoucherNo">卡券号</param>
public async Task<ComplainVoucherVoucherApiResult> ComplainVoucherVoucherAsync(string OrderSn,string OutBizNo,string ComplainUser,string ComplainUserMobile,string ComplainContent,string ComplainAttachmentList,int ComplainType,list VoucherList,string VoucherId,string VoucherNo)
{
    var dic = new Dictionary<string, object>();
    dic.Add("order_sn",OrderSn);
dic.Add("out_biz_no",OutBizNo);
dic.Add("complain_user",ComplainUser);
dic.Add("complain_user_mobile",ComplainUserMobile);
dic.Add("complain_content",ComplainContent);
dic.Add("complain_attachment_list",ComplainAttachmentList);
dic.Add("complain_type",ComplainType);
dic.Add("voucher_list",VoucherList);
dic.Add("voucher_id",VoucherId);
dic.Add("voucher_no",VoucherNo);
    
    var result = await PostAsync<ComplainVoucherVoucherApiResult>("pdd.voucher.voucher.complain",dic);
    return result;
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
    var dic = new Dictionary<string, object>();
    dic.Add("order_sn",OrderSn);
dic.Add("out_biz_no",OutBizNo);
dic.Add("voucher_list",VoucherList);
dic.Add("voucher_id",VoucherId);
dic.Add("voucher_no",VoucherNo);
    
    var result = await PostAsync<SendVoucherVoucherInfoApiResult>("pdd.voucher.voucher.info.send",dic);
    return result;
}
    }
}
