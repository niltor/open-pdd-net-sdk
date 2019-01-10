using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddkall
{
    public partial class GetDdkOauthLotteryNewListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广位ID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 最后更新时间--查询时间开始。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        [JsonProperty("start_time")]
        public long? StartTime { get; set; }
        /// <summary>
        /// 最后更新时间--查询时间结束。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
        /// </summary>
        [JsonProperty("end_time")]
        public long? EndTime { get; set; }
        /// <summary>
        /// 返回的每页结果列表数，默认为100，范围为10到100，建议使用40~50，可以提高成功率，减少超时数量。
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 第几页，从1到10000，默认1，注：使用最后更新时间范围增量同步时，必须采用倒序的分页方式（从最后一页往回取）才能避免漏的问题
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。
        /// </summary>
        [JsonProperty("customer_paramters")]
        public string CustomerParamters { get; set; }

    }

}
