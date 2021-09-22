using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Invoice
{
    public partial class QueryEinvoiceInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 最后更新时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数。开始时间结束时间间距不超过1小时。不能查询最近5分钟内的数据。开区间，返回数据不包含end_time
        /// </summary>
        [JsonProperty("end_time")]
        public long EndTime { get; set; }
        /// <summary>
        /// 发票类型 0-蓝票，1-红票，不传为全部
        /// </summary>
        [JsonProperty("invoice_type")]
        public int? InvoiceType { get; set; }
        /// <summary>
        /// 页码。页码从 1开始
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// 返回数量。最小1，最大 50
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 最后更新时间开始时间的时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数。只能查询30天内的数据。闭区间，返回数据包含start_time
        /// </summary>
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

    }

}
