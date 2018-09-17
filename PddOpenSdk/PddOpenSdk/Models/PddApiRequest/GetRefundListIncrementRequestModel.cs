using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetRefundListIncrementRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.refund.list.increment.get
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 必填，售后状态  1：全部 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款， 待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒 绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处 理，退款失败 13：买家逾期，超过有效期 14 : 换货补寄待商家处理 15:换货补寄待用户处理 16:换货补寄成功 17:换货补寄失败 18:换货补寄待用户确认完成
        /// </summary>
        [JsonProperty("after_sales_status")]
        public object AfterSalesStatus { get; set; }
        /// <summary>
        /// 必填，售后类型 1：全部 2：仅退款 3：退货退款 4：换货 5：缺货补寄
        /// </summary>
        [JsonProperty("after_sales_type")]
        public object AfterSalesType { get; set; }
        /// <summary>
        /// 必填，最后更新时间开始时间的UNIX时间戳，指格林威治时间 1970 年01月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00分 00 秒)起至现在的总秒数
        /// </summary>
        [JsonProperty("start_updated_at")]
        public object StartUpdatedAt { get; set; }
        /// <summary>
        /// 必填，最后更新时间结束时间的UNIX时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过 30 分钟
        /// </summary>
        [JsonProperty("end_updated_at")]
        public object EndUpdatedAt { get; set; }
        /// <summary>
        /// 返回数量，默认 100。最大 100
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 返回页码 默认 1，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

    }
}
