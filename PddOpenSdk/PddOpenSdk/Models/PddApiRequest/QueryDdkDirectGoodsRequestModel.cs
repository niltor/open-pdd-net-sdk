using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class QueryDdkDirectGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 默认值1，商品分页数
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }
        /// <summary>
        /// 默认100，每页商品数量
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

    }
}
