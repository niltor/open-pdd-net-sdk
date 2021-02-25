using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Stock
{
    public partial class QueryStockWareWarehouseRequestModel : PddRequestModel
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestModel Request { get; set; }
        public partial class RequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 当前页数
            /// </summary>
            [JsonProperty("page")]
            public int Page { get; set; }
            /// <summary>
            /// 页显示数据条数
            /// </summary>
            [JsonProperty("page_size")]
            public int PageSize { get; set; }
            /// <summary>
            /// 货品编码列表
            /// </summary>
            [JsonProperty("ware_sn_list")]
            public List<string> WareSnList { get; set; }

        }

    }

}
