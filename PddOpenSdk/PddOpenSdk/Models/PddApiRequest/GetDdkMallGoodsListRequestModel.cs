using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetDdkMallGoodsListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }
        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page_number")]
        public int PageNumber { get; set; }
        /// <summary>
        /// 每页商品数量
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

    }
}
