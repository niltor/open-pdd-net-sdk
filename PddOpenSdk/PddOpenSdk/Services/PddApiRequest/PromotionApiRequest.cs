using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class PromotionApiRequest : PddRequest {
        /// <summary>
/// 关闭批次接口
/// </summary>
/// <param name="BatchId">券批次ID</param>
public async Task<ClosePromotionCouponApiResult> ClosePromotionCouponAsync(int BatchId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("batch_id",BatchId);
    
    var result = Post<ClosePromotionCouponApiResult>("pdd.promotion.coupon.close",dic);
    return JsonConvert.DeserializeObject<ClosePromotionCouponApiResult>(result);
}/// <summary>
/// 增加优惠券发行数量接口
/// </summary>
/// <param name="BatchId">券批次ID</param>
/// <param name="AddQuantity">要增加的数量</param>
public async Task<AddPromotionCouponQuantityApiResult> AddPromotionCouponQuantityAsync(int BatchId,int AddQuantity)
{
    var dic = new Dictionary<string, string>();
    dic.Add("batch_id",BatchId);
dic.Add("add_quantity",AddQuantity);
    
    var result = Post<AddPromotionCouponQuantityApiResult>("pdd.promotion.coupon.quantity.add",dic);
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
public async Task<CreatePromotionGoodsCouponApiResult> CreatePromotionGoodsCouponAsync(string BatchDesc,int BatchStartTime,int BatchEndTime,int Discount,int InitQuantity,int UserLimit,int GoodsId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("batch_desc",BatchDesc);
dic.Add("batch_start_time",BatchStartTime);
dic.Add("batch_end_time",BatchEndTime);
dic.Add("discount",Discount);
dic.Add("init_quantity",InitQuantity);
dic.Add("user_limit",UserLimit);
dic.Add("goods_id",GoodsId);
    
    var result = Post<CreatePromotionGoodsCouponApiResult>("pdd.promotion.goods.coupon.create",dic);
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
public async Task<GetPromotionGoodsCouponListApiResult> GetPromotionGoodsCouponListAsync(int Page,int PageSize,int GoodsId,int QueryRange,int BatchStatus,int SortBy)
{
    var dic = new Dictionary<string, string>();
    dic.Add("page",Page);
dic.Add("page_size",PageSize);
dic.Add("goods_id",GoodsId);
dic.Add("query_range",QueryRange);
dic.Add("batch_status",BatchStatus);
dic.Add("sort_by",SortBy);
    
    var result = Post<GetPromotionGoodsCouponListApiResult>("pdd.promotion.goods.coupon.list.get",dic);
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
public async Task<CreatePromotionHomeCouponApiResult> CreatePromotionHomeCouponAsync(string BatchDesc,int BatchStartTime,int BatchEndTime,int Discount,int MinOrderAmount,int InitQuantity,int UserLimit)
{
    var dic = new Dictionary<string, string>();
    dic.Add("batch_desc",BatchDesc);
dic.Add("batch_start_time",BatchStartTime);
dic.Add("batch_end_time",BatchEndTime);
dic.Add("discount",Discount);
dic.Add("min_order_amount",MinOrderAmount);
dic.Add("init_quantity",InitQuantity);
dic.Add("user_limit",UserLimit);
    
    var result = Post<CreatePromotionHomeCouponApiResult>("pdd.promotion.home.coupon.create",dic);
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
public async Task<GetPromotionMerchantCouponListApiResult> GetPromotionMerchantCouponListAsync(int Page,int PageSize,int BatchStartTimeFrom,int BatchStartTimeTo,int BatchStatus,int SortBy)
{
    var dic = new Dictionary<string, string>();
    dic.Add("page",Page);
dic.Add("page_size",PageSize);
dic.Add("batch_start_time_from",BatchStartTimeFrom);
dic.Add("batch_start_time_to",BatchStartTimeTo);
dic.Add("batch_status",BatchStatus);
dic.Add("sort_by",SortBy);
    
    var result = Post<GetPromotionMerchantCouponListApiResult>("pdd.promotion.merchant.coupon.list.get",dic);
    return JsonConvert.DeserializeObject<GetPromotionMerchantCouponListApiResult>(result);
}
    }
}
