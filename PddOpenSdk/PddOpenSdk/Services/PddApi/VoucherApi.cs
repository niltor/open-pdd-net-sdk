
using PddOpenSdk.Models.Request.Voucher;
using PddOpenSdk.Models.Response.Voucher;
namespace PddOpenSdk.Services.PddApi;
public class VoucherApi : PddCommonApi
{
    public VoucherApi() { }
    public VoucherApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 卡券预约提货接口
    /// </summary>
    public async Task<SendVoucherAppointmentInfoResponse> SendVoucherAppointmentInfoAsync(SendVoucherAppointmentInfo sendVoucherAppointmentInfo)
    {
        var result = await PostAsync<SendVoucherAppointmentInfo, SendVoucherAppointmentInfoResponse>("pdd.voucher.appointment.info.send", sendVoucherAppointmentInfo);
        return result;
    }

    /// <summary>
    /// 平台卡密核销验券
    /// </summary>
    public async Task<VerificationVoucherOtaCardPrepareResponse> VerificationVoucherOtaCardPrepareAsync(VerificationVoucherOtaCardPrepare verificationVoucherOtaCardPrepare)
    {
        var result = await PostAsync<VerificationVoucherOtaCardPrepare, VerificationVoucherOtaCardPrepareResponse>("pdd.voucher.ota.card.prepare.verification", verificationVoucherOtaCardPrepare);
        return result;
    }

    /// <summary>
    /// 卡券（电子）核销接口（平台生成卡密）
    /// </summary>
    public async Task<VerificationVoucherOtaCardResponse> VerificationVoucherOtaCardAsync(VerificationVoucherOtaCard verificationVoucherOtaCard)
    {
        var result = await PostAsync<VerificationVoucherOtaCard, VerificationVoucherOtaCardResponse>("pdd.voucher.ota.card.verification", verificationVoucherOtaCard);
        return result;
    }

    /// <summary>
    /// 卡券发货（实物）接口
    /// </summary>
    public async Task<SendVoucherPhysicalGoodsResponse> SendVoucherPhysicalGoodsAsync(SendVoucherPhysicalGoods sendVoucherPhysicalGoods)
    {
        var result = await PostAsync<SendVoucherPhysicalGoods, SendVoucherPhysicalGoodsResponse>("pdd.voucher.physical.goods.send", sendVoucherPhysicalGoods);
        return result;
    }

    /// <summary>
    /// 实时卡券查询外部订单号
    /// </summary>
    public async Task<GetVoucherRealtimeOrdernoResponse> GetVoucherRealtimeOrdernoAsync(GetVoucherRealtimeOrderno getVoucherRealtimeOrderno)
    {
        var result = await PostAsync<GetVoucherRealtimeOrderno, GetVoucherRealtimeOrdernoResponse>("pdd.voucher.realtime.orderno.get", getVoucherRealtimeOrderno);
        return result;
    }

    /// <summary>
    /// 卡券API核销券码
    /// </summary>
    public async Task<SyncVoucherRealtimeVerifyResponse> SyncVoucherRealtimeVerifyAsync(SyncVoucherRealtimeVerify syncVoucherRealtimeVerify)
    {
        var result = await PostAsync<SyncVoucherRealtimeVerify, SyncVoucherRealtimeVerifyResponse>("pdd.voucher.realtime.verify.sync", syncVoucherRealtimeVerify);
        return result;
    }

    /// <summary>
    /// 批量添加卡券
    /// </summary>
    public async Task<AddVoucherVirtualCardBatchResponse> AddVoucherVirtualCardBatchAsync(AddVoucherVirtualCardBatch addVoucherVirtualCardBatch)
    {
        var result = await PostAsync<AddVoucherVirtualCardBatch, AddVoucherVirtualCardBatchResponse>("pdd.voucher.virtual.card.batch.add", addVoucherVirtualCardBatch);
        return result;
    }

    /// <summary>
    /// 卡券（电子）核销接口
    /// </summary>
    public async Task<VerificationVoucherVirtualCardResponse> VerificationVoucherVirtualCardAsync(VerificationVoucherVirtualCard verificationVoucherVirtualCard)
    {
        var result = await PostAsync<VerificationVoucherVirtualCard, VerificationVoucherVirtualCardResponse>("pdd.voucher.virtual.card.verification", verificationVoucherVirtualCard);
        return result;
    }

    /// <summary>
    /// 卡券投诉接口
    /// </summary>
    public async Task<ComplainVoucherVoucherResponse> ComplainVoucherVoucherAsync(ComplainVoucherVoucher complainVoucherVoucher)
    {
        var result = await PostAsync<ComplainVoucherVoucher, ComplainVoucherVoucherResponse>("pdd.voucher.voucher.complain", complainVoucherVoucher);
        return result;
    }

    /// <summary>
    /// 卡券信息发送接口
    /// </summary>
    public async Task<SendVoucherVoucherInfoResponse> SendVoucherVoucherInfoAsync(SendVoucherVoucherInfo sendVoucherVoucherInfo)
    {
        var result = await PostAsync<SendVoucherVoucherInfo, SendVoucherVoucherInfoResponse>("pdd.voucher.voucher.info.send", sendVoucherVoucherInfo);
        return result;
    }

}
