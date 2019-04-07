using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Voucher;
using PddOpenSdk.Models.Response.Voucher;
namespace PddOpenSdk.Services.PddApi
{
    public class VoucherApi : PddCommonApi {
        /// <summary>
        /// 卡券预约提货接口
        /// </summary>
        public async Task<SendVoucherAppointmentInfoResponseModel> SendVoucherAppointmentInfoAsync (SendVoucherAppointmentInfoRequestModel sendVoucherAppointmentInfo) {
            var result = await PostAsync<SendVoucherAppointmentInfoRequestModel, SendVoucherAppointmentInfoResponseModel> ("pdd.voucher.appointment.info.send", sendVoucherAppointmentInfo);
            return result;
        }
        /// <summary>
        /// 卡券发货（实物）接口
        /// </summary>
        public async Task<SendVoucherPhysicalGoodsResponseModel> SendVoucherPhysicalGoodsAsync (SendVoucherPhysicalGoodsRequestModel sendVoucherPhysicalGoods) {
            var result = await PostAsync<SendVoucherPhysicalGoodsRequestModel, SendVoucherPhysicalGoodsResponseModel> ("pdd.voucher.physical.goods.send", sendVoucherPhysicalGoods);
            return result;
        }
        /// <summary>
        /// 卡券（电子）核销接口
        /// </summary>
        public async Task<VerificationVoucherVirtualCardResponseModel> VerificationVoucherVirtualCardAsync (VerificationVoucherVirtualCardRequestModel verificationVoucherVirtualCard) {
            var result = await PostAsync<VerificationVoucherVirtualCardRequestModel, VerificationVoucherVirtualCardResponseModel> ("pdd.voucher.virtual.card.verification", verificationVoucherVirtualCard);
            return result;
        }
        /// <summary>
        /// 卡券投诉接口
        /// </summary>
        public async Task<ComplainVoucherVoucherResponseModel> ComplainVoucherVoucherAsync (ComplainVoucherVoucherRequestModel complainVoucherVoucher) {
            var result = await PostAsync<ComplainVoucherVoucherRequestModel, ComplainVoucherVoucherResponseModel> ("pdd.voucher.voucher.complain", complainVoucherVoucher);
            return result;
        }
        /// <summary>
        /// 卡券信息发送接口
        /// </summary>
        public async Task<SendVoucherVoucherInfoResponseModel> SendVoucherVoucherInfoAsync (SendVoucherVoucherInfoRequestModel sendVoucherVoucherInfo) {
            var result = await PostAsync<SendVoucherVoucherInfoRequestModel, SendVoucherVoucherInfoResponseModel> ("pdd.voucher.voucher.info.send", sendVoucherVoucherInfo);
            return result;
        }

    }
}