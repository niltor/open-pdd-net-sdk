using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class QueryDdkZsUnitGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("zs_unit_goods_query_response")]
        public ZsUnitGoodsQueryResponseResponseModel ZsUnitGoodsQueryResponse { get; set; }
        public partial class ZsUnitGoodsQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 请求到的结果数
            /// </summary>
            [JsonProperty("total_count")]
            public int? TotalCount { get; set; }
            /// <summary>
            /// 列表
            /// </summary>
            [JsonProperty("list")]
            public List<string> List { get; set; }

        }

    }

}
