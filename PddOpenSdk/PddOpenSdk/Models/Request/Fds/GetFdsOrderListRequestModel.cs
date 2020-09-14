using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Fds
{
    public partial class GetFdsOrderListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 入参信息
        /// </summary>
        [JsonProperty("param_fds_order_list_get_request")]
        public ParamFdsOrderListGetRequestRequestModel ParamFdsOrderListGetRequest { get; set; }
        public partial class ParamFdsOrderListGetRequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 必填，更新时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总毫秒数 PS：开始时间结束时间间距不超过半小时
            /// </summary>
            [JsonProperty("end_updated_time")]
            public long EndUpdatedTime { get; set; }
            /// <summary>
            /// 返回页码，页码从 1 开始 PS：当前采用分页返回，数量和页数会一起传
            /// </summary>
            [JsonProperty("page")]
            public int Page { get; set; }
            /// <summary>
            /// 返回数量，最大 100
            /// </summary>
            [JsonProperty("page_size")]
            public int PageSize { get; set; }
            /// <summary>
            /// 必填，更新时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总毫秒数 PS：开始时间结束时间间距不超过半小时
            /// </summary>
            [JsonProperty("start_updated_time")]
            public long StartUpdatedTime { get; set; }

        }

    }

}
