
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Voucher;
using PddOpenSdk.Models.Response.Voucher;
namespace PddOpenSdk.Services.PddApi
{
    public class VoucherApi : PddCommonApi
    {
        public VoucherApi() { }
        public VoucherApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 卡券预约提货接口
        /// </summary>
        public async Task<SendVoucherAppointmentInfoResponseModel> SendVoucherAppointmentInfoAsync(SendVoucherAppointmentInfoRequestModel sendVoucherAppointmentInfo)
        {
            var result = await PostAsync<SendVoucherAppointmentInfoRequestModel, SendVoucherAppointmentInfoResponseModel>("pdd.voucher.appointment.info.send", sendVoucherAppointmentInfo);
            return result;
        }
        /// <summary>
        /// 卡券（电子）核销接口（平台生成卡密）
        /// </summary>
        public async Task<VerificationVoucherOtaCardResponseModel> VerificationVoucherOtaCardAsync(VerificationVoucherOtaCardRequestModel verificationVoucherOtaCard)
        {
            var result = await PostAsync<VerificationVoucherOtaCardRequestModel, VerificationVoucherOtaCardResponseModel>("pdd.voucher.ota.card.verification", verificationVoucherOtaCard);
            return result;
        }
        /// <summary>
        /// 卡券发货（实物）接口
        /// </summary>
        public async Task<SendVoucherPhysicalGoodsResponseModel> SendVoucherPhysicalGoodsAsync(SendVoucherPhysicalGoodsRequestModel sendVoucherPhysicalGoods)
        {
            var result = await PostAsync<SendVoucherPhysicalGoodsRequestModel, SendVoucherPhysicalGoodsResponseModel>("pdd.voucher.physical.goods.send", sendVoucherPhysicalGoods);
            return result;
        }
        /// <summary>
        /// 实时卡券查询外部订单号
        /// </summary>
        public async Task<GetVoucherRealtimeOrdernoResponseModel> GetVoucherRealtimeOrdernoAsync(GetVoucherRealtimeOrdernoRequestModel getVoucherRealtimeOrderno)
        {
            var result = await PostAsync<GetVoucherRealtimeOrdernoRequestModel, GetVoucherRealtimeOrdernoResponseModel>("pdd.voucher.realtime.orderno.get", getVoucherRealtimeOrderno);
            return result;
        }
        /// <summary>
        /// 批量添加卡券
        /// </summary>
        public async Task<AddVoucherVirtualCardBatchResponseModel> AddVoucherVirtualCardBatchAsync(AddVoucherVirtualCardBatchRequestModel addVoucherVirtualCardBatch)
        {
            var result = await PostAsync<AddVoucherVirtualCardBatchRequestModel, AddVoucherVirtualCardBatchResponseModel>("pdd.voucher.virtual.card.batch.add", addVoucherVirtualCardBatch);
            return result;
        }
        /// <summary>
        /// 卡券（电子）核销接口
        /// </summary>
        public async Task<VerificationVoucherVirtualCardResponseModel> VerificationVoucherVirtualCardAsync(VerificationVoucherVirtualCardRequestModel verificationVoucherVirtualCard)
        {
            var result = await PostAsync<VerificationVoucherVirtualCardRequestModel, VerificationVoucherVirtualCardResponseModel>("pdd.voucher.virtual.card.verification", verificationVoucherVirtualCard);
            return result;
        }
        /// <summary>
        /// 卡券投诉接口
        /// </summary>
        public async Task<ComplainVoucherVoucherResponseModel> ComplainVoucherVoucherAsync(ComplainVoucherVoucherRequestModel complainVoucherVoucher)
        {
            var result = await PostAsync<ComplainVoucherVoucherRequestModel, ComplainVoucherVoucherResponseModel>("pdd.voucher.voucher.complain", complainVoucherVoucher);
            return result;
        }
        /// <summary>
        /// 卡券信息发送接口
        /// </summary>
        public async Task<SendVoucherVoucherInfoResponseModel> SendVoucherVoucherInfoAsync(SendVoucherVoucherInfoRequestModel sendVoucherVoucherInfo)
        {
            var result = await PostAsync<SendVoucherVoucherInfoRequestModel, SendVoucherVoucherInfoResponseModel>("pdd.voucher.voucher.info.send", sendVoucherVoucherInfo);
            return result;
        }

    }
}
