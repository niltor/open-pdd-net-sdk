
using PddOpenSdk.Models.Request.Promotion;
using PddOpenSdk.Models.Response.Promotion;

namespace PddOpenSdk.Services.PddApi;
public class PromotionApi : PddCommonApi
{
    public PromotionApi() { }
    public PromotionApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 关闭批次接口
    /// </summary>
    public async Task<ClosePromotionCouponResponse> ClosePromotionCouponAsync(ClosePromotionCoupon closePromotionCoupon)
    {
        var result = await PostAsync<ClosePromotionCoupon, ClosePromotionCouponResponse>("pdd.promotion.coupon.close", closePromotionCoupon);
        return result;
    }

    /// <summary>
    /// 增加优惠券发行数量接口
    /// </summary>
    public async Task<AddPromotionCouponQuantityResponse> AddPromotionCouponQuantityAsync(AddPromotionCouponQuantity addPromotionCouponQuantity)
    {
        var result = await PostAsync<AddPromotionCouponQuantity, AddPromotionCouponQuantityResponse>("pdd.promotion.coupon.quantity.add", addPromotionCouponQuantity);
        return result;
    }

    /// <summary>
    /// 创建无门槛商品劵批次接口
    /// </summary>
    public async Task<CreatePromotionGoodsCouponResponse> CreatePromotionGoodsCouponAsync(CreatePromotionGoodsCoupon createPromotionGoodsCoupon)
    {
        var result = await PostAsync<CreatePromotionGoodsCoupon, CreatePromotionGoodsCouponResponse>("pdd.promotion.goods.coupon.create", createPromotionGoodsCoupon);
        return result;
    }

    /// <summary>
    /// 商品优惠券批次列表查询
    /// </summary>
    public async Task<GetPromotionGoodsCouponListResponse> GetPromotionGoodsCouponListAsync(GetPromotionGoodsCouponList getPromotionGoodsCouponList)
    {
        var result = await PostAsync<GetPromotionGoodsCouponList, GetPromotionGoodsCouponListResponse>("pdd.promotion.goods.coupon.list.get", getPromotionGoodsCouponList);
        return result;
    }

    /// <summary>
    /// 创建店铺首页优惠券批次接口
    /// </summary>
    public async Task<CreatePromotionHomeCouponResponse> CreatePromotionHomeCouponAsync(CreatePromotionHomeCoupon createPromotionHomeCoupon)
    {
        var result = await PostAsync<CreatePromotionHomeCoupon, CreatePromotionHomeCouponResponse>("pdd.promotion.home.coupon.create", createPromotionHomeCoupon);
        return result;
    }

    /// <summary>
    /// 限时限量购活动结束接口
    /// </summary>
    public async Task<CancelPromotionLimitedActivityResponse> CancelPromotionLimitedActivityAsync(CancelPromotionLimitedActivity cancelPromotionLimitedActivity)
    {
        var result = await PostAsync<CancelPromotionLimitedActivity, CancelPromotionLimitedActivityResponse>("pdd.promotion.limited.activity.cancel", cancelPromotionLimitedActivity);
        return result;
    }

    /// <summary>
    /// 限时限量购活动创建接口
    /// </summary>
    public async Task<CreatePromotionLimitedActivityResponse> CreatePromotionLimitedActivityAsync(CreatePromotionLimitedActivity createPromotionLimitedActivity)
    {
        var result = await PostAsync<CreatePromotionLimitedActivity, CreatePromotionLimitedActivityResponse>("pdd.promotion.limited.activity.create", createPromotionLimitedActivity);
        return result;
    }

    /// <summary>
    /// 限时限量购活动列表查询
    /// </summary>
    public async Task<GetPromotionLimitedDiscountListResponse> GetPromotionLimitedDiscountListAsync(GetPromotionLimitedDiscountList getPromotionLimitedDiscountList)
    {
        var result = await PostAsync<GetPromotionLimitedDiscountList, GetPromotionLimitedDiscountListResponse>("pdd.promotion.limited.discount.list.get", getPromotionLimitedDiscountList);
        return result;
    }

    /// <summary>
    /// 限时限量购可选商品查询接口
    /// </summary>
    public async Task<GetPromotionLimitedQualifiedGoodsResponse> GetPromotionLimitedQualifiedGoodsAsync(GetPromotionLimitedQualifiedGoods getPromotionLimitedQualifiedGoods)
    {
        var result = await PostAsync<GetPromotionLimitedQualifiedGoods, GetPromotionLimitedQualifiedGoodsResponse>("pdd.promotion.limited.qualified.goods.get", getPromotionLimitedQualifiedGoods);
        return result;
    }

    /// <summary>
    /// 限时限量购可选sku查询接口
    /// </summary>
    public async Task<GetPromotionLimitedQualifiedSkuResponse> GetPromotionLimitedQualifiedSkuAsync(GetPromotionLimitedQualifiedSku getPromotionLimitedQualifiedSku)
    {
        var result = await PostAsync<GetPromotionLimitedQualifiedSku, GetPromotionLimitedQualifiedSkuResponse>("pdd.promotion.limited.qualified.sku.get", getPromotionLimitedQualifiedSku);
        return result;
    }

    /// <summary>
    /// 店铺优惠券批次列表接口
    /// </summary>
    public async Task<GetPromotionMerchantCouponListResponse> GetPromotionMerchantCouponListAsync(GetPromotionMerchantCouponList getPromotionMerchantCouponList)
    {
        var result = await PostAsync<GetPromotionMerchantCouponList, GetPromotionMerchantCouponListResponse>("pdd.promotion.merchant.coupon.list.get", getPromotionMerchantCouponList);
        return result;
    }

}
