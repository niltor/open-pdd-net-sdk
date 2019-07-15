using PddOpenSdk.Models.Request.Promotionmerchant;
using PddOpenSdk.Models.Response.Promotionmerchant;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class PromotionmerchantApi : PddCommonApi
    {
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
        /// 店铺优惠券批次列表接口
        /// </summary>
        public async Task<GetPromotionMerchantCouponListResponseModel> GetPromotionMerchantCouponListAsync(GetPromotionMerchantCouponListRequestModel getPromotionMerchantCouponList)
        {
            var result = await PostAsync<GetPromotionMerchantCouponListRequestModel, GetPromotionMerchantCouponListResponseModel>("pdd.promotion.merchant.coupon.list.get", getPromotionMerchantCouponList);
            return result;
        }

    }
}
