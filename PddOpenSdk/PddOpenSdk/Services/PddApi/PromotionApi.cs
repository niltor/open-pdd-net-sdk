
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Promotion;
using PddOpenSdk.Models.Response.Promotion;
namespace PddOpenSdk.Services.PddApi
{
    public class PromotionApi : PddCommonApi
    {
        public PromotionApi() { }
        public PromotionApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 关闭批次接口
        /// </summary>
        public async Task<ClosePromotionCouponResponseModel> ClosePromotionCouponAsync(ClosePromotionCouponRequestModel closePromotionCoupon)
        {
            var result = await PostAsync<ClosePromotionCouponRequestModel, ClosePromotionCouponResponseModel>("pdd.promotion.coupon.close", closePromotionCoupon);
            return result;
        }
        /// <summary>
        /// 增加优惠券发行数量接口
        /// </summary>
        public async Task<AddPromotionCouponQuantityResponseModel> AddPromotionCouponQuantityAsync(AddPromotionCouponQuantityRequestModel addPromotionCouponQuantity)
        {
            var result = await PostAsync<AddPromotionCouponQuantityRequestModel, AddPromotionCouponQuantityResponseModel>("pdd.promotion.coupon.quantity.add", addPromotionCouponQuantity);
            return result;
        }
        /// <summary>
        /// 创建无门槛商品劵批次接口
        /// </summary>
        public async Task<CreatePromotionGoodsCouponResponseModel> CreatePromotionGoodsCouponAsync(CreatePromotionGoodsCouponRequestModel createPromotionGoodsCoupon)
        {
            var result = await PostAsync<CreatePromotionGoodsCouponRequestModel, CreatePromotionGoodsCouponResponseModel>("pdd.promotion.goods.coupon.create", createPromotionGoodsCoupon);
            return result;
        }
        /// <summary>
        /// 商品优惠券批次列表查询
        /// </summary>
        public async Task<GetPromotionGoodsCouponListResponseModel> GetPromotionGoodsCouponListAsync(GetPromotionGoodsCouponListRequestModel getPromotionGoodsCouponList)
        {
            var result = await PostAsync<GetPromotionGoodsCouponListRequestModel, GetPromotionGoodsCouponListResponseModel>("pdd.promotion.goods.coupon.list.get", getPromotionGoodsCouponList);
            return result;
        }
        /// <summary>
        /// 创建店铺首页优惠券批次接口
        /// </summary>
        public async Task<CreatePromotionHomeCouponResponseModel> CreatePromotionHomeCouponAsync(CreatePromotionHomeCouponRequestModel createPromotionHomeCoupon)
        {
            var result = await PostAsync<CreatePromotionHomeCouponRequestModel, CreatePromotionHomeCouponResponseModel>("pdd.promotion.home.coupon.create", createPromotionHomeCoupon);
            return result;
        }
        /// <summary>
        /// 限时限量购活动结束接口
        /// </summary>
        public async Task<CancelPromotionLimitedActivityResponseModel> CancelPromotionLimitedActivityAsync(CancelPromotionLimitedActivityRequestModel cancelPromotionLimitedActivity)
        {
            var result = await PostAsync<CancelPromotionLimitedActivityRequestModel, CancelPromotionLimitedActivityResponseModel>("pdd.promotion.limited.activity.cancel", cancelPromotionLimitedActivity);
            return result;
        }
        /// <summary>
        /// 限时限量购活动创建接口
        /// </summary>
        public async Task<CreatePromotionLimitedActivityResponseModel> CreatePromotionLimitedActivityAsync(CreatePromotionLimitedActivityRequestModel createPromotionLimitedActivity)
        {
            var result = await PostAsync<CreatePromotionLimitedActivityRequestModel, CreatePromotionLimitedActivityResponseModel>("pdd.promotion.limited.activity.create", createPromotionLimitedActivity);
            return result;
        }
        /// <summary>
        /// 限时限量购活动列表查询
        /// </summary>
        public async Task<GetPromotionLimitedDiscountListResponseModel> GetPromotionLimitedDiscountListAsync(GetPromotionLimitedDiscountListRequestModel getPromotionLimitedDiscountList)
        {
            var result = await PostAsync<GetPromotionLimitedDiscountListRequestModel, GetPromotionLimitedDiscountListResponseModel>("pdd.promotion.limited.discount.list.get", getPromotionLimitedDiscountList);
            return result;
        }
        /// <summary>
        /// 限时限量购可选商品查询接口
        /// </summary>
        public async Task<GetPromotionLimitedQualifiedGoodsResponseModel> GetPromotionLimitedQualifiedGoodsAsync(GetPromotionLimitedQualifiedGoodsRequestModel getPromotionLimitedQualifiedGoods)
        {
            var result = await PostAsync<GetPromotionLimitedQualifiedGoodsRequestModel, GetPromotionLimitedQualifiedGoodsResponseModel>("pdd.promotion.limited.qualified.goods.get", getPromotionLimitedQualifiedGoods);
            return result;
        }
        /// <summary>
        /// 限时限量购可选sku查询接口
        /// </summary>
        public async Task<GetPromotionLimitedQualifiedSkuResponseModel> GetPromotionLimitedQualifiedSkuAsync(GetPromotionLimitedQualifiedSkuRequestModel getPromotionLimitedQualifiedSku)
        {
            var result = await PostAsync<GetPromotionLimitedQualifiedSkuRequestModel, GetPromotionLimitedQualifiedSkuResponseModel>("pdd.promotion.limited.qualified.sku.get", getPromotionLimitedQualifiedSku);
            return result;
        }
        /// <summary>
        /// 店铺优惠券批次列表接口
        /// </summary>
        public async Task<GetPromotionMerchantCouponListResponseModel> GetPromotionMerchantCouponListAsync(GetPromotionMerchantCouponListRequestModel getPromotionMerchantCouponList)
        {
            var result = await PostAsync<GetPromotionMerchantCouponListRequestModel, GetPromotionMerchantCouponListResponseModel>("pdd.promotion.merchant.coupon.list.get", getPromotionMerchantCouponList);
            return result;
        }

    }
}
