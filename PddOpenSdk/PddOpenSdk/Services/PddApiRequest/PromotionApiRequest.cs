namespace PddOpenSdk.Services.PddApiRequest
{
    public class promotion extends Request {
        /// <summary>
/// 关闭批次接口
/// </summary>
/// <param name="BatchId">券批次ID</param>
public async Task<ClosePromotionCouponApiResult> ClosePromotionCouponAsync(number BatchId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("batch_id",Batch Id);
    
    var result = Post<ClosePromotionCouponApiResult>(pdd.promotion.coupon.close,);
    return JsonConvert.DeserializeObject<ClosePromotionCouponApiResult>(result);
}/// <summary>
/// 增加优惠券发行数量接口
/// </summary>
/// <param name="BatchId">券批次ID</param>
/// <param name="AddQuantity">要增加的数量</param>
public async Task<AddPromotionCouponQuantityApiResult> AddPromotionCouponQuantityAsync(number BatchId,number AddQuantity)
{
    var dic = new Dictionary<string, string>();
    dic.Add("batch_id",Batch Id);
dic.Add("add_quantity",Add Quantity);
    
    var result = Post<AddPromotionCouponQuantityApiResult>(pdd.promotion.coupon.quantity.add,);
    return JsonConvert.DeserializeObject<AddPromotionCouponQuantityApiResult>(result);
}/// <summary>
/// 创建无门槛商品劵批次接口
/// </summary>
/// <param name="BatchDesc">描述</param>
/// <param name="BatchStartTime">开始时间，指到格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)的总毫秒数</param>
/// <param name="BatchEndTime">结束时间，指到格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)的总毫秒数</param>
/// <param name="Discount">优惠金额	单位: 分</param>
/// <param name="InitQuantity">可领取数量</param>
/// <param name="UserLimit">每个用户限领张数</param>
/// <param name="GoodsId">商品ID</param>
public async Task<CreatePromotionGoodsCouponApiResult> CreatePromotionGoodsCouponAsync(string BatchDesc,number BatchStartTime,number BatchEndTime,number Discount,number InitQuantity,number UserLimit,number GoodsId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("batch_desc",Batch Desc);
dic.Add("batch_start_time",Batch Start Time);
dic.Add("batch_end_time",Batch End Time);
dic.Add("discount",Discount);
dic.Add("init_quantity",Init Quantity);
dic.Add("user_limit",User Limit);
dic.Add("goods_id",Goods Id);
    
    var result = Post<CreatePromotionGoodsCouponApiResult>(pdd.promotion.goods.coupon.create,);
    return JsonConvert.DeserializeObject<CreatePromotionGoodsCouponApiResult>(result);
}/// <summary>
/// 商品优惠券批次列表查询
/// </summary>
/// <param name="Page">页码，默认1</param>
/// <param name="PageSize">每页数量，默认100</param>
/// <param name="GoodsId">商品ID</param>
/// <param name="QueryRange">查询范围	0 全部，1 多多进宝券，2 无门槛商品券；默认1</param>
/// <param name="BatchStatus">批次状态	1 领取中，2 已领完，3 已结束，4 已暂停</param>
/// <param name="SortBy">排序	1 创建时间正序，2 创建时间倒序，3 开始时间正序，4 开始时间倒序，5 初始数量正序， 6 初始数量倒序，7 领取数量正序，8 领取数量倒序；默认2</param>
public async Task<GetPromotionGoodsCouponListApiResult> GetPromotionGoodsCouponListAsync(number Page,number PageSize,number GoodsId,number QueryRange,number BatchStatus,number SortBy)
{
    var dic = new Dictionary<string, string>();
    dic.Add("page",Page);
dic.Add("page_size",Page Size);
dic.Add("goods_id",Goods Id);
dic.Add("query_range",Query Range);
dic.Add("batch_status",Batch Status);
dic.Add("sort_by",Sort By);
    
    var result = Post<GetPromotionGoodsCouponListApiResult>(pdd.promotion.goods.coupon.list.get,);
    return JsonConvert.DeserializeObject<GetPromotionGoodsCouponListApiResult>(result);
}/// <summary>
/// 创建店铺首页优惠券批次接口
/// </summary>
/// <param name="BatchDesc">描述</param>
/// <param name="BatchStartTime">开始时间，指到格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)的总毫秒数</param>
/// <param name="BatchEndTime">结束时间，指到格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)的总毫秒数</param>
/// <param name="Discount">优惠金额	单位: 分</param>
/// <param name="MinOrderAmount">使用优惠的订单最小金额	单位: 分</param>
/// <param name="InitQuantity">可领取数量</param>
/// <param name="UserLimit">每个用户限领张数</param>
public async Task<CreatePromotionHomeCouponApiResult> CreatePromotionHomeCouponAsync(string BatchDesc,number BatchStartTime,number BatchEndTime,number Discount,number MinOrderAmount,number InitQuantity,number UserLimit)
{
    var dic = new Dictionary<string, string>();
    dic.Add("batch_desc",Batch Desc);
dic.Add("batch_start_time",Batch Start Time);
dic.Add("batch_end_time",Batch End Time);
dic.Add("discount",Discount);
dic.Add("min_order_amount",Min Order Amount);
dic.Add("init_quantity",Init Quantity);
dic.Add("user_limit",User Limit);
    
    var result = Post<CreatePromotionHomeCouponApiResult>(pdd.promotion.home.coupon.create,);
    return JsonConvert.DeserializeObject<CreatePromotionHomeCouponApiResult>(result);
}/// <summary>
/// 店铺优惠券批次列表接口
/// </summary>
/// <param name="Page">页码，默认1</param>
/// <param name="PageSize">每页数量，默认100</param>
/// <param name="BatchStartTimeFrom">批次开始时间（范围开始）</param>
/// <param name="BatchStartTimeTo">批次开始时间（范围结束）</param>
/// <param name="BatchStatus">批次状态	1 领取中，2 已领完，3 已结束</param>
/// <param name="SortBy">排序	1 创建时间正序，2 创建时间倒序，3 开始时间正序，4 开始时间倒序，5 初始数量正序， 6 初始数量倒序，7 领取数量正序，8 领取数量倒序；默认2</param>
public async Task<GetPromotionMerchantCouponListApiResult> GetPromotionMerchantCouponListAsync(number Page,number PageSize,number BatchStartTimeFrom,number BatchStartTimeTo,number BatchStatus,number SortBy)
{
    var dic = new Dictionary<string, string>();
    dic.Add("page",Page);
dic.Add("page_size",Page Size);
dic.Add("batch_start_time_from",Batch Start Time From);
dic.Add("batch_start_time_to",Batch Start Time To);
dic.Add("batch_status",Batch Status);
dic.Add("sort_by",Sort By);
    
    var result = Post<GetPromotionMerchantCouponListApiResult>(pdd.promotion.merchant.coupon.list.get,);
    return JsonConvert.DeserializeObject<GetPromotionMerchantCouponListApiResult>(result);
}
    }
}
