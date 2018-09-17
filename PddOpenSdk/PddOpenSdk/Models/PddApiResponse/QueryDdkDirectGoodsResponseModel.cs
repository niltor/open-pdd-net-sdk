using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QueryDdkDirectGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回商品总数
        /// </summary>
        [JsonProperty("total_count")]
        public object TotalCount { get; set; }
        /// <summary>
        /// 多多进宝商品对象列表
        /// </summary>
        [JsonProperty("list")]
        public object List { get; set; }

        public partial class ListResponseModel : PddResponseModel
        {

        }

    }
}
