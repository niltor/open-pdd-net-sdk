using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class RefundApiRequest : PddRequest {
        /// <summary>
/// 获取商家退货地址库
/// </summary>
/// <param name="Type">该值为：pdd.refund.address.list.get</param>
public async Task<GetRefundAddressListApiResult> GetRefundAddressListAsync(string Type)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
    
    var result = Post<GetRefundAddressListApiResult>("pdd.refund.address.list.get",dic);
    return JsonConvert.DeserializeObject<GetRefundAddressListApiResult>(result);
}/// <summary>
/// 售后列表接口
/// </summary>
/// <param name="Type">该值为：pdd.refund.list.increment.get</param>
/// <param name="AfterSalesStatus">必填，售后状态  1：全部 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款， 待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒 绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处 理，退款失败 13：买家逾期，超过有效期 14 : 换货补寄待商家处理 15:换货补寄待用户处理 16:换货补寄成功 17:换货补寄失败 18:换货补寄待用户确认完成</param>
/// <param name="AfterSalesType">必填，售后类型 1：全部 2：仅退款 3：退货退款 4：换货 5：缺货补寄</param>
/// <param name="StartUpdatedAt">必填，最后更新时间开始时间的UNIX时间戳，指格林威治时间 1970 年01月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00分 00 秒)起至现在的总秒数</param>
/// <param name="EndUpdatedAt">必填，最后更新时间结束时间的UNIX时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过 30 分钟</param>
/// <param name="PageSize">返回数量，默认 100。最大 100</param>
/// <param name="Page">返回页码 默认 1，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值</param>
public async Task<GetRefundListIncrementApiResult> GetRefundListIncrementAsync(string Type,string AfterSalesStatus,string AfterSalesType,string StartUpdatedAt,string EndUpdatedAt,int PageSize,int Page)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("after_sales_status",AfterSalesStatus);
dic.Add("after_sales_type",AfterSalesType);
dic.Add("start_updated_at",StartUpdatedAt);
dic.Add("end_updated_at",EndUpdatedAt);
dic.Add("page_size",PageSize);
dic.Add("page",Page);
    
    var result = Post<GetRefundListIncrementApiResult>("pdd.refund.list.increment.get",dic);
    return JsonConvert.DeserializeObject<GetRefundListIncrementApiResult>(result);
}/// <summary>
/// 售后校验接口
/// </summary>
/// <param name="Type">该值为：pdd.refund.status.check</param>
/// <param name="OrderSns">20150909-452750051,20150909-452750134 用逗号分开</param>
public async Task<CheckRefundStatusApiResult> CheckRefundStatusAsync(string Type,string OrderSns)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("order_sns",OrderSns);
    
    var result = Post<CheckRefundStatusApiResult>("pdd.refund.status.check",dic);
    return JsonConvert.DeserializeObject<CheckRefundStatusApiResult>(result);
}
    }
}
